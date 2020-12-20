using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Katas
{
    //Link: https://www.codewars.com/kata/54da5a58ea159efa38000836/train/csharp;
    public class FindTheOddInt
    {
        public List<int> Numbers { get; set; }
        public HashSet<int> Nnumbers { get; set; }
        public FindTheOddInt(int[] numbers)
        {
            Numbers = new List<int>(numbers);
            Nnumbers = new HashSet<int>(numbers);
            Numbers.Sort();
        }

        public int FindingOdd()
        {
            int a = 0;
            foreach(int i in Nnumbers)
            {
                foreach(int k in Numbers)
                {
                    if(i == k)
                    {
                        a++;
                    }
                }
                if(a%2 == 1)
                {
                    return i;
                }
                a = 0;
            }
            return -1;
        }

        //public int alternativeSolution(int[] seq)
        //{
        //    {
        //        return seq.ToList()
        //                  .GroupBy(x => x) //Group by each element in the array
        //                  .Where(x => (x.Count() % 2) != 0) //Find grouped odd numbers
        //                  .Select(x => x.First())
        //                  .FirstOrDefault(); //since array will only contain 1 odd number, get first one
        //    }

        //}
        /*
         *public static int find_it(int[] seq) 
      {
        return seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;
      }
         */


    }

}
