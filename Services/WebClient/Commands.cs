using System;
using System.Collections.Generic;

namespace Realtor.Services
{
    public class Query
    {
        private List<QueryArgument> _attrs = new List<QueryArgument>();
        private string _id;

        public Query(string id)
        {
            Id = id;
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public List<QueryArgument> Properties
        {
            get { return _attrs; }
            set { _attrs = value; }
        }

        public QueryArgument GetProperty(string name)
        {
            foreach (QueryArgument property in Properties)
                if (property.Name == name)
                    return property;

            return null;
        }

        public List<QueryArgument> GetProperties(string name)
        {
            List<QueryArgument> res = new List<QueryArgument>();

            foreach (QueryArgument property in Properties)
                if (property.Name == name)
                    res.Add(property);

            return res;
        }

        public string TryGetPropertyValue(string name)
        {
            foreach (QueryArgument property in Properties)
                if (property.Name == name)
                    return property.Value;

            return string.Empty;
        }

        public void AddProperty(QueryArgument property)
        {
            Properties.Add(property);
        }

        public void AddProperty(string name, object value)
        {
            QueryArgument property = new QueryArgument();
            property.Name = name;
            property.Value = value.ToString();

            Properties.Add(property);
        }
    }

    public class QueryArgument
    {
        private string _name;
        private string _value;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public int ValueInteger
        {
            get
            {
                int value = -1;
                int.TryParse(Value, out value);
                return value;
            }
            set { Value = value.ToString(); }
        }
    }


    internal class Response : Query
    {
        private List<Exception> _errors;
        private bool _errorStatus;

        public Response(string id)
            : base(id)
        {
        }

        public bool OkStatus
        {
            get { return _errorStatus; }

            set { _errorStatus = value; }
        }

        public bool HasErrors
        {
            get { return (_errors == null || _errors.Count != 0); }
        }

        protected void Error(Exception e)
        {
            if (_errors == null)
                _errors = new List<Exception>();

            _errors.Add(e);
        }
    }


    internal abstract class CmdBase : Query
    {
        protected Query _res;

        public CmdBase(string id)
            : base(id)
        {
        }

        public void Execute(IWebClient client)
        {
            _res = client.SendCommand(this);
        }
    }

    internal class CmdCheckVersion : CmdBase
    {
        public CmdCheckVersion(string version)
            : base("CheckVersion")
        {
            AddProperty("version", version);
        }
    }

    internal class CmdCheckRegKey : CmdBase
    {
        public CmdCheckRegKey(string regKey, string idSetup)
            : base("CheckRegKey")
        {
            AddProperty("regkey", regKey);
            AddProperty("setupid", idSetup);
        }
    }

    internal class CmdActivate : CmdBase
    {
        public CmdActivate(string regKey, string idSetup)
            : base("Activate")
        {
            AddProperty("regkey", regKey);
            AddProperty("setupid", idSetup);
        }
    }

    internal class CmdLogin : CmdBase
    {
        public CmdLogin(string sn, string idSetup)
            : base("Login")
        {
            AddProperty("sn", sn);
            AddProperty("setupId", idSetup);
        }
    }

    internal class CmdCheckLastDateUpload : CmdBase
    {
        public CmdCheckLastDateUpload()
            : base("CheckLastDateUpload")
        {
        }
    }

    internal class CmdUpload : CmdBase
    {
        public CmdUpload(DateTime date, string data)
            : base("Upload")
        {
            AddProperty("date", date);
            AddProperty("data", data);
        }
    }

    internal class CmdCheckLastDateDownload : CmdBase
    {
        public CmdCheckLastDateDownload(DateTime date)
            : base("CheckLastDateDownload")
        {
            AddProperty("date", date);
        }
    }

    internal class CmdDownload : CmdBase
    {
        public CmdDownload(DateTime date)
            : base("Download")
        {
            AddProperty("date", date);
        }
    }

    internal class CmdLogOut : CmdBase
    {
        public CmdLogOut()
            : base("LogOut")
        {
        }
    }

    internal class CmdGetObjects : CmdBase
    {
        public CmdGetObjects(int idObject, int idAction, int count)
            : base("GetObjects")
        {
            AddProperty("idobject", idObject);
            AddProperty("idaction", idAction);
            AddProperty("count", count);
        }

        public List<ObjSale> ResultList
        {
            get { return Utils.Deserialize<ObjSale>("<doc>" + _res.TryGetPropertyValue("doc") + "</doc>"); }
        }
    }
}