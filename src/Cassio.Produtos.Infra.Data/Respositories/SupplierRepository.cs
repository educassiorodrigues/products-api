using Cassio.Produtos.Domain.Entities;
using Cassio.Produtos.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Cassio.Produtos.Infra.Data.Respositories
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly ProductsContext _context;

        public SupplierRepository()
        {
            _context = new ProductsContext();
        }

        public async Task AddSupplierAsync(Supplier supplier)
        {
                await _context.Suppliers.AddAsync(supplier);
                _context.SaveChanges(); 
        }

        public async Task<Category> GetByIdAsync(string id)
        {
            return await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<Supplier>> ListAllAsync()
        {
            return await _context.Suppliers.ToListAsync();
        }

        async Task<Supplier> ISupplierRepository.GetByIdAsync(string id)
        {
            return await _context.Suppliers.FirstOrDefaultAsync(s => s.Id == id);
        }
    }
}
