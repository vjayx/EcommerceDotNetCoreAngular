using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Data.Entities;
using Core.Interfaces;
using InfraStructure.Data;
using Microsoft.EntityFrameworkCore;

namespace InfraStructure
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _context;
        public ProductRepository(StoreContext context)
        {
            _context = context;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
           return await _context.Products.FindAsync(id); 
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }
    }
}