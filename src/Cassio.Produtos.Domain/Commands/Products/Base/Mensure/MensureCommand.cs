using Cassio.Produtos.Domain.Enums;

namespace Cassio.Produtos.Domain.Commands.Products.Base.Mensure
{
    public class MensureCommand
    {
        public EUnityMeasurement UnityMeasurement { get; set; }
        public decimal Quantity { get; set; }
    }
}
