using ProjectOmega.DAL.Firebird;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOmega.Repositories.ClientsRepository
{
    public class ClientsRepository : ProjectOmega.DAL.Firebird.Repositories.ClientsRepository
    {
        public ClientsRepository(RaksConnectionString raksConnection) :
            base(raksConnection)
        {

        }
    }
}
