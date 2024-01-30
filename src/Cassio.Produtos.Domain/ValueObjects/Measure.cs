using Cassio.Produtos.Domain.Enums;
using Cassio.Produtos.Domain.ValueObjects.Base;

namespace Cassio.Produtos.Domain.ValueObjects
{
    public class Measure : ValueObject
    {
        public EUnityMeasurement UnityMeasurement { get; private set; }
        public decimal Quantity { get; private set; }

        public Measure(EUnityMeasurement unityMeasurement, decimal quantity)
        {
            UnityMeasurement = unityMeasurement;
            Quantity = quantity;
        }
    }
}
