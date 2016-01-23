namespace Realtor.Services
{
    interface IWebClient
    {
        Response SendCommand(Query cmd);
    }

    class ResponseNotAvailable : Response
    {
        public ResponseNotAvailable()
            :base("NotAvailable")
        {
            AddProperty("comments", "Сервер не доступен");
        }
    }

    class ResponseBadResponse : Response
    {
        public ResponseBadResponse()
            : base("BadResponse")
        {
            AddProperty("comments", "Неверный ответ сервера");
        }
    }
}
