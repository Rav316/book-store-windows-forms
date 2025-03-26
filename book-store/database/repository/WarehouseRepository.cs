using book_store.context;
using book_store.database.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.database.repository
{
    public class WarehouseRepository: Repository<Warehouse>
    {
        public WarehouseRepository(AppDbContext context) : base(context) { }

        public Warehouse? FindByName(string name)
        {
            return context.Warehouses.FirstOrDefault(w => w.Name == name);
        }
    }
}
