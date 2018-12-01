using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOmega.DAL.Firebird.PurchaseInvoiceRepository
{
    interface IPurchaseInvoiceRepository
    {
        IEnumerable<GM_FZ> GetAll();
        GM_FZ GetById(int id);
    }
}
