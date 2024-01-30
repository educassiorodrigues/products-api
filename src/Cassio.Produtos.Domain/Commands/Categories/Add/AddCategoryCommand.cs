using MediatR;

namespace Cassio.Produtos.Domain.Commands.Categories.Add
{
    public class AddCategoryCommand : IRequest<Unit>
    {
        public string Description { get; set; }
    }
}
