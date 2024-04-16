using Cassio.Produtos.Domain.Entities.Base;

namespace Cassio.Produtos.Domain.Entities
{
    public class Category : Entity
    {
        public string Description { get; private set; }

        protected Category() { }

        public Category(string description)
        {
            Description = description;
        }
    }
}
