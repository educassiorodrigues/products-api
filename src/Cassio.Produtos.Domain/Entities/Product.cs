using Cassio.Produtos.Domain.Entities.Base;
using Cassio.Produtos.Domain.ValueObjects;

namespace Cassio.Produtos.Domain.Entities
{
    public class Product : Entity
    {
        public string Description { get; private set; }

        public string BarCode { get; private set; }

        public decimal SalePrice { get; private set; }

        public int StockQuantity { get; private set; }

        public DateTime ManufactoringDate { get; private set; }

        public DateTime? ExpirationDate { get; private set; }

        public Category Category { get; private set; }

        public Measure Mensure { get; private set; }

        public Stock Location { get; private set; }

        public Supplier Supplier { get; private set; }

        public Product() { }

        public Product(
            string description,
            string barCode,
            decimal salePrice,
            int stockQuantity,
            DateTime manufactoringDate,
            DateTime? expirationDate,
            Category category,
            Measure mensure,
            Stock location,
            Supplier supplier)
        {
            Description = description;
            BarCode = barCode;
            SalePrice = salePrice;
            StockQuantity = stockQuantity;
            ManufactoringDate = manufactoringDate;
            ExpirationDate = expirationDate;
            Category = category;
            Mensure = mensure;
            Location = location;
            Supplier = supplier;
        }
    }
}
