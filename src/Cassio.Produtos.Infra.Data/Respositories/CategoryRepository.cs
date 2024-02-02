using Cassio.Produtos.Domain.Entities;
using Cassio.Produtos.Domain.Interfaces.Repositories;
using Cassio.Produtos.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Cassio.Produtos.Infra.Data.Respositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ProductsContext _context;

        public CategoryRepository(ProductsContext context)
        {
            _context = context;
        }

        public async Task AddCategoryAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
            _context.SaveChanges();
        }

        public async Task<Category> GetByIdAsync(string id)
        {
            return await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<Category>> ListAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}
