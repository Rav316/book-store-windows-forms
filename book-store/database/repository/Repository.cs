using book_store.context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.database.repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext context;
        private readonly DbSet<T> dbSet;

        public Repository(AppDbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }   

        public async Task<List<T>> FindAllAsync() => await dbSet.ToListAsync();
        public async Task<T?> FindByIdAsync(int id) => await dbSet.FindAsync(id);
        public async Task CreateAsync(T entity) { await dbSet.AddAsync(entity); await context.SaveChangesAsync(); }
        public async Task UpdateAsync(T entity) { dbSet.Update(entity); await context.SaveChangesAsync(); }

        public async Task DeleteByIdAsync(int id)
        {
            var entity = await FindByIdAsync(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
                await context.SaveChangesAsync();
            }
        }
    }

}
