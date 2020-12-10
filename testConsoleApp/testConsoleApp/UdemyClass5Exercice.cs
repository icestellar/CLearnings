using System;
using System.Collections.Generic;
using System.Text;

namespace testConsoleApp
{
    class UdemyClass5Exercice
    {
        private int _accountNumber;
        private string _name;

        public double InitialValue { get; private set; }
        
        public UdemyClass5Exercice (int accountNumber, string name)
        {
            _accountNumber = accountNumber;
            _name = name;

        }

        public UdemyClass5Exercice(int accountNumber, string name, double initialValue) : this(accountNumber, name)
        {
            InitialValue += initialValue;
        }


        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }  
        }
        
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 1) _name = value;
            }
        }

        public void AddMoney(double value)
        {
            InitialValue += value;
        }

        public void RemoveMoney(double value)
        {
            InitialValue -= (value + 5);
        }

        public override string ToString()
        {
            return $"Conta: {AccountNumber}\nTitular: {Name}\nSaldo: {InitialValue}";
        }
    }
}
