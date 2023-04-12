namespace ControleContas.Model
{
    public class Agencia
    {
        public int Numero { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public Banco Banco { get; set; }

        public Agencia(int numero, string cep, string telefone, Banco banco)
        {
            Numero = numero;
            if (cep.Length == 8)
                Cep = cep;
            else
                throw new ArgumentOutOfRangeException("CEP inválido.");

            if (telefone.Length == 11)
                Telefone = telefone;
            else
                throw new ArgumentOutOfRangeException("Número de telefone inválido.");
            Banco = banco;
        }
    }
}
