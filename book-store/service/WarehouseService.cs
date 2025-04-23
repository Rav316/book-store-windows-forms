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
    public class WarehouseService
    {
        private readonly WarehouseRepository warehouseRepository = new WarehouseRepository(AppDbContext.INSTANCE);

        public async Task<List<Warehouse>> FindAll()
        {
            List<Warehouse> warehouses = await warehouseRepository.FindAllAsync();
            return warehouses
                .OrderBy(w => w.Name)
                .ToList();
        }

        public async Task<Warehouse?> FindById(int id)
        {
            return await warehouseRepository.FindByIdAsync(id);
        }

        public async Task Create(Warehouse warehouse)
        {
            await warehouseRepository.CreateAsync(warehouse);
        }

        public async Task Update(Warehouse warehouse)
        {
            await warehouseRepository.UpdateAsync(warehouse);
        }

        public async Task Delete(int id)
        {
            await warehouseRepository.DeleteByIdAsync(id);
        }

        public Warehouse? FindByName(string name)
        {
            return warehouseRepository.FindByName(name);
        }
    }
}
