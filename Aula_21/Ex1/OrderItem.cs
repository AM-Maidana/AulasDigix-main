using System;
namespace Ex1
{
    public class OrderItem : Product
    {


        public int Qtde { get; set; }


        public OrderItem(string nome, double preco, int qtde) : base(nome, preco)
        {
            Qtde = qtde;

        }


        public double SubTotal()
        {
            return Qtde * Preco;
        }
    }
}