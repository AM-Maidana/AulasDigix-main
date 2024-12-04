using System;

namespace Aula15_2
{
    class Produto
    {

        public string Nome;
        public double Preco;

// Constroi um meodo que é chamado quando a classe é instanciada
        public Produto(string nome, double preco)
        {
            // atribui o valor do parametro para a variável nome / preço
            this.Nome = nome;
            this.Preco = preco;
        }

        public void ImprimirInformacoes()
        {
            System.Console.WriteLine("Nome: " + this.Nome);
            System.Console.WriteLine("Preço: " + this.Preco);
        }
        static void Main(string[] args)
        {
            Produto p1 = new Produto("Notebook", 2000);
            p1.ImprimirInformacoes();
        }
    }
}