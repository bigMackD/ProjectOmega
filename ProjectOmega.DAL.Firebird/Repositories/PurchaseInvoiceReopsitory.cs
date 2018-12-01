using ProjectOmega.DAL.Firebird.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOmega.DAL.Firebird.Repositories
{
    public class PurchaseInvoiceReopsitory : BaseRepository<GM_FZ>, IPurchaseInvoiceRepository<GM_FZ>
    {
        public PurchaseInvoiceReopsitory(RaksConnectionString context)
            : base(context)
        {

        }
    }
}
