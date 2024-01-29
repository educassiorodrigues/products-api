using Cassio.Produtos.Domain.Entities;

namespace Cassio.Produtos.Api.DependecyInjection
{
    public static class MediatorInjection
    {
        public static void AddMediator(this IServiceCollection services)
        {
            // Api Injection
            services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining<Startup>());

            // Domain Injection
            services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining<Product>());
        }
    }
}
