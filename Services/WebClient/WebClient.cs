using System.ComponentModel;
using System.Net;
using System.Xml;
using Realtor.Http;

namespace Realtor.Services
{
    internal class WebClient : Component, IWebClient
    {
        private static readonly object _onResponseEventKey = new object();
        private string _baseUrl;
        private CustomWebRequest _webRequest;

        public WebClient(string baseUrl)
        {
            _baseUrl = baseUrl;
        }


        public string BaseUrl
        {
            get { return _baseUrl; }
            set { _baseUrl = value; }
        }

        public CustomWebRequest WebRequest
        {
            get
            {
                if (_webRequest == null)
                    _webRequest = new CustomWebRequest(BaseUrl);
                return _webRequest;
            }
            set { _webRequest = value; }
        }

        #region Delegates

        public delegate void OnResponseDelegate(string str);

        #endregion

        #region IWebClient Members

        public Response SendCommand(Query cmd)
        {
            string args = string.Empty;
            foreach (QueryArgument arg in cmd.Properties)
                args += string.Format("<{0}>{1}</{0}>", arg.Name, arg.Value);

            string query = string.Format("<query><id>{0}</id>{1}</query>", cmd.Id, args);

            WebRequest.ParamsCollection.Add(new ParamsStruct("query", query));

            try
            {
                WebRequest.PostData();
            }
            catch (WebException e)
            {
                return new ResponseNotAvailable();
            }

            string res = WebRequest.ResponseString;

            RaiseOnResponse(res);

            return parseResponse(res);
        }

        #endregion

        private static Response parseResponse(string str)
        {
            XmlDocument doc = new XmlDocument();

            try
            {
                doc.LoadXml(str);
            }
            catch
            {
                return new ResponseBadResponse();
            }

            string id = doc.SelectSingleNode("response/id").InnerText;

            Response resp = new Response(id);

            foreach (XmlNode node in doc.SelectNodes("response/*"))
                resp.AddProperty(node.Name, node.InnerXml);

            resp.OkStatus = (resp.TryGetPropertyValue("status") == "ok");

            return resp;
        }


        public event OnResponseDelegate OnResponse
        {
            add { Events.AddHandler(_onResponseEventKey, value); }

            remove { Events.RemoveHandler(_onResponseEventKey, value); }
        }

        private void RaiseOnResponse(string str)
        {
            if (Events[_onResponseEventKey] != null)
                Events[_onResponseEventKey].DynamicInvoke(new object[] {str});
        }
    }
}