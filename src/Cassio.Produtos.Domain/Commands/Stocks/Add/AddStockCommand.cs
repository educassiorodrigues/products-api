using Cassio.Produtos.Domain.Commands.Base;
using MediatR;

namespace Cassio.Produtos.Domain.Commands.Stocks.Add
{
    public class AddStockCommand : IRequest<Unit>
    {
        public string Description { get; set; }
        public AddressCommand Address { get; set; }
    }
}
