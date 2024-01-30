using Cassio.Produtos.Domain.Entities;
using Cassio.Produtos.Domain.Interfaces.Repositories;
using Cassio.Produtos.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Cassio.Produtos.Infra.Data.Respositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ProductsContext _context;

        public CategoryRepository()
        {
            _context = new ProductsContext();
        }

        public async Task AddCategoryAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Category>> ListAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}
