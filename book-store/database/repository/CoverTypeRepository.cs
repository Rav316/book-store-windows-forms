using book_store.context;
using book_store.database.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.database.repository
{
    internal class CoverTypeRepository : Repository<CoverType>
    {
        public CoverTypeRepository(AppDbContext context) : base(context) { }
    }
}
