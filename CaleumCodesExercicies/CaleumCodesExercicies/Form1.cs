using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaleumCodesExercicies
{
    public partial class Form1 : Form
    {
        List<Account> users = new List<Account>();
        public Form1()
        {
            InitializeComponent();
           
        }
        private void btnHello_Click(object sender, EventArgs e)
        {
            /*
            AccountUser newUser = new AccountUser();
            newUser.NumberAccount = $"{(40+50+10)/3}" ;
            newUser.AccountBalance = 100;
            MessageBox.Show($"Average is = {newUser.NumberAccount}");
            BaskaraItems baskara = new BaskaraItems
            {
                A = 2,
                B = 2,
                C = 1
            };
            MessageBox.Show(baskara.JoiningAs());
            }
            AccountUser user = new AccountUser();
            user.Balance = 2000;
            user.Withdraw = 2000;
            MessageBox.Show(user.ShowState());
            users.Add(new Account { NumberAccount = Int32.Parse(txtNumberAccount.Text), UserName = txtName.Text, Balance = 2000});
            MessageBox.Show($"{users[0].WithDrawMoney(Double.Parse(txtValueToWithdraw.Text))} \n {users[0].Balance}");
            //users.Add(new Account { NumberAccount = Int32.Parse(txtNumberAccount.Text), UserName = txtName.Text, Balance = 6000});
            //Lembre-se, precisa reiniciar o texto.
            MessageBox.Show($"{users[1].WithDrawMoney(Double.Parse(txtValueToWithdraw.Text))} \n {users[1].Balance}");
            */



        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNumberAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValueToWithdraw_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
