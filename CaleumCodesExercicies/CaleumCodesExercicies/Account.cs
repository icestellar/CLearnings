using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaleumCodesExercicies
{
    class Account
    {
        private int numberAccount;
        private string userName;
        private double balance;

        public int NumberAccount
        {
            get { return numberAccount; }
            set { numberAccount = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public double Balance
        {
            get { return balance;  }
            set { balance = value;  }
        }

        public bool WithDrawMoney(double value)
        {
            if (value > balance) return false;
            else
            {
                balance -= value;
                return true;
            }
        }
        
    }
}
