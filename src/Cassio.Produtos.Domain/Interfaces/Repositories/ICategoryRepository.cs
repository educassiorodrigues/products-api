using Cassio.Produtos.Domain.Entities;

namespace Cassio.Produtos.Domain.Interfaces.Repositories
{
    public interface ICategoryRepository
    {
        Task AddCategoryAsync(Category category);
        Task<IEnumerable<Category>> ListAllNoTrackingAsync();
        Task<Category> GetByIdAsync(string id);
        Task DeleteCategoryAsync(string id, CancellationToken cancellationToken);

    }
}
