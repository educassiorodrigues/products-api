using Cassio.Produtos.Domain.Entities;

namespace Cassio.Produtos.Infra.Data.Respositories
{
    public interface ISupplierRepository
    {
        Task AddSupplierAsync(Supplier supplier);
        Task<IEnumerable<Supplier>> ListAllAsync();
    }
}