using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOmega.DAL.Firebird.PurchaseInvoiceRepository
{
    public class PurchaseInvoiceReopsitory : IPurchaseInvoiceRepository
    {
        RaksConnectionString _raksConnection = new RaksConnectionString();

        public IEnumerable<GM_FZ> GetAll()
        {
            return _raksConnection.GM_FZ.ToList();
        }

        public GM_FZ GetById(int id)
        {
            return _raksConnection.GM_FZ.SingleOrDefault(fz => fz.ID == id);
        }
    }
}
