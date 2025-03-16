using book_store.context;
using book_store.database.entity;
using book_store.database.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.service
{
    internal class CategoryService
    {
        private readonly CategoryRepository categoryRepository = new CategoryRepository(AppDbContext.INSTANCE);
        public Task<List<Category>> FindAll()
        {
            return categoryRepository.FindAllAsync();
        }
    }
}
