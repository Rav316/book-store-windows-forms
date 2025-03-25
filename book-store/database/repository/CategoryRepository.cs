using book_store.context;
using book_store.database.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.database.repository
{
    internal class CategoryRepository: Repository<Category>
    {
        public CategoryRepository(AppDbContext context) : base(context) { }

        public Category? FindByName(string name)
        {
            return context.Categories.FirstOrDefault(c => c.Name == name);
        }
    }
}
