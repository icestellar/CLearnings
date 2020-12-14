using System;
using System.Collections.Generic;
using System.Text;

namespace ErrosEExcessoesAlura
{
    class ContaCorrente
    {
      
        public static double TaxaOperacao { get; private set; }

        public static int TotalDeContasCriadas { get; private set; }
        public int ContadorDeSaquesNaoPermitidos { get; private set; }
        public int ContadorDeTransferenciasNaoPermitidas { get; set; }
        public Cliente Titular { get; set; }

        /*public readonly int _numero;
        public int Numero
        {
            get
            {
                return _numero;
            }
        }
        Podem ser resumidos na linha abaixo
        */
        public int Numero { get; }
        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            private set
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
            }
        }

        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            if(agencia <=0)
            {
                throw new ArgumentException("Numero da agencia tem que ser maior que 0.", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("Numero da conta tem que ser maior que 0.", nameof(numero));
            }
            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;

            
        }

        public void Sacar(double valor)
        {
            if(valor < 0)
            {
                throw new ArgumentException("Valor invalido para o saque", nameof(valor));
            }
            if (_saldo < valor)
            {
                ContadorDeSaquesNaoPermitidos++;
                //return false;
                throw new SaldoInsuficenteException(Saldo, valor);

                //_saldo -= valor;
                //return true;
            }
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor invalido para a transferencia.", nameof(valor));
            }

            try
            {
                Sacar(valor); //usam a mesma logica
            }
            catch (SaldoInsuficenteException ex)
            {
                ContadorDeSaquesNaoPermitidos++;
                //throw ex; - chama o novo objeto e perde a lista de chamadas.
                throw new OperacaoFinanceiraException("Operacao nao realizada", ex); //quando lanca outra excessao, passa a preencher essa.
            }
            contaDestino.Depositar(valor);
        }
    }
}
