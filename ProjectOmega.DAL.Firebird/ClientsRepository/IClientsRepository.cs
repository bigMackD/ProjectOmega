using ProjectOmega.DAL.Firebird;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOmega.DAL.Firebird.ClientsRepository
{
    interface IClientsRepository
    {
        IEnumerable<R3_CONTACTS> GetAll();
        R3_CONTACTS GetById(int id);
    }
}
