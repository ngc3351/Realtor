using System;
using System.Collections.Generic;
using System.Data;
using BLToolkit.Common;
using BLToolkit.Mapping;

namespace Realtor.Services.Abstract
{
    interface IDataService
    {
        List<FieldView> GetFView(int typeCriteria, int actionCriteria);


        List<Company> GetCompanies();

        Company GetCompany(int ownerId);

        void CreateCompany(Company company);


        List<ObjSale> GetSalesObjects();

        List<ObjSale> GetSalesObjects(string idSetup, DateTime date);

        List<ObjSale> GetSalesObjects(int typeCriteria, int actionCriteria, int cnt);

        List<ObjSale> GetSalesObjects(int idCity, ObjectTypeCriteria typeCriteria, ObjectActionCriteria actionCriteria, int cnt);

        List<ObjSale> GetSalesObjects(ObjectTypeCriteria typeCriteria, ObjectActionCriteria actionCriteria, int cnt);

        List<ObjSale> GetSalesObjects(ObjectSearchCriteria criteria);

        DataTable GetSalesObjectsDataTable(string typeCriteria, string actionCriteria, int cnt);


        void InsertSalesObjects(List<ObjSale> list);

        void InsertSalesObject(ObjSale obj);

        void UpdateSalesObject(ObjSale obj);

        void DeleteObject(string objectId);


        List<Client> GetClients(int ownerId, int agentId);

        Client GetClient(int clientId);

        Client GetClient(int clientId, string setupId);

        void AddClient(Client obj);

        void UpdateClient(Client obj);

        void DeleteClient(int clientId);
        

        List<CityEntity> GetCityes();

        List<CityRayon> GetRayons();

        List<CityRayon> GetRayons(int idCity);

        List<CityStreet> GetStreets();

        List<CityStreet> GetStreets(int idCity);

        //List<CityStreet> GetStreets(int idCity, int idRayon);
    }

    public abstract class ObjectSearchCriteria : EntityBase<ObjectSearchCriteria>
    {
        public abstract ObjectTypeCriteria ObjectType { get; set; }

        public abstract ObjectActionCriteria ObjectAction { get; set; }

        public abstract string IDsetup { get; set; }

        public abstract int IDaction { get; set; }

        [NullValue(0)]
        public abstract int IDobject { get; set; }

        [NullValue(0)]
        public abstract int IDowner { get; set; }

        [NullValue(0)]
        public abstract int IDperson { get; set; }

        [NullValue(0)]
        public abstract int IDcity { get; set; }

        [NullValue(0)]
        public abstract int IDrayon { get; set; }

        [NullValue(0)]
        public abstract int IDstreet { get; set; }

        [NullValue(0)]
        public abstract byte? Flats { get; set; }

        [NullValue(0)]
        public abstract byte? Flours { get; set; }

        public abstract FlourCriteriaEnum Flour { get; set; }

        [NullValue("")]
        public abstract string Material { get; set; }

        [NullValue("")]
        public abstract string Series { get; set; }

        [NullValue("")]
        public abstract string New { get; set; }

        [NullValue("")]
        public abstract string Live { get; set; }

        public abstract Criteria<float?> SqAll { get; set; }

        public abstract Criteria<float?> SqKitch { get; set; }

        public abstract Criteria<float?> SqHome { get; set; }

        public abstract Criteria<float?> SqLand { get; set; }

        [NullValue("")]
        public abstract string Balcony { get; set; }

        [NullValue("")]
        public abstract string WC { get; set; }

        [NullValue("")]
        public abstract string Phone { get; set; }

        [NullValue("")]
        public abstract string Mebel { get; set; }

        [NullValue("")]
        public abstract CriteriaGroup Electricity { get; set; }

        [NullValue("")]
        public abstract CriteriaGroup Hot { get; set; }

        [NullValue("")]
        public abstract CriteriaGroup Water { get; set; }

        //[NullValue((byte)0)]
        //public abstract Criteria<byte> Prava { get; set; }

        public abstract Criteria<float?> Price { get; set; }

        [NullValue((byte)0)]
        public abstract byte Prava { get; set; }

        [NullValue("")]
        public abstract string Term { get; set; }

        [NullValue(0)]
        public abstract sbyte? Stat { get; set; }

        [NullValue("")]
        public abstract string ForSq { get; set; }

        public abstract PeriodCriteriaEnum Period { get; set; }
    }

    public abstract class CriteriaGroup : EntityBase<CriteriaGroup>
    {
        public static CriteriaGroup CreateInstance(GroupOperator opr, params ICriteria[] arr)
        {
            CriteriaGroup grp = CreateInstance();
            grp.Criteries = arr;
            grp.GroupOperator = opr;
            return grp;
        }

        public static CriteriaGroup CreateInstance(GroupOperator opr, CriteriaGroup[] groups, params ICriteria[] arr)
        {
            CriteriaGroup grp = CreateInstance();
            grp.Criteries = arr;
            grp.GroupOperator = opr;
            grp.Groups = groups;
            return grp;
        }

        public abstract ICriteria[] Criteries { get; set; }
        public abstract CriteriaGroup[] Groups { get; set; }
        public abstract GroupOperator GroupOperator { get; set; }
    }

    public abstract class Criteria<T> : EntityBase<Criteria<T>>, ICriteria
    {

        public static Criteria<T> CreateInstance(CompareOperator opr, T value)
        {
            return CreateInstance(opr, value, string.Empty);
        }

        public static Criteria<T> CreateInstance(CompareOperator opr, string field)
        {
            return CreateInstance(opr, default(T), field);
        }

        public static Criteria<T> CreateInstance(CompareOperator opr, T value, string field)
        {
            Criteria<T> ctr = CreateInstance();
            ctr.Сompare = opr;
            ctr.Value = value;
            ctr.Field = field;
            return ctr;
        }

        public abstract CompareOperator Сompare { get; set; }
        public abstract T Value { get; set; }
        public abstract string Field { get; set; }

        public object GetValue()
        {
            return Value;
        }
    }

    public interface ICriteria
    {
        CompareOperator Сompare { get; set; }
        object GetValue();
    }

    public class ObjectTypeCriteria
    {
        public int _type;
        public CompareOperator _compare;

        public ObjectTypeCriteria()
        {
            _compare = CompareOperator.Equal;
        }

        public ObjectTypeCriteria(int type)
        {
            _type = type;
            _compare = CompareOperator.Equal;
        }

        public ObjectTypeCriteria(int type, CompareOperator compare)
        {
            _type = type;
            _compare = compare;
        }

        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public CompareOperator Compare
        {
            get { return _compare; }
            set { _compare = value; }
        }
    }

    public class ObjectActionCriteria
    {
        public int _action;
        public CompareOperator _compare;

        public ObjectActionCriteria()
        {
            _compare = CompareOperator.Equal;
        }

        public ObjectActionCriteria(int type)
        {
            _action = type;
            _compare = CompareOperator.Equal;
        }

        public ObjectActionCriteria(int action, CompareOperator compare)
        {
            _action = action;
            _compare = compare;
        }

        public int Action
        {
            get { return _action; }
            set { _action = value; }
        }

        public CompareOperator Compare
        {
            get { return _compare; }
            set { _compare = value; }
        }
    }

    public enum CompareOperator
    {
        [LocalizedDisplayName("равно")]
        Equal,
        [LocalizedDisplayName("больше")]
        Greater,
        [LocalizedDisplayName("меньше")]
        Less,
        [LocalizedDisplayName("больше или равно")]
        AE,
        [LocalizedDisplayName("меньше или равно")]
        LE,
        [LocalizedDisplayName("не равно")]
        NE
    }

    public enum GroupOperator
    {
        AND,
        OR
    }

}
