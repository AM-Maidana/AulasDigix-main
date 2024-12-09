using System;

namespace Aula_17
{
    public abstract class Forma
    {
        public string Nome;

        public Forma(string nome)
        {
            Nome = nome;
        }

        public abstract double CalcularArea();

        public abstract double CalcularPerimetro();

        public virtual void ImprimirDados()
        {
            System.Console.WriteLine("Forma: " + Nome);
            System.Console.WriteLine("Area: " + CalcularArea());
            System.Console.WriteLine("Perímetro: " + CalcularPerimetro());

        }
    }
}