﻿using ControleContas.Model;
internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Cliente cliente1 = new Cliente("Matheus", "12345678901", 2000);
            Conta conta1 = new Conta(123456789, cliente1, 3000);
            Console.WriteLine($"{conta1.ToString()}");

            Cliente cliente2 = new Cliente("Maria", "12345678901", 2000);
            Conta conta2 = new Conta(987654321, cliente2, 1000);
            Console.WriteLine($"{conta2.ToString()}");

            Console.WriteLine(' ');

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