using Cassio.Produtos.Domain.Entities;
using Cassio.Produtos.Domain.Interfaces.Repositories;

namespace Cassio.Produtos.Infra.Data.Respositories
{
    public class ProductRepository : IProductRepository
    {
        public Task<List<Product>> ListProductsAsync()
        {
            return Task.FromResult(new List<Product>());
        }
    }
}
