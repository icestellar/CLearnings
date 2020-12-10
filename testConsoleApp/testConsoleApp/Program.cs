using System;
using System.Collections.Generic; //Para listas
using System.Globalization;
namespace testConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o numero da conta");
            int account = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o nome do titular da conta");
            string name = Console.ReadLine();
            Console.WriteLine("Insira uma opcao");
            short chooseOption = short.Parse(Console.ReadLine());
            if(chooseOption == 1)
            {
                UdemyClass5Exercice testing = new UdemyClass5Exercice(account, name);
                test(testing);
            }
            else
            {
                Console.WriteLine("Insira o valor inicial da conta");
                double initialValue = double.Parse(Console.ReadLine());
                UdemyClass5Exercice testing = new UdemyClass5Exercice(account, name, initialValue);
                test(testing);
            }


        }
        static void test(UdemyClass5Exercice testing)
        {
            testing.AddMoney(100);
            Console.WriteLine("" + testing);
            testing.RemoveMoney(100);
            Console.WriteLine("" + testing);
        }
    }
}
