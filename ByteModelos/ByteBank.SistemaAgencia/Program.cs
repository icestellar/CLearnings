using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string urlDeTeste = "http://aoa.com/nomedamusica=likeacat&integrantes=jimin";
            ExtratorValorDeArgumentosURL url = new ExtratorValorDeArgumentosURL(urlDeTeste);
            string valor = "IntegRantes";
            Console.WriteLine(url.GetValor(valor) + valor);
            Console.ReadLine();
        }
    }
}
