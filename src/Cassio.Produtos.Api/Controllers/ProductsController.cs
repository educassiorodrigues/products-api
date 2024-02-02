using Cassio.Produtos.Domain.Commands.Products.Add;
using Cassio.Produtos.Domain.Entities;
using Cassio.Produtos.Domain.Interfaces.Repositories;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Cassio.Produtos.Api.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IProductRepository _productRepository;

        public ProductsController(IMediator mediator, IProductRepository productRepository)
        {
            _mediator = mediator;
            _productRepository = productRepository;
        }

        [HttpGet]       
        public async Task<IEnumerable<Product>> ListProductsAsync()
        {
            return await _productRepository.ListAllAsync();
        }

        [HttpPost]
        public async Task AddProductAsync([FromBody] AddProductCommand command)
        {
            await _mediator.Send(command);
        }
    }
}
