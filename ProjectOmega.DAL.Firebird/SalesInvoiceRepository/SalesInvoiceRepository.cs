using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOmega.DAL.Firebird.SalesInvoiceRepository
{
    public class SalesInvoiceRepository : ISalesInvoiceRepository
    {
        RaksConnectionString _raksConnectionString = new RaksConnectionString();

        public IEnumerable<GM_FS> GetAll()
        {
            return _raksConnectionString.GM_FS.ToList();
        }

        public GM_FS GetById(int id)
        {
            return _raksConnectionString.GM_FS.SingleOrDefault(fs => fs.ID == id);
        }
    }
}
