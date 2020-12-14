using ByteBank.Clientes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Contas
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }
        public Cliente Titular { get; set; }
        public int Numero { get; set; }
        public int Agencia { get; set; }
        public double Saldo { get; private set; }

        public ContaCorrente(Cliente titular, int agencia, int numero)
        {
            Numero = numero;
            Agencia = agencia;
            Titular = titular;
            TotalDeContasCriadas++;
        }
        public ContaCorrente(Cliente titular, int agencia, int numero, double saldo)
        {
            Numero = numero;
            Agencia = agencia;
            Titular = titular;
            Saldo = saldo;
            TotalDeContasCriadas++;
        }

        public bool Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        public bool Transferir(double valor, ContaCorrente ContaDeDestino)
        {
            if (valor < Saldo)
            {
                Saldo -= valor;
                ContaDeDestino.Saldo += valor;
                return true;
            }
            return false;
        }
    }
}
