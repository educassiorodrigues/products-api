using Cassio.Produtos.Domain.Entities;
using Cassio.Produtos.Domain.Interfaces.Repositories;
using Cassio.Produtos.Domain.ValueObjects;
using MediatR;

namespace Cassio.Produtos.Domain.Commands.Stocks.Add
{
    public class AddStockCommandHandler : IRequestHandler<AddStockCommand, Unit>
    {

        private readonly IStockRepository _stockRepository;

        public AddStockCommandHandler(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }

        public async Task<Unit> Handle(AddStockCommand request, CancellationToken cancellationToken)
        {
            var address = new Address(request.Address.City,
                                      request.Address.State,
                                      request.Address.Neighborhood,
                                      request.Address.Number,
                                      request.Address.Country,
                                      request.Address.Complement);

            await _stockRepository.AddStockAsync(new Stock(request.Description, address));

            return Unit.Value;
        }
    }
}
