using System;
using System.Collections.Generic;
using System.Text;

namespace testConsoleApp
{
    class StaticCalculator
    {
        private static double pi = 3.14;
        public static double circleArea(double radio)
        {
            return 2 * pi * radio * radio;
        }
        public static double DolarConversor(double unitaryValue, double amount)
        {
            return (unitaryValue * amount * 0.06)+(unitaryValue*amount);
        }

    }
}
