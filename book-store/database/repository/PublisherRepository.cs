using book_store.context;
using book_store.database.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.database.repository
{
    public class PublisherRepository: Repository<Publisher>
    {
        public PublisherRepository(AppDbContext context) : base(context) { }

        public Publisher? FindByName(string name)
        {
            return context.Publishers.FirstOrDefault(p => p.Name == name);
        }
    }
}
