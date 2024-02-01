using Cassio.Produtos.Domain.Commands.Suppliers.Add;
using Cassio.Produtos.Domain.Entities;
using Cassio.Produtos.Infra.Data.Respositories;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Cassio.Produtos.Api.Controllers
{
    [Route("suppliers")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ISupplierRepository _supplierRepository;

        public SuppliersController(IMediator mediator, ISupplierRepository supplierRepository)
        {
            _mediator = mediator;
            _supplierRepository = supplierRepository;
        }

        [HttpPost]
        public async Task AddSupplierAsync([FromBody] AddSupplierCommand command)
        {
            await _mediator.Send(command);
        }

        [HttpGet]
        public async Task<IEnumerable<Supplier>> ListSuppliersAsync()
        {
            return await _supplierRepository.ListAllAsync();
        }
    }
}
