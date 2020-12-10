using System;
using System.Globalization;
namespace UdemyVectors
{
    class Product
    {
        private string _name;
        private int _amount;

        //Sobrecarga - Metodos com o mesmo nome, mas que recebe parametros diferentes
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //Price using auto properties
        public double Price { get; private set; } //Its forbbiden change the value of price;


        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        /*
         Outra forma de fazer get e set 
            public string GetNome(){
            return Nome;        
             }

            public void SetNome(string value){
            Nome = value;
            }
         */

        public double TotalValueInStock()
        {
            return Price * Amount;
        }
        public void ShowInformation()
        {
            Console.WriteLine($"Produto: {Name}\nPreco: {Price}\nQuantidade em estoque: {Amount}\nTotal em estoque: {TotalValueInStock()}");
        }
        public override string ToString()
        {
            return Name + ", $" + Price.ToString("F2", CultureInfo.InvariantCulture) + ", " + _amount.ToString();
            //return base.ToString();
        }
        public void AddProduct(int amount)
        {
            Amount += amount;
            //ShowInformation(); Um metodo faz so o que ele fala no nome - 2018 Sandino

        }

        public void RmvProduct(int amount)
        {
            Amount -= amount;
            //ShowInformation(); Um metodo faz so o que ele fala no nome - 2018 Sandino
        }

        public void AddPrice(double price)
        {
            Price += price;
        }
    }
}
