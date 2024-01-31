namespace Cassio.Produtos.Domain.Commands.Base
{
    public class AddressCommand
    {
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Neighborhood { get; set; }
        public string Complement { get; set; }
        public int Number { get; set; }
    }
}
