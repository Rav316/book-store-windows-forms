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
    internal class CartItemRepository: Repository<CartItem>
    {
        public CartItemRepository(AppDbContext context) : base(context) { }

        public async Task AddToCartAsync(int userId, int bookId, int? quantity)
        {
            var existingCartItem = await context.CartItems
                                .FirstOrDefaultAsync(c => c.UserId == userId && c.BookId == bookId);
            if(existingCartItem == null)
            {
                var newCartItem = new CartItem
                {
                    UserId = userId,
                    BookId = bookId,
                    Quantity = quantity ?? 1
                };
                context.CartItems.Add(newCartItem);
                await context.SaveChangesAsync();
            }
        }

        public async Task RemoveFromCartAsync(int userId, int bookId)
        {
            var cartItem = await context.CartItems
            .FirstOrDefaultAsync(c => c.UserId == userId && c.BookId == bookId);

            if (cartItem != null)
            {
                context.CartItems.Remove(cartItem);
                await context.SaveChangesAsync();
            }
        }

        public void UpdateQuantity(int userId, int bookId, int newQuantity)
        {
            var cartItem = context.CartItems.FirstOrDefault(ci => ci.UserId == userId && ci.BookId == bookId);
            if(cartItem != null)
            {
                cartItem.Quantity = newQuantity;
                context.SaveChanges();
            }
        }
    }
}
