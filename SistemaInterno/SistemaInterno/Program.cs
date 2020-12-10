using System;
using ByteBank.Modelos;

namespace SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(129, 889);
            Console.WriteLine(conta.Saldo);
            Console.ReadLine();
        }
    }
}
