using Cassio.Produtos.Domain.Entities;
using Cassio.Produtos.Domain.ValueObjects;
using Cassio.Produtos.Infra.Data.Respositories;
using MediatR;

namespace Cassio.Produtos.Domain.Commands.Suppliers.Add
{
    public class AddSupplierCommandHandler : IRequestHandler<AddSupplierCommand, Unit>
    {
        private readonly ISupplierRepository _supplierRepository;

        public AddSupplierCommandHandler(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public async Task<Unit> Handle(AddSupplierCommand request, CancellationToken cancellationToken)
        {
            var address = new Address(request.Address.City,
                                      request.Address.State,
                                      request.Address.Neighborhood,
                                      request.Address.Number,
                                      request.Address.Country,
                                      request.Address.Complement);

            var supplier = new Supplier(request.Name,
                                        address,
                                        new Identification(request.IdentificationNumber));

            await _supplierRepository.AddSupplierAsync(supplier);

            return Unit.Value;
        }
    }
}
