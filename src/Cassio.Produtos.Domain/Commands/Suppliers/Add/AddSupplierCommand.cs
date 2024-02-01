using Cassio.Produtos.Domain.Commands.Base;
using MediatR;

namespace Cassio.Produtos.Domain.Commands.Suppliers.Add
{
    public class AddSupplierCommand : IRequest<Unit>
    {
        public string Name { get; set; }
        public string IdentificationNumber { get; set; }
        public AddressCommand Address { get; set; }

    }
}
