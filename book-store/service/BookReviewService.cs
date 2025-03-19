using book_store.context;
using book_store.database.entity;
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
        private readonly BookReviewProfileMapper bookReviewProfileMapper = new BookReviewProfileMapper();

        public List<BookReviewListDto> GetReviewsByBook(int bookId)
        {
            return bookReviewRepository.GetReviewsByBook(bookId)
                .Select(bookReviewListMapper.ToDto)
                .ToList();
        }

        public List<BookReviewProfileDto> GetReviewsForCurrentUser()
        {
            return bookReviewRepository.GetReviewsByUser(SecurityContext.Authentication.Id)
                .Select(bookReviewProfileMapper.ToDto)
                .ToList();
        }

        public BookReview? FindByBookAndUser(int bookId)
        {
            return bookReviewRepository.FindByBookAndUser(bookId, SecurityContext.Authentication.Id);
        }

        public async Task<BookReview?> FindById(int id)
        {
            return await bookReviewRepository.FindByIdAsync(id);
        }

        public async Task Create(BookReview bookReview)
        {
            await bookReviewRepository.CreateAsync(bookReview);
        }

        public async Task Update(BookReview bookReview)
        {
            await bookReviewRepository.UpdateAsync(bookReview);
        }

        public async Task Delete(int id)
        {
            await bookReviewRepository.DeleteByIdAsync(id);
        }
    }
}
