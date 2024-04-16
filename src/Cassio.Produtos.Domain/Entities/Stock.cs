using Cassio.Produtos.Domain.Entities.Base;
using Cassio.Produtos.Domain.ValueObjects;

namespace Cassio.Produtos.Domain.Entities
{
    public class Stock : Entity
    {
        public string Description { get; private set; }
        public Address Address { get; private set; }

        protected Stock() { }

        public Stock(string description, Address address)
        {
            Description = description;
            Address = address;
        }
    }
}
