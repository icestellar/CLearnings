using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class EstagiarioTeste : Funcionario
    {
        public EstagiarioTeste(double salario, string cpf) : 
            base(salario, cpf)
        {

        }
        public override void AumentarSalario()
        {
            Salario += 10;
        }

        protected override double GetBonificacao()
        {
            //aqui so faz sentivo o override pq se tivesse o internal ia fazer o metodo visivel
            return 0.01;
        }
    }
}
