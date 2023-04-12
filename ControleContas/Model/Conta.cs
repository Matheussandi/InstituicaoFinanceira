namespace ControleContas.Model
{
    public class Conta
    {
        public static long _contaMaiorSaldo;
        public static double _maiorSaldo;
        public long Numero { get; private set; }
        public double Saldo { get; private set; }

        public Cliente Cliente { get; set; }
        public Agencia Agencia { get; set; }

        public Conta(long numero, Cliente cliente, double saldo, Agencia agencia)
        {
            Numero = numero;
            Cliente = cliente;
            if (saldo < 10)
                throw new ArgumentOutOfRangeException("Saldo insuficiente, deve haver no mínimo R$10,00.");
            Saldo = saldo;
            Agencia = agencia;
        }

        public override string ToString()
        {
            return $"Conta: {this.Numero}; Cliente: {this.Cliente.Nome}; Saldo: {this.Saldo}; Agencia: {this.Agencia.Numero}";
        }

        public void Deposito(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentOutOfRangeException("valor invalido");
            }
            else
            {
                Saldo += valor;
            }

            AtualizaMaiorSaldo();
        }

        public void Saque(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentOutOfRangeException("valor inválido");
            }
            else if (valor > Saldo)
            {
                throw new ArgumentOutOfRangeException("Valor de saque maior que saldo");
            }
            else
            {
                Saldo -= valor;
            }
            AtualizaMaiorSaldo();
        }

        public void Transferencia(double valor, Conta destino)
        {
            if (valor < 0)
            {
                throw new ArgumentOutOfRangeException("valor inválido");
            }
            else if (valor > Saldo)
            {
                throw new ArgumentOutOfRangeException("Valor de transferência maior que saldo");
            }
            else
            {
                this.Saque(valor);
                destino.Deposito(valor);
            }
        }

        private void AtualizaMaiorSaldo()
        {
            if (this.Saldo > _maiorSaldo)
            {
                _contaMaiorSaldo = this.Numero;
                _maiorSaldo = this.Saldo;
            }
        }
    }
}
