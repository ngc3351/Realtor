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
            AddProperty("comments", "������ �� ��������");
        }
    }

    class ResponseBadResponse : Response
    {
        public ResponseBadResponse()
            : base("BadResponse")
        {
            AddProperty("comments", "�������� ����� �������");
        }
    }
}
