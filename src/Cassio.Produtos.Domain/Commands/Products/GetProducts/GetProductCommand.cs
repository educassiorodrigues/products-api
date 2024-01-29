using Cassio.Produtos.Domain.Entities;
using MediatR;

namespace Cassio.Produtos.Domain.Commands.Products.GetProducts
{
    public class GetProductCommand : IRequest<List<Product>>
    {
    }
}
