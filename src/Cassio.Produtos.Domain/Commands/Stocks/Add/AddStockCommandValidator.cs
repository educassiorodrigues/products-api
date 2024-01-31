using Cassio.Produtos.Domain.Commands.Base;
using FluentValidation;

namespace Cassio.Produtos.Domain.Commands.Stocks.Add
{
    public class AddStockCommandValidator : AbstractValidator<AddStockCommand>
    {
        public AddStockCommandValidator()
        {
            RuleFor(a => a.Description)
                .NotEmpty()
                .WithMessage("Description is required");

            RuleFor(a => a.Address)
                .NotNull()
                .WithMessage("Address is required");

            RuleFor(a => a.Address)
                .SetValidator(new AddressCommandValidator());
        }
    }
}
