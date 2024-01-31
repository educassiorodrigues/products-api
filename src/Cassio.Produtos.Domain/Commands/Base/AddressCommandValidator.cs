using FluentValidation;

namespace Cassio.Produtos.Domain.Commands.Base
{
    public class AddressCommandValidator : AbstractValidator<AddressCommand>
    {
        public AddressCommandValidator()
        {
            RuleFor(a => a.City)
                .NotEmpty()
                .WithMessage("City is required");

            RuleFor(a => a.State)
                .NotEmpty()
                .WithMessage("State is required");

            RuleFor(a => a.Country)
                .NotEmpty()
                .WithMessage("Country is required");

            RuleFor(a => a.Neighborhood)
                .NotEmpty()
                .WithMessage("Neighborhood is required");

            RuleFor(a => a.Number)
                .NotEmpty()
                .WithMessage("Number is required");
        }
    }
}
