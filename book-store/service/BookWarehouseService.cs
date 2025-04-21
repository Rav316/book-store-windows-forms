using book_store.context;
using book_store.database.entity;
using book_store.database.repository;
using book_store.dto.bookWarehouse;
using book_store.mapper.bookWarehouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.service
{
    public class BookWarehouseService
    {
        private readonly BookWarehouseRepository bookWarehouseRepository = new BookWarehouseRepository(AppDbContext.INSTANCE);
        private readonly BookWarehouseManagementMapper bookWarehouseManagementMapper = new BookWarehouseManagementMapper();
        public async Task<List<BookWarehouseManagementDto>> FindAll()
        {
            List<BookWarehouse> bookWarehouses = await bookWarehouseRepository.FindAllAsync();
            return bookWarehouses
                .Select(bookWarehouseManagementMapper.ToDto)
                .ToList();
        }

        public async Task<BookWarehouse?> FindByBookAndWarehouse(int bookId, int warehouseId)
        {
            return await bookWarehouseRepository.FindByBookAndWarehouse(bookId, warehouseId);
        }

        public async Task Create(BookWarehouse bookWarehouse)
        {
            await bookWarehouseRepository.CreateAsync(bookWarehouse);
        }

        public async Task Update(BookWarehouse bookWarehouse)
        {
            await bookWarehouseRepository.UpdateAsync(bookWarehouse);
        }

        public async Task Delete(int bookId, int warehouseId)
        {
            await bookWarehouseRepository.DeleteByBookAndWarehouse(bookId, warehouseId);
        }
    }
}
