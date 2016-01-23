using System.Collections.Generic;
using BLToolkit.Data;
using Realtor.Services.Abstract;

namespace Realtor.Services.DbServices
{
    class UsersService : IUsersService
    {
        readonly DbManager _db;

        public UsersService(DbManager db)
        {
            _db = db;
        }


        public Agent GetAgent(string login, string pass)
        {
            _db.SetCommand(
                "SELECT * FROM agents where Family = @login and Pass = PASSWORD(@pass)"
                , _db.Parameter("@login", login)                
                , _db.Parameter("@pass", pass)
            );

           return  _db.ExecuteObject<Agent>();
        }

        public List<Agent> GetAgents()
        {
            return _db.SetCommand("SELECT * FROM agents").ExecuteList<Agent>();
        }

        public bool AdminExists(int ownerId)
        {
            string sql = string.Concat("SELECT * FROM agents WHERE IDowner = ", ownerId, " AND Priv = 'A'");
            return (_db.SetCommand(sql).ExecuteList<Agent>().Count > 0);
        }

        public void CreateAgent(Agent agent)
        {
            string sql = string.Concat(
                    "INSERT INTO agents(IdOwner, Family, Priv, Stat, Self, Pass) VALUES("
                    , agent.IdOwner
                    , ","
                    , "'", agent.Family, "'"
                    , ","
                    , "'", agent.Priv, "'"
                    , ","
                    , "'", agent.Stat, "'"
                    , ","
                    , "'", agent.Self, "'"
                    , ","
                    , "PASSWORD('", agent.Pass, "')"
                    ,")"
                );

            _db.SetCommand(sql).ExecuteNonQuery();
        }
    }
}