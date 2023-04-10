namespace ControleContas.Model
{
    public class Cliente
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public int AnoNascimento { get; private set; }

        public Cliente(string nome, string cpf, int anoNascimento)
        {
            Nome = nome;
            if ((2023 - anoNascimento) >= 18)
                AnoNascimento = anoNascimento;
            else
                throw new ArgumentOutOfRangeException("Idade inválida, cliente precisa ter no mínimo 18 anos.");

            if (cpf.Length == 11)
                Cpf = cpf;
            else
                throw new ArgumentOutOfRangeException("CPF inválido, deve conter 11 caracteres.");
        }

    }
}
