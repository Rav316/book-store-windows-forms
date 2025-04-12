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
    internal class BookReviewRepository: Repository<BookReview>
    {
        public BookReviewRepository(AppDbContext context) : base(context) { }

        public List<BookReview> GetReviewsByBook(int bookId)
        {
            return context.BookReviews
                .AsNoTracking()
                .Where(br => br.BookId == bookId)
                .Include(br => br.User)
                .ToList();
        }

        public List<BookReview> GetReviewsByUser(int userId)
        {
            return context.BookReviews
                .Where(br => br.UserId == userId)
                .Include(br => br.Book)
                .ThenInclude(b => b.Author)
                .ToList();
        }

        public BookReview? FindByBookAndUser(int bookId, int userId)
        {
            return context.BookReviews
                .AsNoTracking()
                .FirstOrDefault(br => br.BookId == bookId && br.UserId == userId);
        }
    }
}
