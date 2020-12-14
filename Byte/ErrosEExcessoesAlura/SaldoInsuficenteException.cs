using System;
using System.Collections.Generic;
using System.Text;

namespace ErrosEExcessoesAlura
{
    public class SaldoInsuficenteException : OperacaoFinanceiraException
    {
        public double Saldo { get; }
        public double ValorDoSaque { get; }
        public SaldoInsuficenteException()
        {

        }
        public SaldoInsuficenteException(string mensagem) : base(mensagem)
        {

        }

        public SaldoInsuficenteException(double saldo, double valorDoSaque)
            : this("Tentativa de saque do valor de " + valorDoSaque + ".\nSaldo disponivel: R$" + saldo)
        {
            Saldo = saldo;
            ValorDoSaque = valorDoSaque;
            //Se passar para a base perde a inicializacao. Dessa maneira guarda nas duas classes.
        }

        public SaldoInsuficenteException(string mesagem, Exception exception) :
            base(mesagem, exception)
        {

        }
    }
}
