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
            return await context.Users.FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task<User?> FindByEmailAsync(string email)
        {
            return await context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task AddBookToFavorites(int userId, int bookId)
        {
            var favorite = await context.Favorites
                .FirstOrDefaultAsync(f => f.UserId == userId && f.BookId == bookId);

            if (favorite == null)
            {
                context.Favorites.Add(new Favorite { UserId = userId, BookId = bookId });
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteBookFromFavorites(int userId, int bookId)
        {
            var favorite = await context.Favorites
                .FirstOrDefaultAsync(f => f.UserId == userId && f.BookId == bookId);
            if(favorite != null)
            {
                context.Favorites.Remove(favorite);
                await context.SaveChangesAsync();
            }
        }

        public bool IsBookInFavorites(int userId, int bookId)
        {
            return context.Favorites
                .Any(f => f.UserId == userId && f.BookId == bookId);
        }
    }
}
