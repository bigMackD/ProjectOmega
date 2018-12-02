using ProjectOmega.DAL.Firebird;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOmega.DAL.Firebird.Repositories.Interfaces
{
    interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
