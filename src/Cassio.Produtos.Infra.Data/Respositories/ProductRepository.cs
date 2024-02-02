using Cassio.Produtos.Domain.Entities;
using Cassio.Produtos.Domain.Interfaces.Repositories;
using Cassio.Produtos.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Cassio.Produtos.Infra.Data.Respositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductsContext _context;

        public ProductRepository()
        {
            _context = new ProductsContext();
        }

        public async Task AddProductAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            _context.SaveChanges();
        }

        public async Task<List<Product>> ListAllAsync()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
