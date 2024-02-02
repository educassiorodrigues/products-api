using Cassio.Produtos.Domain.Commands.Products.Base.Mensure;
using MediatR;

namespace Cassio.Produtos.Domain.Commands.Products.Add
{
    public class AddProductCommand : IRequest <Unit>
    {
        public string LocationId { get; set; }
        public string SupplierId { get; set; }
        public string CategoryId { get; set; }

        public string Description { get; set; }

        public string BarCode { get; set; }

        public decimal SalePrice { get; set; }

        public int StockQuantity { get; set; }

        public DateTime ManufactoringDate { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public MensureCommand Mensure { get; set; }
    }
}
