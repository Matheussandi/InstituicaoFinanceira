using ControleContas.Model;
internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("SALDO INICIAL");
            Cliente cliente1 = new Cliente("Matheus", "12345678901", 2000);
            Banco banco1 = new Banco("Nubank", 111);
            Agencia agencia1 = new Agencia(123, "12345678", "24999111111", banco1);
            Conta conta1 = new Conta(1, cliente1, 3000, agencia1);
            Console.WriteLine($"{conta1.ToString()}");

            Cliente cliente2 = new Cliente("Maria", "12345678901", 2000);
            Banco banco2 = new Banco("Nubank", 111);
            Agencia agencia2 = new Agencia(456, "12345678", "24999111666", banco2);
            Conta conta2 = new Conta(2, cliente2, 1000, agencia2);
            Console.WriteLine($"{conta2.ToString()}");

            Console.WriteLine(' ');
            Console.WriteLine("SALDO DEPOIS DAS OPERAÇÕES");

            conta2.Deposito(2341.42);

            conta1.Deposito(1000);

            conta1.Transferencia(500, conta2);

            Console.WriteLine($"{conta1.ToString()}");
            Console.WriteLine($"{conta2.ToString()}");

            Console.WriteLine(' ');

            Console.WriteLine("O saldo total das duas contas é " + (conta1.Saldo + conta2.Saldo));
            Console.WriteLine($"A conta de maior saldo é {Conta._contaMaiorSaldo} cujo saldo é {Conta._maiorSaldo}");
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}