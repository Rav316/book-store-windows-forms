using book_store.context;
using book_store.database.entity;
using book_store.database.repository;
using book_store.dto.book;
using book_store.exception;
using book_store.mapper.book;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace book_store.service
{
    internal class BookService
    {
        private readonly ImageService imageService = new ImageService();
        private readonly BookRepository bookRepository = new BookRepository(AppDbContext.INSTANCE);
        private readonly UserRepository userRepository = new UserRepository(AppDbContext.INSTANCE);
        private readonly CartItemRepository cartItemRepository = new CartItemRepository(AppDbContext.INSTANCE);
        private readonly BookWarehouseRepository bookWarehouseRepository = new BookWarehouseRepository(AppDbContext.INSTANCE);
        private readonly BookOrderMapper bookOrderMapper = new BookOrderMapper();
        private readonly BookManagementMapper bookManagementMapper = new BookManagementMapper();

        public List<BookListDto> FindAllWithUserInfo()
        {
            return bookRepository.FindAllWithUserInfo(SecurityContext.Authentication.Id);
        }

        public List<BookListDto> FindAllFavoritesWithUserInfo()
        {
            return bookRepository.FindAllFavoritesWithUserInfo(SecurityContext.Authentication.Id);
        }

        public List<BookCartDto> FindAllInCartWithUserInfo()
        {
            return bookRepository.FindAllInCartWithUserInfo(SecurityContext.Authentication.Id);
        }

        public Task<Book?> FindById(int id)
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

        public void RemoveAllFavoritesForCurrentUser()
        {
            bookRepository.RemoveAllFavoritesForUser(SecurityContext.Authentication.Id);
        }

        public void UpdateQuantityInCartForCurrentUser(int bookId, int newQuantity)
        {
            cartItemRepository.UpdateQuantity(SecurityContext.Authentication.Id, bookId, newQuantity);
        }

        public bool IsBookAvailable(int bookId)
        {
            return bookWarehouseRepository.IsBookAvailable(bookId);
        }

        public List<BookOrderDto> FindAllByOrder(int orderId)
        {
            return bookRepository.FindAllByOrder(orderId);
        }

        public bool IsBookPurchased(int bookId)
        {
            return bookRepository.IsBookPurchased(SecurityContext.Authentication.Id, bookId);
        }

        public async Task<List<BookManagementDto>> FindAllForManagement()
        {
            var books = await bookRepository.FindAllAsync();
            return [.. books
                .Select(bookManagementMapper.ToDto)
                .OrderBy(b => b.Id)
            ];
        }

        public async Task Update(Book book)
        {
            if (book.ImagePath != null)
            {
                imageService.SaveImage(book.ImagePath, @"..\..\..\Resources\Books");
            }
            await bookRepository.UpdateAsync(book);
        }

        public Book? FindByTitleAndAuthor(string title, int author)
        {
            return bookRepository.FindByTitleAndAuthor(title, author);
        }

        public async Task Delete(int bookid)
        {
            await bookRepository.DeleteByIdAsync(bookid);
        }

        public async Task<List<Book>> FindAll()
        {
            return await bookRepository.FindAllAsync();
        }
    }
}
