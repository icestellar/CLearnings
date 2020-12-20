using System;

namespace Katas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Declarando a um array p/ inicializar
             FindTheOddInt[] wholikesit = new FindTheOddInt[?size]{
                   new FindTheOddInt(string);
            }
             */
            FindTheOddInt wholikesit = new FindTheOddInt(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 });
            Console.WriteLine(wholikesit.FindingOdd());
            Console.WriteLine();
        }
    }
}
