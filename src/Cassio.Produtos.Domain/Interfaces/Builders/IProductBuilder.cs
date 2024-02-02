using Cassio.Produtos.Domain.Builders;
using Cassio.Produtos.Domain.Entities;
using Cassio.Produtos.Domain.Enums;

namespace Cassio.Produtos.Domain.Interfaces.Builders
{
    public interface IProductBuilder
    {
        ProductBuilder BuildCategory(Category category);
        ProductBuilder BuildLocation(Stock stock);
        ProductBuilder BuildSupplier(Supplier supplier);
        ProductBuilder BuildMeasure(EUnityMeasurement unityMeasurement,  decimal quantity);
        ProductBuilder WithDescription(string description);
        ProductBuilder WithBarCode(string barCode);
        ProductBuilder WithSalePrice(decimal salePrice);
        ProductBuilder WithStockQuantity(int stockQuantity);
        ProductBuilder WithManufactoringDate(DateTime manufactoringDate);
        ProductBuilder WithExpirationDate(DateTime? expirationDate);

        void Reset();

        Product Build();
    }
}
