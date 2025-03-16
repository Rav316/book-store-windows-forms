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
        private readonly UserRepository userRepository = new UserRepository(AppDbContext.INSTANCE);
        private readonly CartItemRepository cartItemRepository = new CartItemRepository(AppDbContext.INSTANCE);


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

        public bool IsInCartForCurrentUser(int bookId)
        {
            return bookRepository.IsInCartForUser(bookId, SecurityContext.Authentication.Id);
        }

        public async Task RemoveFromFavorites(int bookId)
        {
            await userRepository.DeleteBookFromFavorites(SecurityContext.Authentication.Id, bookId);
        }

        public async Task AddToFavorites(int bookId)
        {
            await userRepository.AddBookToFavorites(SecurityContext.Authentication.Id, bookId);
        }

        public async Task<List<Book>> FindAllFavoritesByUser()
        {
            var currentUser = await userRepository.FindByIdAsync(SecurityContext.Authentication.Id);
            return currentUser!.FavoriteBooks;
        }

        public bool IsInFavoritesForCurrentUser(int bookId)
        {
            return userRepository.IsBookInFavorites(SecurityContext.Authentication.Id, bookId);
        }

        public async Task AddToCart(int bookId, int? quantity)
        {
            await cartItemRepository.AddToCartAsync(SecurityContext.Authentication.Id, bookId, quantity);
        }

        public async Task RemoveFromCart(int bookId)
        {
            await cartItemRepository.RemoveFromCartAsync(SecurityContext.Authentication.Id, bookId);
        }
    }
}
