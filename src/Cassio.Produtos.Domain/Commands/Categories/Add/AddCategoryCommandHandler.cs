using Cassio.Produtos.Domain.Entities;
using Cassio.Produtos.Domain.Interfaces.Repositories;
using MediatR;

namespace Cassio.Produtos.Domain.Commands.Categories.Add
{
    public class AddCategoryCommandHandler : IRequestHandler<AddCategoryCommand, Unit>
    {
        private readonly ICategoryRepository _categoryRepository;

        public AddCategoryCommandHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Unit> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(request.Description))
                throw new Exception("Description is required.");

            await _categoryRepository.AddCategoryAsync(new Category(request.Description));

            return Unit.Value;
        }
    }
}
