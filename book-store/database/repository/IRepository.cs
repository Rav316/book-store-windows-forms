using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.database.repository
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> FindAllAsync();
        Task<T?> FindByIdAsync(int id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }

}
