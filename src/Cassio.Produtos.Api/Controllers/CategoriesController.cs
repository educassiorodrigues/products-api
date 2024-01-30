using Cassio.Produtos.Domain.Commands.Categories.Add;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cassio.Produtos.Api.Controllers
{
    [Route("categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task AddCategoryAsync( [FromBody] AddCategoryCommand command, CancellationToken cancellationToken)
        {
            await _mediator.Send(command, cancellationToken);
        }
    }
}
