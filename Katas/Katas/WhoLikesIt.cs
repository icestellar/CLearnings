using System;
using System.Collections.Generic;
using System.Text;

namespace Katas
{
    public class WhoLikesIt
    {
        public string[] Words { get; set; }
        public WhoLikesIt(string words)
        {
            Words = words.Split(" ");
        }

        public string WhoLikesIti()
        {
            switch (Words.Length)
            {
                case 0:
                    return "no one likes this";
                case 1:
                    return $"{Words[0]} likes this";
                case 2:
                    return $"{Words[0]} and {Words[1]} like this";
                case 3:
                    return $"{Words[0]}, {Words[1]} and {Words[2]} like this";
                default:
                    return $"{Words[0]}, {Words[1]} and {Words.Length - 2} others like this";
            }

        }
        
        public string alternativeSolution()
        {
            string[] pattern = { "no one likes this", "{0} likes this", "{0} and {1} like this", "{0}, {1} and {2} like this", "{0}, {1} and {2} others like this" };

            return Words.Length < 4 ? string.Format(pattern[Words.Length], Words) : string.Format(pattern[4], Words[0], Words[1], Words.Length - 2);
        }
    }
}
