using Cassio.Produtos.Domain.Commands.Categories.Add;
using Cassio.Produtos.Domain.Entities;
using Cassio.Produtos.Domain.Interfaces.Repositories;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Cassio.Produtos.Api.Controllers
{
    [Route("categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(IMediator mediator, ICategoryRepository categoryRepository)
        {
            _mediator = mediator;
            _categoryRepository = categoryRepository;
        }

        [HttpPost]
        public async Task AddCategoryAsync( [FromBody] AddCategoryCommand command, CancellationToken cancellationToken)
        {
            await _mediator.Send(command, cancellationToken);
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> ListCategoriesAsync()
        {
            return await _categoryRepository.ListAllNoTrackingAsync();
        }

        [HttpDelete("{id}")]
        public async Task DeleteCategoryAsync(string id, CancellationToken cancellationToken)
        {
             await _categoryRepository.DeleteCategoryAsync(id,  cancellationToken);
        }
    }
}
