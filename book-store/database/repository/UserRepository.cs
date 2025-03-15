using book_store.context;
using book_store.database.entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.database.repository
{
    internal class UserRepository : Repository<User>
    {
        public UserRepository(AppDbContext context) : base(context) { }

        public async Task<User?> FindByUsernameAsync(string username)
        {
            return await _context.user.FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task<User?> FindByEmailAsync(string email)
        {
            return await _context.user.FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}
