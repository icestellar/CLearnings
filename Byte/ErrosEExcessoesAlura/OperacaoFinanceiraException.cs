using System;
using System.Collections.Generic;
using System.Text;

namespace ErrosEExcessoesAlura
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException()
        {

        }

        public OperacaoFinanceiraException(string mensagem) : base(mensagem)
        {

        }

        public OperacaoFinanceiraException(string mensagem, Exception exception)
            : base(mensagem, exception)
        {

        }
    }
}
