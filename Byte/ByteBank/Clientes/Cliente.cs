using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Clientes
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

    }
}
