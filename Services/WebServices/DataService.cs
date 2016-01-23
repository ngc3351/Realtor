using System.Collections.Generic;
using BLToolkit.Data;

namespace Realtor.Services.WebServices
{
    class DataService //: Services.Abstract.IDataService
    {
        protected readonly DbManager _db;
        protected readonly string _baseUrl = "http://www.realty.loc/webservice";
        protected IWebClient _webClient;

        public DataService(DbManager db)
        {
            _db = db;
        }

        public IWebClient WebClient
        {
            get
            {
                if (_webClient == null)
                    _webClient = new Realtor.Services.WebClient(_baseUrl);
                return _webClient;
            }
            set
            {
                _webClient = value;
            }
        }


        public List<ObjSale> GetSalesObjects(int typeCriteria, int actionCriteria, int cnt)
        {
            Query res = WebClient.SendCommand(new CmdGetObjects(typeCriteria, actionCriteria, cnt));
            return res.TryGetPropertyValue("status") == "ok" ? Utils.Deserialize<ObjSale>("<doc>" + res.TryGetPropertyValue("doc") + "</doc>") : new List<ObjSale>();
        }
    }
}
