using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    class TotalDeDespesas
    {
        public double TotalBonificacao { get; private set; }

        public void SomaTotalBonificao(double value)
        {
            TotalBonificacao += value;
        }

        public double GetTotalBonificao()
        {
            return TotalBonificacao;
        }
    }
}
