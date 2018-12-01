using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectOmega.DAL.Firebird;

namespace ProjectOmega.DAL.Firebird.ClientsRepository
{
    public class ClientsRepository : IClientsRepository
    {
        RaksConnectionString _raksConnection = new RaksConnectionString();

        public IEnumerable<R3_CONTACTS> GetAll()
        {
            return _raksConnection.R3_CONTACTS.ToList();
        }

        public R3_CONTACTS GetById(int id)
        {
            return _raksConnection.R3_CONTACTS.SingleOrDefault(c => c.ID == id);
        }
    }
}