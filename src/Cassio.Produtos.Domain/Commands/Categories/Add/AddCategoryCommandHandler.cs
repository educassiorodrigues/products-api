using Cassio.Produtos.Domain.Entities;
using Cassio.Produtos.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            await _categoryRepository.AddCategoryAsync(new Category(request.Description));

            return Unit.Value;
        }
    }
}
