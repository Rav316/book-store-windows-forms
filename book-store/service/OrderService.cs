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
        private readonly PaymentDetailRepository paymentDetailRepository = new PaymentDetailRepository(AppDbContext.INSTANCE);
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

        public async Task PayForTheOrder(PaymentDetail paymentDetail)
        {
            paymentDetail.ExpirationDate = paymentDetail.ExpirationDate.ToUniversalTime();
            await paymentDetailRepository.PayForTheOrder(paymentDetail);
        }

        public async Task<OrderProfileDto> FindById(int id)
        {
            var order = await orderRepository.FindByIdAsync(id);
            return orderProfileMapper.ToDto(order!);
        }

        public async Task CancelOrder(int orderId)
        {
            var order = await orderRepository.FindByIdAsync(orderId);
            order!.OrderStatusId = 3;
            order.PaidIn = order.PaidIn?.ToUniversalTime();
            await orderRepository.UpdateAsync(order);
        }
    }
}
