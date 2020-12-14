using System;

namespace Katas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(convertToBinary(1, 2));
        }
        static string Middle(string word)
        {
            char[] letters = word.ToCharArray();
            if (letters.Length % 2 == 0) return $"{letters[letters.Length / 2 - 1]} {letters[letters.Length / 2]}";
            return $"{letters[letters.Length / 2]}";
        }

        static int FindingShortest(string phrase)
        {
            string[] words = phrase.Split(" ");
            int a = words[0].Length;
            foreach (string word in words)
            {
                int b = word.Length;
                if (a > word.Length) a = word.Length;
            }
            return a;
        }

        static int convertToBinary(int a, int b)
        {
            return int.Parse(Convert.ToString(a + b, 2));

        }
    }
}
