using System;
namespace Ex1
{
    public class Product
    {
        public string Nome {get; set;}
        public double Preco {get; set;}

        public Product (string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}