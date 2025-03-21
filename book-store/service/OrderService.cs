using book_store.context;
using book_store.database.entity;
using book_store.database.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.service
{
    internal class OrderService
    {
        private readonly OrderRepository orderRepository = new OrderRepository(AppDbContext.INSTANCE);

        public async Task<Order> CreateOrderFromCartAsync(List<int> bookIds)
        {
            return await orderRepository.CreateOrderFromCartAsync(SecurityContext.Authentication.Id, bookIds);
        }
    }
}
