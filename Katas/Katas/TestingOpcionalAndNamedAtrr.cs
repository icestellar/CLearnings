using System;
using System.Collections.Generic;
using System.Text;

namespace Katas
{
    public class TestingOpcionalAndNamedAtrr
    {
        public int number1 { get; }
        public int number2 { get; }
        public TestingOpcionalAndNamedAtrr(int n2, int n1 = 0)
        {
            number1 = n1;
            number2 = n2;
        }

        
    }
}
