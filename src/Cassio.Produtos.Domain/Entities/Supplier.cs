using Cassio.Produtos.Domain.Entities.Base;
using Cassio.Produtos.Domain.ValueObjects;

namespace Cassio.Produtos.Domain.Entities
{
    public class Supplier : Entity
    {
        public string Name { get; private set; }
        public Address Address { get; private set; }
        public Identification Identification {  get; private set; }


        protected Supplier() { }

        public Supplier(string name, Address address, Identification identification)
        {
            Name = name;
            Address = address;
            Identification = identification;
        }
    }
}
