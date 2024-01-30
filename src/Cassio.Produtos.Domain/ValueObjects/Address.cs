using Cassio.Produtos.Domain.ValueObjects.Base;

namespace Cassio.Produtos.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public string City { get; private set; }
        public string State { get; private set; }
        public string Neighborhood { get; private set; }
        public int Number { get; private set; }
        public string Country { get; private set; }
        public string Complement { get; private set; }

        public Address(string city, string state, string neighborhood, int number, string country, string complement)
        {
            City = city;
            State = state;
            Neighborhood = neighborhood;
            Number = number;
            Country = country;
            Complement = complement;
        }

        public override string ToString()
        {
            const char WHITE_SPACE = ' ';
            return string.Join(WHITE_SPACE, [Country, City, State, Neighborhood, Number]);
        }
    }
}
