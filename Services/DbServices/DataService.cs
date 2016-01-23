using System;
using System.Data;
using System.Reflection;
using System.Collections.Generic;
using BLToolkit.Data;
using BLToolkit.Mapping;
using Realtor.Services.Abstract;

namespace Realtor.Services.DbServices
{
    class DataService : IDataService
    {
        readonly DbManager _db;

        public DataService(DbManager db)
        {
            _db = db;
        }


        public List<ObjSale> GetSalesObjects()
        {
            return _db.SetCommand("SELECT * FROM objsale limit 0,100").ExecuteList<ObjSale>();
        }

        public List<ObjSale> GetSalesObjects(string idSetup, DateTime date)
        {
            string sql = string.Concat("SELECT * FROM objsale where IDSetup = '", idSetup, "' and DateUpdate > '", date.ToString("yyyy-MM-dd HH:mm:ss"), "'");
            return _db.SetCommand(sql).ExecuteList<ObjSale>();
        }

        public List<ObjSale> GetSalesObjects(int typeCriteria, int actionCriteria, int cnt)
        {
            string sql = string.Format("SELECT * FROM objsale WHERE IDobject = {0} AND IDaction = {1} AND DateUpdate_1 <> '00000000000000' order by DateReg desc limit 0,{2}", typeCriteria, actionCriteria, cnt);
            return _db.SetCommand(sql).ExecuteList<ObjSale>();
        }

        public List<ObjSale> GetSalesObjects(ObjectTypeCriteria typeCriteria, ObjectActionCriteria actionCriteria, int cnt)
        {
            string sql = string.Format(
                    "SELECT * FROM objsale WHERE IDobject {0}{1} AND IDaction {2}{3} AND DateUpdate_1 <> '00000000000000' order by DateReg desc limit 0,{4}"
                    , (typeCriteria.Compare == CompareOperator.AE) ? ">=": "="
                    , typeCriteria.Type
                    , (actionCriteria.Compare == CompareOperator.AE) ? ">=" : "="
                    , actionCriteria.Action, cnt
                );
            return _db.SetCommand(sql).ExecuteList<ObjSale>();
        }

        public List<ObjSale> GetSalesObjects(int idCity, ObjectTypeCriteria typeCriteria, ObjectActionCriteria actionCriteria, int cnt)
        {
            string sql = string.Format(
                    "SELECT * FROM objsale WHERE IDobject {0}{1} AND IDaction {2}{3} AND IDcity = {4} AND DateUpdate_1 <> '00000000000000' order by DateReg desc limit 0,{5}"
                    , (typeCriteria.Compare == CompareOperator.AE) ? ">=" : "="
                    , typeCriteria.Type
                    , (actionCriteria.Compare == CompareOperator.AE) ? ">=" : "="
                    , actionCriteria.Action
                    , idCity
                    , cnt
                );
            return _db.SetCommand(sql).ExecuteList<ObjSale>();
        }

        public List<ObjSale> GetSalesObjects(ObjectSearchCriteria criteria)
        {
            string criteriaStr = string.Empty;
            foreach (PropertyInfo info in typeof(ObjectSearchCriteria).GetProperties())
            {
                object o = info.GetValue(criteria, null);
                string str = string.Empty;

                NullValueAttribute attr = null;
                object[] arr = info.GetCustomAttributes(typeof(NullValueAttribute), true);
                if (arr.Length > 0)
                    attr = (NullValueAttribute)arr[0];

                if (o is FlourCriteriaEnum)
                {
                    switch ((FlourCriteriaEnum)o)
                    {
                        case FlourCriteriaEnum.NotFirstLast:
                            str = string.Format("({0} > 1 and {0} < Flours)", info.Name);
                            break;

                        case FlourCriteriaEnum.BaseOrSubBase:
                            str = string.Format("{0} < 0", info.Name);
                            break;

                        case FlourCriteriaEnum.First:
                            str = string.Format("{0} = 1", info.Name);
                            break;

                        case FlourCriteriaEnum.Last:
                            str = string.Format("{0} = Flours", info.Name);
                            break;

                        case FlourCriteriaEnum.NotFirst:
                            str = string.Format("{0} > 1", info.Name);
                            break;

                        case FlourCriteriaEnum.NotLast:
                            str = string.Format("({0} > 0 and Flour < Flours)", info.Name);
                            break;
                    }
                }
                else if (o is PeriodCriteriaEnum)
                {
                    switch ((PeriodCriteriaEnum)o)
                    {
                        case PeriodCriteriaEnum.Last7Days:
                            str = string.Format("DateUpdate > DATE_SUB(CURRENT_DATE, INTERVAL 7 DAY)");
                            break;

                        case PeriodCriteriaEnum.LastMonth:
                            str = string.Format("DateUpdate > DATE_SUB(CURRENT_DATE, INTERVAL 1 MONTH)");
                            break;
                    }
                }
                else if (o is ICriteria)
                {
                    ICriteria icriteria = (ICriteria)o;
                    if (icriteria.GetValue() != null) // && attr != null && !attr.Value.Equals(icriteria.GetValue()))
                        str = string.Format("{0}{1}{2}", info.Name, CompareOperatorToString(icriteria.Ñompare), icriteria.GetValue());
                }
                else if (o is CriteriaGroup)
                {
                    CriteriaGroup grp = (CriteriaGroup)o;
                    if (grp != null && grp.Criteries.Length > 1)
                    {
                        foreach (ICriteria critery in grp.Criteries)
                        {
                            if (str != string.Empty)
                                str += string.Format(" {0} ", grp.GroupOperator.ToString());
                            str += string.Format("{0}{1}'{2}'", info.Name, CompareOperatorToString(critery.Ñompare), critery.GetValue());
                        }

                        str = string.Format("({0})", str);
                    }
                }
                else
                {
                    if (o != null && attr != null && !attr.Value.Equals(o))
                        str = string.Format("{0}=\"{1}\"", info.Name, o);
                }

                if (str != string.Empty)
                {
                    if (criteriaStr != string.Empty)
                        criteriaStr += " AND ";

                    criteriaStr += str;
                }
            }

            string sql = string.Format(
                "SELECT * FROM objsale WHERE IDobject {0}{1} AND IDaction {2}{3} AND {4} DateUpdate_1 <> '00000000000000' order by DateReg desc limit 0,{5}"
                , (criteria.ObjectType.Compare == CompareOperator.AE) ? ">=" : "="
                , criteria.ObjectType.Type
                , (criteria.ObjectAction.Compare == CompareOperator.AE) ? ">=" : "="
                , criteria.ObjectAction.Action
                , criteriaStr + ((criteriaStr != string.Empty)? " AND": "")
                , 500
            );

            System.Diagnostics.Debug.WriteLine(sql);
            return _db.SetCommand(sql).ExecuteList<ObjSale>();
        }

        public DataTable GetSalesObjectsDataTable(string typeCriteria, string actionCriteria, int cnt)
        {
            string sql = string.Format("SELECT * FROM objsale WHERE IDobject {0} AND IDaction {1} AND DateUpdate_1 <> '00000000000000' and idowner > 0 limit 0,{2}", typeCriteria, actionCriteria, cnt);
            return null;
            //!!!return _db.SetCommand(sql).ExecuteDataTable(new realtorDataSet.objsaleDataTable());
        }


        public void InsertSalesObjects(List<ObjSale> list)
        {
            foreach (ObjSale obj in list)
                InsertSalesObject(obj);
        }

        public void InsertSalesObject(ObjSale obj)
        {
            string sql = string.Concat("DELETE FROM objsale WHERE IDobj = '", obj.IDobj, "'");// AND IDsetup = '", obj.IDsetup, "' AND IDowner = ", obj.IDowner);
            _db.SetCommand(sql).ExecuteNonQuery();

            sql = string.Concat("INSERT objsale VALUES (?IDobj ,?IDsetup ,?IDaction ,?IDobject ,?IDowner ,?IDperson ,?IDclient ,?IDcity ,?IDrayon ,?IDstreet ,?IDreg ,?X ,?Y ,?Img ,?DateRegUtc ,?DateRegUtc ,?Object ,?Flats ,?Material ,?Live ,?Series ,?SqAll ,?SqHome ,?SqKitch ,?SqLand ,?Raspol ,?Flour ,?Flours ,?Balcony ,?WC ,?Phone ,?Mebel ,?Electricity ,?Hot ,?Water ,?Entrance ,?Security ,?Parking ,?New ,?Privat ,?Prava ,?Rayon ,?Street ,?Price ,?Term ,?ForSQ ,?PriceMeter ,?Contact ,?PhoneObj ,?MailObj ,?PagerObj ,?Views ,?Arhiv ,?Upload ,?Stat ,?Note ,?DateUpdate_1 )");

            int i = _db.SetCommand(sql, _db.CreateParameters(obj)).ExecuteNonQuery();
        }

        public void UpdateSalesObject(ObjSale obj)
        {
            string sql = string.Concat("UPDATE objsale SET IDobject=?IDobject, IDclient=?IDclient, IDcity=?IDcity, IDrayon=?IDrayon, IDstreet=?IDstreet, IDreg=?IDreg, X=?X, Y=?Y, Img=?Img, DateReg=?DateReg, DateUpdate=?DateUpdate, Object=?Object, Flats=?Flats, Material=?Material, Live=?Live, Series=?Series, SqAll=?SqAll, SqHome=?SqHome, SqKitch=?SqKitch, SqLand=?SqLand, Raspol=?Raspol, Flour=?Flour, Flours=?Flours, Balcony=?Balcony, WC=?WC, Phone=?Phone, Mebel=?Mebel, Electricity=?Electricity, Hot=?Hot, Water=?Water, Entrance=?Entrance, Security=?Security, Parking=?Parking, New=?New, Privat=?Privat, Prava=?Prava, Rayon=?Rayon, Street=?Street, Price=?Price, Term=?Term, ForSQ=?ForSQ, PriceMeter=?PriceMeter, Contact=?Contact, PhoneObj=?PhoneObj, MailObj=?MailObj, PagerObj=?PagerObj, Views=?Views, Arhiv=?Arhiv, Upload=?Upload, Stat=?Stat, Note=?Note, DateUpdate_1=?DateUpdate_1 WHERE IDobj = ?IDobj");
            int i = _db.SetCommand(sql, _db.CreateParameters(obj)).ExecuteNonQuery();
        }

        public void DeleteObject(string objectId)
        {
            string sql = string.Concat("DELETE FROM objsale WHERE IDobj = '", objectId, "'");
            int i = _db.SetCommand(sql).ExecuteNonQuery();
        }

        public List<FieldView> GetFView(int typeCriteria, int actionCriteria)
        {
            string sql = string.Format("SELECT * FROM fview WHERE Obj = {0} AND Act = {1}", typeCriteria, actionCriteria);
            return _db.SetCommand(sql).ExecuteList<FieldView>();
        }


        public List<Company> GetCompanies()
        {
            return _db.SetCommand("SELECT * FROM owner").ExecuteList<Company>();
        }

        public void CreateCompany(Company company)
        {
            string sql =string.Concat(
                                "INSERT INTO owner(DateUpd, IdCity, IdOwner, Name, Address, Phone, Mail) VALUES (" 
                              , "'", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "'"
                              , ","
                              , company.IdCity
                              , ","
                              , company.IdOwner
                              , ","
                              , "'", company.Name, "'"
                              , ","
                              , "'", company.Address, "'"
                              , ","
                              , "'", company.Phone, "'"
                              , ","
                              , "'", company.Mail, "'"
                              , ")");

            int i = _db.SetCommand(sql).ExecuteNonQuery();
        }

        public Company GetCompany(int ownerId)
        {
            string sql = string.Concat("SELECT * FROM owner WHERE IdOwner = ", ownerId);
            return _db.SetCommand(sql).ExecuteObject<Company>();
        }


        public List<Client> GetClients(int ownerId, int agentId)
        {
            string sql = string.Concat(
                    "SELECT * FROM clients WHERE IDowner = "
                    , ownerId
                    , " and IDperson = "
                    , agentId
                    , " order by Names desc");

            return _db.SetCommand(sql).ExecuteList<Client>();
        }

        public Client GetClient(int clientId)
        {
            string sql = string.Concat("SELECT * FROM clients WHERE IDclient = ", clientId);
            return _db.SetCommand(sql).ExecuteObject<Client>();
        }

        public Client GetClient(int clientId, string setupId)
        {
            string sql = string.Concat("SELECT * FROM clients WHERE IDclient = "
                , clientId
                , " AND IDsetup = '" + setupId
                , "'");

            return _db.SetCommand(sql).ExecuteObject<Client>();
        }

        public void AddClient(Client obj)
        {
            _db.SetCommand("INSERT clients(IDsetup, IDperson, IDowner, DateReg, Names, City, Address, Phone, Mail, Pager, Types, Stat) VALUES (?IDsetup, ?IDperson, ?IDowner, ?DateReg, ?Names, ?City, ?Address, ?Phone, ?Mail, ?Pager, ?Types, ?Stat)"
                , _db.CreateParameters(obj)).ExecuteNonQuery();
            obj.IDclient = LastInsertId<int>();
        }

        public void DeleteClient(int clientId)
        {
            string sql = string.Concat("DELETE FROM clients WHERE IDclient = ", clientId);
            int i = _db.SetCommand(sql).ExecuteNonQuery();
        }

        public void UpdateClient(Client obj)
        {
            string sql = string.Concat("UPDATE clients SET "
            , " IDsetup = '", obj.IDsetup
            , "', IDowner = ", obj.IDowner
            , ", DateReg = '", obj.DateReg.ToString("yyyy-MM-dd HH:mm:ss")
            , "', Names = '", obj.Names
            , "', City = '", obj.City
            , "', Address = '", obj.Address
            , "', Phone = '", obj.Phone
            , "', Mail = '", obj.Mail
            , "', Pager = '", obj.Pager
            , "', Types = '", obj.Types
            , "', Stat = '", obj.Stat
            , "' WHERE IDclient = ", obj.IDclient);

            int i = _db.SetCommand(sql).ExecuteNonQuery();
        }


        public List<CityStreet> GetStreets()
        {
            return _db.SetCommand("SELECT IdStreet, Street FROM street").ExecuteList<CityStreet>();
        }

        public List<CityStreet> GetStreets(int idCity)
        {
            return _db.SetCommand("SELECT IdStreet, Street FROM street where IDCity=" + idCity).ExecuteList<CityStreet>();
        }

        public List<CityRayon> GetRayons()
        {
            return _db.SetCommand("SELECT * FROM rayon").ExecuteList<CityRayon>();
        }

        public List<CityRayon> GetRayons(int idCity)
        {
            return _db.SetCommand("SELECT * FROM rayon where IDCity=" + idCity).ExecuteList<CityRayon>();
        }

        public List<CityEntity> GetCityes()
        {
            return _db.SetCommand("SELECT * FROM city").ExecuteList<CityEntity>();
        }

        public T LastInsertId<T>()
        {
            return _db.SetCommand("SELECT LAST_INSERT_ID()").ExecuteScalar<T>();
        }

        private string CompareOperatorToString(CompareOperator value)
        {
            switch (value)
            {
                case CompareOperator.Equal:
                    return "=";
                case CompareOperator.Greater:
                    return ">";
                case CompareOperator.AE:
                    return ">=";
                case CompareOperator.Less:
                    return "<";
                case CompareOperator.LE:
                    return "<=";
                case CompareOperator.NE:
                    return "<>";
            }

            return string.Empty;
        }
    }
}
