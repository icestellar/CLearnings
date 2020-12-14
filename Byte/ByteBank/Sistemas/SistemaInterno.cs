using System;
using System.Collections.Generic;
using System.Text;
using ByteBank.Funcionarios;

namespace ByteBank.Sistemas
{
    class SistemaInterno
    {
        
        public bool Logar(InterfaceAutenticavel funcionario, string senha)
        {
            if (funcionario.Autenticar(senha))
            {
                Console.WriteLine("Ok, autenticado");
                return true;
            }
            return false;
        }
    }
}
