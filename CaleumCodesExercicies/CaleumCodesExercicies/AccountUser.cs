using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaleumCodesExercicies
{
    class AccountUser
    {
        private string numberAccount;
        public double AccountBalance { get; set; }
        private double balance;
        private double withdraw;
        public string NumberAccount {
            get { return numberAccount; }
            set { numberAccount = value; }
        }
        public double Balance{
            get { return balance; }
            set { balance = value; }
        }

        public double Withdraw
        {
            get { return withdraw; }
            set { withdraw = value; }
        }

        public double WithdrawMoney()
        {
            if(balance < withdraw)
            {
                return -1;
            }
            else
            {
                balance -= withdraw;
                return balance;
            }
        }

        public string ShowState()
        {
            if (WithdrawMoney() == -1) return "Operacao nao realizada.";
            else return $"Operacao realizada com sucesso\nSaldo atual: {balance}";
        }
        
    }
}
