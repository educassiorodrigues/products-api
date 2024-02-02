using Cassio.Produtos.Domain.Entities;
using Cassio.Produtos.Domain.Interfaces.Repositories;
using Cassio.Produtos.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Cassio.Produtos.Infra.Data.Respositories
{
    public class StockRepository : IStockRepository
    {
        private readonly ProductsContext _context;

        public StockRepository()
        {
            _context = new ProductsContext();
        }

        public async Task AddStockAsync(Stock stock)
        {
            await _context.Stocks.AddAsync(stock);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Stock>> ListAllAsync()
        {
           return await _context.Stocks.ToListAsync();
        }

        public async Task<Stock> GetByIdAsync(string id)
        {
            return await _context.Stocks.FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
