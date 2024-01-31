using Cassio.Produtos.Domain.Commands.Stocks.Add;
using Cassio.Produtos.Domain.Entities;
using Cassio.Produtos.Domain.Interfaces.Repositories;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Cassio.Produtos.Api.Controllers
{
    [Route("stocks")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IStockRepository _stockRepository;

        public StocksController(IMediator mediator, IStockRepository stockRepository)
        {
            _mediator = mediator;
            _stockRepository = stockRepository;
        }

        [HttpPost]
        public async Task AddStockAsync([FromBody] AddStockCommand command)
        {
            await _mediator.Send(command);
        }

        [HttpGet]
        public async Task<IEnumerable<Stock>> ListStocksAsync()
        {
            return await _stockRepository.ListAllAsync();
        }
    }
}
