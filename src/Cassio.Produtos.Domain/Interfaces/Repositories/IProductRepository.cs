using Cassio.Produtos.Domain.Entities;

namespace Cassio.Produtos.Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> ListProductsAsync();
    }
}
