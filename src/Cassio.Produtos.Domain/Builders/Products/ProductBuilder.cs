using Cassio.Produtos.Domain.Entities;
using Cassio.Produtos.Domain.Enums;
using Cassio.Produtos.Domain.Interfaces.Builders;
using Cassio.Produtos.Domain.ValueObjects;

namespace Cassio.Produtos.Domain.Builders
{
    public sealed class ProductBuilder : IProductBuilder
    {
        private string Description;
        private string BarCode;
        private decimal SalePrice;
        private int StockQuantity;
        private DateTime ManufactoringDate;
        private DateTime? ExpirationDate;
        private Category Category;
        private Measure Mensure;
        private Stock Location;
        private Supplier Supplier;

        public ProductBuilder() { }

        public ProductBuilder BuildCategory(Category category)
        {
            Category = category;
            return this;
        }

        public ProductBuilder BuildLocation(Stock stock)
        {
            Location = stock;
            return this;
        }

        public ProductBuilder BuildMeasure(EUnityMeasurement unityMeasurement, decimal quantity)
        {
            Mensure = new Measure(unityMeasurement, quantity);
            return this;
        }
        public ProductBuilder BuildSupplier(Supplier supplier)
        {
            Supplier = supplier;
            return this;
        }

        public ProductBuilder WithBarCode(string barCode)
        {
            BarCode = barCode;
            return this;
        }

        public ProductBuilder WithDescription(string description) {
            Description = description;
            return this;
        }

        public ProductBuilder WithExpirationDate(DateTime? expirationDate)
        {
            ExpirationDate = expirationDate;
            return this;
        }

        public ProductBuilder WithManufactoringDate(DateTime manufactoringDate) {
            ManufactoringDate = manufactoringDate;
            return this;
        }

        public ProductBuilder WithSalePrice(decimal salePrice)
        {
            SalePrice = salePrice;
            return this;
        }

        public ProductBuilder WithStockQuantity(int stockQuantity)
        {
            StockQuantity = stockQuantity;
            return this;
        }

        public void Reset()
        {
            Description = null;
            BarCode = null;
            SalePrice = new decimal();
            StockQuantity = new int();
            ManufactoringDate = new DateTime();
            ExpirationDate = null;
            Category = null;
            Mensure = null;
            Location = null;
            Supplier = null;
        }

        public Product Build()
        {
            return new Product(Description,
                               BarCode,
                               SalePrice,
                               StockQuantity,
                               ManufactoringDate,
                               ExpirationDate,
                               Category,
                               Mensure,
                               Location,
                               Supplier);
        }
    }
}
