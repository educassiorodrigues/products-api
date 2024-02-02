using Cassio.Produtos.Domain.Entities;
using Cassio.Produtos.Domain.Interfaces.Builders;
using Cassio.Produtos.Domain.Interfaces.Repositories;
using Cassio.Produtos.Infra.Data.Respositories;
using MediatR;

namespace Cassio.Produtos.Domain.Commands.Products.Add
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, Unit>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IStockRepository _stockRepository;
        private readonly ISupplierRepository _supplierRepository;
        private readonly IProductRepository _productRepository;
        private readonly IProductBuilder _productBuilder;

        public AddProductCommandHandler(ICategoryRepository categoryRepository,
                                        IStockRepository stockRepository,
                                        ISupplierRepository supplierRepository,
                                        IProductRepository productRepository,
                                        IProductBuilder productBuilder)
        {
            _categoryRepository = categoryRepository;
            _stockRepository = stockRepository;
            _supplierRepository = supplierRepository;
            _productRepository = productRepository;
            _productBuilder = productBuilder;
        }
        public async Task<Unit> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var (category, supplier, stock) = await GetAggregateEntitiesAsync(request.CategoryId, request.SupplierId, request.LocationId);

            var product = _productBuilder
                                .WithDescription(request.Description)
                                .WithExpirationDate(request.ExpirationDate)
                                .WithManufactoringDate(request.ManufactoringDate)
                                .WithBarCode(request.BarCode)
                                .WithSalePrice(request.SalePrice)
                                .WithStockQuantity(request.StockQuantity)
                                .BuildCategory(category)
                                .BuildLocation(stock)
                                .BuildSupplier(supplier)
                                .BuildMeasure(request.Mensure.UnityMeasurement, request.Mensure.Quantity)
                                .Build();

            await _productRepository.AddProductAsync(product);

            return Unit.Value;
        }

        private async Task<(Category, Supplier, Stock)> GetAggregateEntitiesAsync(string categoryId, string supplierId, string stockId)
        {
            var category = _categoryRepository.GetByIdAsync(categoryId);
            if (category == null)
            {
                throw new Exception("Category not found");
            }

            var supplier = _supplierRepository.GetByIdAsync(supplierId);
            if (supplier == null)
            {
                throw new Exception("Supplier not found");
            }

            var location = _stockRepository.GetByIdAsync(stockId);
            if (location == null)
            {
                throw new Exception("Location not found");
            }

            var tasks = new List<Task> { category, supplier, location };

            await Task.WhenAll(tasks);

            return (category.Result, supplier.Result, location.Result);
        }
    }
}
