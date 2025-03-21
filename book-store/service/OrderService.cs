using book_store.context;
using book_store.database.entity;
using book_store.database.repository;
using book_store.dto.order;
using book_store.mapper.order;
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
        private readonly OrderProfileMapper orderProfileMapper = new OrderProfileMapper();

        public async Task<Order> CreateOrderFromCartAsync(int totalCost, List<int> bookIds)
        {
            return await orderRepository.CreateOrderFromCartAsync(SecurityContext.Authentication.Id, totalCost, bookIds);
        }

        public List<OrderProfileDto> FindAllForCurrentUser()
        {
            return orderRepository.FindAllByUser(SecurityContext.Authentication.Id)
                .Select(orderProfileMapper.ToDto)
                .ToList();
        }
    }
}
