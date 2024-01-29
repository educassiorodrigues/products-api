using Cassio.Produtos.Domain.Entities;
using Cassio.Produtos.Domain.Interfaces.Repositories;
using MediatR;

namespace Cassio.Produtos.Domain.Commands.Products.GetProducts
{
    public class GetProductCommandHandler : IRequestHandler<GetProductCommand, List<Product>>
    {
        private readonly IProductRepository _productRepository;

        public GetProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<List<Product>> Handle(GetProductCommand request, CancellationToken cancellationToken)
        {

            return _productRepository.ListProductsAsync();
        }
    }
}
