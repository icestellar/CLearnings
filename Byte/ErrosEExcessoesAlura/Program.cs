using ErrosEExcessoesAlura;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {

        static void Main(string[] args)
        {
            //try
            //{
            //    ContaCorrente conta = new ContaCorrente(0, 0);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.ReadLine();
            //}
            Console.WriteLine("53201129590782000148550010000133521152770059");
            for(int i = 1; i<45; i++)
            {
                Console.Write(i%10);
            }
        }

        private static void CarregarContas_()
        {
            //Corrigido usando liberacao de recursos
            using LeitorDeArquivo leitor = new LeitorDeArquivo("test.txt");
            leitor.LerProximaLinha();
        }
        private static void CarregarContas()
        {
            LeitorDeArquivo leitor = null;
            try
            {
                leitor = new LeitorDeArquivo("contas1.txt");
                leitor.LerProximaLinha();
            }
            catch (IOException)
            {
                Console.WriteLine("IOException");

            }
            finally
            {
                //e executado sempre independente de acontecer excecao ou nao
                //if (leitor != null) leitor.Fechar();

            }
        }
        public static string Metodo(string a)
        {
            try
            {
                return a.ToString();
            }
            catch(Exception)
            {
                throw; //passa o erro para o metodo seguinte na pilha.
            }
        }

        public static int Metodo2()
        {
            return 1 / 2;
        }

        public void TestaInnerException()
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(514, 900);
                ContaCorrente conta2 = new ContaCorrente(514, 8998);

                conta2.Sacar(110);

            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.InnerException); //acessa a excessao interna.
            }
        }



    }
}