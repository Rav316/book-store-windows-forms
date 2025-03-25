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

        public async Task Create(Category category)
        {
            await categoryRepository.CreateAsync(category);
        }

        public Category? FindByName(string name)
        {
            return categoryRepository.FindByName(name);
        }

        public async Task Delete(int id)
        {
            await categoryRepository.DeleteByIdAsync(id);
        }

        public async Task<Category?> FindById(int id)
        {
            return await categoryRepository.FindByIdAsync(id);
        }

        public async Task Update(Category category)
        {
            await categoryRepository.UpdateAsync(category);
        }
    }
}
