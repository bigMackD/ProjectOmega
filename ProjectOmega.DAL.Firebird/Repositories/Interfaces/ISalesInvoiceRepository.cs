using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOmega.DAL.Firebird.Repositories.Interfaces
{
    interface ISalesInvoiceRepository<T> : IBaseRepository<T> where T : GM_FS
    {
        
    }
}
