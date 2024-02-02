using Cassio.Produtos.Domain.Builders;
using Cassio.Produtos.Domain.Interfaces.Builders;
using Cassio.Produtos.Domain.Interfaces.Repositories;
using Cassio.Produtos.Infra.Data.Respositories;

namespace Cassio.Produtos.Api.DependecyInjection
{
    public static class DependecyInjection
    {
        public static void AddDependecies(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IStockRepository, StockRepository>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();

            services.AddSingleton<IProductBuilder, ProductBuilder>();
        }
    }
}
