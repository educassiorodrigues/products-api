﻿using Cassio.Produtos.Domain.Entities;

namespace Cassio.Produtos.Domain.Interfaces.Repositories
{
    public interface ICategoryRepository
    {
        Task AddCategoryAsync(Category category);
        Task<IEnumerable<Category>> ListAllAsync();
        Task<Category> GetByIdAsync(string id);
    }
}
