using System;
using System.Collections.Generic;
using System.Text;
//
namespace Katas
{
    class CountingDuplicates
    {
        public string Words { get; set; }
        public CountingDuplicates(string words)
        {
            Words = words;
        }

        public int counting()
        {
            var word = new List<char>(Words);
            word.Sort();
            return word.Count;
        }
    }
}
