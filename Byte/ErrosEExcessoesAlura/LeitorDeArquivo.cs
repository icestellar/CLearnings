using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ErrosEExcessoesAlura
{
    public class LeitorDeArquivo : IDisposable
    {
        public string Arquivo { get; }
        public LeitorDeArquivo(string arquivo)
        {
            Arquivo = arquivo;
            //throw new FileNotFoundException();
            //Console.WriteLine("Abrindo arquivo " + arquivo);

        }

        public void LerProximaLinha()
        {
            Console.WriteLine("Lendo linha....");
            throw new IOException();
            //return "Linha do arquivo";
        }

        //public void Fechar()
        //{
            
        //}

        public void Dispose()
        {
            //metodo que tem a responsabilidade de fecahr os recursos
            Console.WriteLine("Fechando arquivo.");
        }
    }
}
