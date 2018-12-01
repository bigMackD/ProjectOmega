using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using ProjectOmega.DAL.Firebird;
using ProjectOmega.DAL.Firebird.Repositories.Interfaces;

namespace ProjectOmega.DAL.Firebird.Repositories
{
    public class ClientsRepository : BaseRepository<R3_CONTACTS>, IClientsRepository<R3_CONTACTS> 
    {
        public ClientsRepository(RaksConnectionString context)
            : base(context)
        {

        }

    }
}