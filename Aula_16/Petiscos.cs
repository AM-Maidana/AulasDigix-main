using System;

namespace Aula16_3
{
    class Petiscos
    {
        public string Nome;
        public int Preco;
        public int Qtde;  

    public Petiscos()
    {
        Nome = null;
        Preco = 0;
        Qtde = 10;

        // Se instanciar 
        // Petiscos p = new pestiscos
    }

    public Petiscos(string nome, int preco, int qtde)
    {
        this.Nome = nome;
        this.Preco = preco;
        this.Qtde = qtde;
    }

    public int CalcularP()
    {
        return(int) Preco * Qtde;
    }
}
}