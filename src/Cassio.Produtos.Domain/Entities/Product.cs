using System.Drawing;

namespace Cassio.Produtos.Domain.Entities
{
    public class Product : Entity
    {
        // name
        public string Description { get; private set; }

        // categoria => classe


        public string BarCode { get; private set; }

        // public decimal SalePrice { get; private set; }

        public int StockQuantity { get; private set; }

        // public DateTime ManufactoringDate { get; private set; }

        // public DateTime? ExpirationDate { get; private set; }

        // A unidade padrão pela qual o produto é medido(por exemplo, peças, quilogramas, litros).

        // public Meansure Mensure { get; private set; }


        // local estoque
        //public Stock Location { get; private set; }

        // Informações sobre o fornecedor do produto.
        // public Supplier Supplier { get; private set; }

        protected Product() { }

        public Product(string description, string barCode, int stockQuantity)
        {
            Description = description;
            BarCode = barCode;
            StockQuantity = stockQuantity;
        }
    }
}
