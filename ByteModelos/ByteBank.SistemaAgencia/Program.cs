using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            //string urlDeTeste = "http://aoa.com/nomedamusica=likeacat&integrantes=jimin";
            //ExtratorValorDeArgumentosURL url = new ExtratorValorDeArgumentosURL(urlDeTeste);
            //string valor = "IntegRantes";
            //Console.WriteLine(url.GetValor(valor) + valor);
            //Console.ReadLine();
            Match c = Regex.Match("22-c62", "[0-9]{2}-?[0-9]{2}");
            Match k = Regex.Match("22-62","[0-9]{2}[-][0-9]{2}");
            Match j = Regex.Match("936636280", "[0-9]{4,5}[-]{0,1}[0-9]{4}");
            Console.WriteLine(c.Value);
            Console.ReadLine();
        }

        static string WhoLikes(string[] a)
        {
            return ""+ a[0].Length;
        }
    }
}
