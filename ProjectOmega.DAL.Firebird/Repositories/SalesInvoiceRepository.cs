using ProjectOmega.DAL.Firebird.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOmega.DAL.Firebird.Repositories
{
    public class SalesInvoiceRepository : BaseRepository<GM_FS>, ISalesInvoiceRepository<GM_FS>
    {
        public SalesInvoiceRepository(RaksConnectionString context)
            : base(context)
        {

        }
    }
}
