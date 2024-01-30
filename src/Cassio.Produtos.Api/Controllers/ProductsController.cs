using Cassio.Produtos.Domain.Commands.Products.GetProducts;
using Cassio.Produtos.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Cassio.Produtos.Api.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]       
        public async Task<IEnumerable<Product>> ListProductsAsync()
        {
            return await _mediator.Send(new GetProductCommand());
        }
    }
}
