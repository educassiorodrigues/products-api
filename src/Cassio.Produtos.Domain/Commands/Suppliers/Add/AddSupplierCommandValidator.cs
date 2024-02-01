using Cassio.Produtos.Domain.Commands.Base;
using FluentValidation;

namespace Cassio.Produtos.Domain.Commands.Suppliers.Add
{
    public class AddSupplierCommandValidator: AbstractValidator<AddSupplierCommand>
    {
        public AddSupplierCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Name is required");

            RuleFor(x => x.IdentificationNumber)
                .NotEmpty()
                .WithMessage("Identification number is required");

            RuleFor(x => x.Address)
                .NotNull()
                .WithMessage("Address is required");

            RuleFor(x => x.Address)
                .SetValidator(new AddressCommandValidator());
        }
    }
}
