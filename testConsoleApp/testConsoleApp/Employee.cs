using System;
using System.Collections.Generic;
using System.Text;

namespace testConsoleApp
{
    class Employee
    {
        private string nome;
        private double bruteSalary;
        private double tax;
        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }
        public double BruteSalary
        {
            set { bruteSalary = value; }
            get { return bruteSalary; }
        }
        public double Tax
        {
            set { tax = value; }
            get { return tax; }
        }

        public double LiquidSalary()
        {
            return BruteSalary - Tax;
        }

        public void IncreaseSalary(double percent)
        {
            BruteSalary += BruteSalary*(percent / 100);
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, ${LiquidSalary()}";
        }
    }
}
