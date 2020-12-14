using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    class Diretor : FuncionarioAutenticavel
    {
        public int TotalDiretor { get; private set; }

        public Diretor(string cpf) : base(cpf, 5000)
        {
            TotalDiretor++;
        }

        public override double getBonus()
        {
            return Salario/2;
        }
        public override void AumentaSalario()
        {
            Salario *= 1.15;
        }
    }
}
