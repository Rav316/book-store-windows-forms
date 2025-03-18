using book_store.context;
using book_store.database.repository;
using book_store.dto.bookReview;
using book_store.mapper.bookReview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.service
{
    internal class BookReviewService
    {
        private readonly BookReviewRepository bookReviewRepository = new BookReviewRepository(AppDbContext.INSTANCE);
        private readonly BookReviewListMapper bookReviewListMapper = new BookReviewListMapper();

        public List<BookReviewListDto> GetReviewsByBook(int bookId)
        {
            return bookReviewRepository.GetReviewsByBook(bookId)
                .Select(bookReviewListMapper.ToDto)
                .ToList();
        }
    }
}
