using Cassio.Produtos.Domain.ValueObjects.Base;

namespace Cassio.Produtos.Domain.ValueObjects
{
    public class Identification : ValueObject
    {
        private const int LENGTH_CPF = 11;
        private const int LENGTH_CNPJ = 14;

        private string Cpf;
        private string Cnpj;

        public string Number { get; private set; }
        public string FormattedNumber { get; private set; }

        public char Type {  get; private set; }

        public Identification(string identification)
        {
            identification = RemoveSpecialCharsAndTrim(identification);

            if (identification.Length < LENGTH_CPF || identification.Length > LENGTH_CNPJ)
            {
                throw new ArgumentException("Identification Number is not valid.");
            }

            SetPersonIdentification(identification);
            SetEnterpriseIdentification(identification);
        }

        private void SetPersonIdentification(string identification)
        {
            if (identification.Length is not LENGTH_CPF)
                return;

            Cpf = identification;
            Number = Cpf;
            FormattedNumber = FormatCpf(Cpf);
            Type = 'F';
        }

        private void SetEnterpriseIdentification(string identification)
        {
            if (identification.Length is not LENGTH_CNPJ)
                return;

            Cnpj = identification;
            Number = Cnpj;
            FormattedNumber = FormatCnpj(Cnpj);
            Type = 'J';
        }

        private string RemoveSpecialCharsAndTrim(string str)
        {
            return str.Trim([' ', '*', '.']);
        }

        private static string FormatCpf(string cpf)
        {
            return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
        }

        private static string FormatCnpj(string cnpj)
        {
            return Convert.ToUInt64(cnpj).ToString(@"00\.000\.000\/0000\-00");
        }

        public string GetType()
        {
            return Type is 'J' ? "Enterprise" : "Person";
        }
    }
}
