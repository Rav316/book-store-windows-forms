using book_store.context;
using book_store.database.entity;
using book_store.dto.book;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.database.repository
{
    internal class BookRepository : Repository<Book>
    {
        public BookRepository(AppDbContext context) : base(context) { }

        public List<BookListDto> FindAllWithUserInfo(int userId)
        {
            const string query = """
                    SELECT b.id AS Id, b.title AS Title, b.category_id AS Category, b.image_path AS ImagePath,
                    b.cover_type_id AS CoverType, b.language_id AS Language, b.price AS Price,
                        CASE WHEN f.book_id IS NOT NULL THEN TRUE ELSE FALSE END AS IsFavorite,
                        CASE WHEN c.book_id IS NOT NULL THEN TRUE ELSE FALSE END AS IsInCart,
                        CONCAT(a.first_name, ' ', a.mid_name, ' ', a.last_name) AS AuthorFullName
                    FROM book b
                    LEFT JOIN favorites f ON b.id = f.book_id AND f.user_id = {0}
                    LEFT JOIN cart_item c ON b.id = c.book_id AND c.user_id = {0}
                    LEFT JOIN author a ON b.author_id = a.id
                    ORDER BY b.id
                    """;

            var result = context.Database
                .SqlQueryRaw<BookListDto>(query, userId)
                .ToList();

            return result;
        }

        public List<BookListDto> FindAllFavoritesWithUserInfo(int userId)
        {
            const string query = """
                    SELECT b.id AS Id, b.title AS Title, b.category_id AS Category, b.image_path AS ImagePath,
                    b.cover_type_id AS CoverType, b.language_id AS Language, b.price AS Price,
                        CASE WHEN f.book_id IS NOT NULL THEN TRUE ELSE FALSE END AS IsFavorite,
                        CASE WHEN c.book_id IS NOT NULL THEN TRUE ELSE FALSE END AS IsInCart,
                        CONCAT(a.first_name, ' ', a.mid_name, ' ', a.last_name) AS AuthorFullName
                    FROM book b
                    JOIN favorites f ON b.id = f.book_id AND f.user_id = {0}
                    LEFT JOIN cart_item c ON b.id = c.book_id AND c.user_id = {0}
                    LEFT JOIN author a ON b.author_id = a.id
                    ORDER BY b.id
                    """;

            var result = context.Database
                .SqlQueryRaw<BookListDto>(query, userId)
                .ToList();

            return result;
        }

        public (int, int) GetMinAndMaxPrice()
        {
            int? minPrice = context.Books.Min(b => b.Price);
            int? maxPrice = context.Books.Max(b => b.Price);

            return (minPrice ?? 0, maxPrice ?? 0);
        }

        public bool IsInCartForUser(int bookId, int userId)
        {
            return context.CartItems.Any(c => c.BookId == bookId && c.UserId == userId);
        }

        public async Task<List<Book>> GetFavoriteBooks(int userId)
        {
            return await context.Favorites
                .Where(f => f.UserId == userId)
                .Include(f => f.Book) 
                .ThenInclude(b => b.Author) 
                .Select(f => f.Book)
                .ToListAsync();

        }

        public void RemoveAllFavoritesForUser(int userId)
        {
            var favoritesToRemove = context.Favorites.Where(f => f.UserId == userId);

            if(favoritesToRemove.Any())
            {
                context.Favorites.RemoveRange(favoritesToRemove);
                context.SaveChanges();
            }
        }
    }
}
