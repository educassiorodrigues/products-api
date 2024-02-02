using Cassio.Produtos.Domain.Entities.Base;

namespace Cassio.Produtos.Domain.Entities
{
    public class Category : Entity
    {
        public string Description { get; private set; }

        public List<Product> Products { get; set; } = new List<Product>();

        protected Category() { }

        public Category(string description)
        {
            Description = description;
        }
    }
}
