using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaleumCodesExercicies
{
    class BaskaraItems
    {
        public int A { set; get; }
        public int B { set; get; }
        public int C { set; get; }

        private string negative = "negative";
        
        public double CalculingDelta()
        {
            double delta = (B * B) - (4 * A * C);
            if(delta >= 0)
            {
                negative = "positive";
                return delta;
            }
            else
            {
                return -1;
            }

        }
        public double returnA1()
        {
            return (-B + Math.Sqrt(CalculingDelta())) / (2 * A);
        }

        public double returnA2()
        {
            return (-B - Math.Sqrt(CalculingDelta())) / (2 * A);
        }

        public string JoiningAs()
        {
            if(negative != "negative")
            {
                return $"A1 = {returnA1()} \nA2: {returnA2()}";
            }
            else
            {
                return negative;
            }
        }

    }
}
