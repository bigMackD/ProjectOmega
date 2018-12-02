using ProjectOmega.DAL.Firebird;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOmega.DAL.Firebird.Repositories.Interfaces
{
    interface IClientsRepository<T> : IBaseRepository<T> where T : R3_CONTACTS
    {
        
    }
}
