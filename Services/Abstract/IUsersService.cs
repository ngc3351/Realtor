using System;
using System.Collections.Generic;
using System.Text;

namespace Realtor.Services.Abstract
{
    interface IUsersService
    {
        List<Agent> GetAgents();

        Agent GetAgent(string login, string pass);

        void CreateAgent(Agent agent);

        bool AdminExists(int ownerId);
    }
}
