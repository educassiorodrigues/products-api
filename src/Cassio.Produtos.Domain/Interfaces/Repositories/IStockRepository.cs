using Cassio.Produtos.Domain.Entities;

namespace Cassio.Produtos.Domain.Interfaces.Repositories
{
    public interface IStockRepository
    {
        Task AddStockAsync(Stock stock);
        Task<Stock> GetByIdAsync(string id);
        Task<IEnumerable<Stock>> ListAllAsync();
    }
}
