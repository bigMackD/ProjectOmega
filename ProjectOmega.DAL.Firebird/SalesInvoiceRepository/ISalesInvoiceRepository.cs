using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOmega.DAL.Firebird.SalesInvoiceRepository
{
    interface ISalesInvoiceRepository
    {
        IEnumerable<GM_FS> GetAll();
        GM_FS GetById(int id);
    }
}
