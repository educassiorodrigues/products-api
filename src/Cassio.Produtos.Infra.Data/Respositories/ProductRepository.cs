﻿using Cassio.Produtos.Domain.Entities;
using Cassio.Produtos.Domain.Interfaces.Repositories;
using Cassio.Produtos.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Cassio.Produtos.Infra.Data.Respositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductsContext _context;

        public ProductRepository()
        {
            _context = new ProductsContext();
        }

        public async Task<List<Product>> ListProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
