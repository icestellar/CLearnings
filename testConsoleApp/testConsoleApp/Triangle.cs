using System;
using System.Collections.Generic;
using System.Text;

namespace testConsoleApp
{
    class Triangle
    {
        private double a;
        private double b;
        private double c;
        
        
        public double A
        {
            set { a = value; }
            get { return a; }
        } 

        public double B
        {
            set { b = value; }
            get { return b; }
        }

        public double C
        {
            set { c = value; }
            get { return c; }
        }
        public bool existingTriangle()
        {
            if (A + B <= C || A + C <= B || B + C <= A) return false;
            else return true;

        }
        public double CalculateP()
        {
            return (A + B + C) / 2;
        }
        public double AreaTriangle()
        {
            return Math.Sqrt(CalculateP() * ((CalculateP() - A) * (CalculateP() - B) * (CalculateP() - C)));
        }

        public string ShowResults()
        {
            if (existingTriangle()) return $"Area do triangulo e: {AreaTriangle().ToString("F2")}";
            else return "Triangulo Impossivel";
        }

    }
}
