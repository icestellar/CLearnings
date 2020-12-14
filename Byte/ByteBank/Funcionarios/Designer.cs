using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    class Designer : Funcionario
    {
        public int TotalDesigner { get; private set; }
        public string Senha { get; set; }
        public Designer(string cpf, double salario) : base(cpf, salario)
        {
            TotalDesigner++;
        }
        public override void AumentaSalario()
        {
            Salario *= 1.12;
        }

        public override double getBonus()
        {
            return Salario * .12;
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
