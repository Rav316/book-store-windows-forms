using book_store.context;
using book_store.database.entity;
using book_store.database.repository;
using book_store.dto.book;
using book_store.exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.service
{
    internal class BookService
    {
        private readonly BookRepository bookRepository = new BookRepository(AppDbContext.INSTANCE);
        private readonly FavoritesRepository favoritesRepository = new FavoritesRepository(AppDbContext.INSTANCE);


        public Task<List<BookListDto>> FindAllWithUserInfo()
        {
            return bookRepository.FindAllWithUserInfo(SecurityContext.Authentication.Id);
        }

        public Task<Book> FindById(int id)
        {
            return bookRepository.FindByIdAsync(id) ?? throw new EntityNotFoundException($"книга с id {id} не найдена");
        }

        public (int, int) GetMinAndMaxPrice()
        {
            return bookRepository.GetMinAndMaxPrice();
        }

        public bool IsInFavoritesForCurrentUser(int bookId)
        {
            return bookRepository.IsInFavoritesForUser(bookId, SecurityContext.Authentication.Id);
        }

        public bool IsInCartForCurrentUser(int bookId)
        {
            return bookRepository.IsInCartForUser(bookId, SecurityContext.Authentication.Id);
        }

        public void RemoveFromFavorites(int bookId)
        {
            favoritesRepository.DeleteByBookAndUser(bookId, SecurityContext.Authentication.Id);
        }

        public async void AddToFavorites(Favorites favorites)
        {
            favorites.UserId = SecurityContext.Authentication.Id;
            await favoritesRepository.CreateAsync(favorites);
        }
    }
}
