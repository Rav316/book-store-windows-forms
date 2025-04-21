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
    public class OrderService
    {
        private readonly string secret = "book store secret"; 
        private readonly AesEncryptionService aesEncryptionService;
        private readonly OrderRepository orderRepository = new OrderRepository(AppDbContext.INSTANCE);
        private readonly PaymentDetailRepository paymentDetailRepository = new PaymentDetailRepository(AppDbContext.INSTANCE);
        private readonly OrderProfileMapper orderProfileMapper = new OrderProfileMapper();

        public OrderService()
        {
            aesEncryptionService = new AesEncryptionService(secret);
        }

        public async Task<Order> CreateOrderFromCartAsync(int totalCost, List<int> bookIds)
        {
            return await orderRepository.CreateOrderFromCartAsync(SecurityContext.Authentication.Id, totalCost, bookIds);
        }

        public List<OrderProfileDto> FindAllForCurrentUser()
        {
            return orderRepository.FindAllByUser(SecurityContext.Authentication.Id)
                .Select(orderProfileMapper.ToDto)
                .OrderBy(o => o.Id)
                .ToList();
        }

        public async Task PayForTheOrder(int orderId, string cardNumber, DateTime expirationDate, short code)
        {
            expirationDate = expirationDate.ToUniversalTime();
            cardNumber = aesEncryptionService.Encrypt(cardNumber);
            string encryptedExpirationDate = aesEncryptionService.Encrypt(expirationDate.ToString());
            string encryptedCode = aesEncryptionService.Encrypt(code.ToString());
            PaymentDetail paymentDetail = new PaymentDetail
            {
                OrderId = orderId,
                CardNumber = cardNumber,
                ExpirationDate = encryptedExpirationDate,
                Code = encryptedCode
            };
            await paymentDetailRepository.PayForTheOrder(paymentDetail);
        }

        public async Task<OrderProfileDto> FindById(int id)
        {
            var order = await orderRepository.FindByIdAsync(id);
            return orderProfileMapper.ToDto(order!);
        }

        public async Task CancelOrder(int orderId)
        {
            await orderRepository.CancelOrderAsync(orderId);
        }

        public async Task FinishOrder(int orderId)
        {
            await orderRepository.FinishOrderAsync(orderId);
        }
    }
}
