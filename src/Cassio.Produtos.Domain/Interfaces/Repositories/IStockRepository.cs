using Cassio.Produtos.Domain.Entities;

namespace Cassio.Produtos.Domain.Interfaces.Repositories
{
    public interface IStockRepository
    {
        Task AddStockAsync(Stock stock);

        Task<IEnumerable<Stock>> ListAllAsync();
    }
}
