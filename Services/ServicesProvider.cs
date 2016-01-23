using BLToolkit.Data;
using Realtor.Services.Abstract;
using Realtor.Services.DbServices;

namespace Realtor
{
    internal class ServicesProvider
    {
        private static IDataService _data;
        private static DbManager _db;
        private static IUsersService _users;

        public static DbManager Connection
        {
            get
            {
                if (_db == null)
                    _db = new DbManager();

                return _db;
            }
        }


        public static IUsersService Users
        {
            get
            {
                if (_users == null)
                    _users = new UsersService(Connection);

                return _users;
            }
        }

        public static IDataService Data
        {
            get
            {
                if (_data == null)
                    _data = new DataService(Connection);

                return _data;
            }
        }
    }

    public enum ServicesLocation
    {
        LocalDb,
        LocalServer,
        WebServer
    }
}