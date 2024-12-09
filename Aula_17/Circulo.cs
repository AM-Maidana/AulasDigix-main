using System;
using System.Xml.Serialization;
namespace Aula_17
{
    class Circulo : Forma
    {
        public double Raio;


        public Circulo(String nome, double raio) : base(nome)
        {
            Raio = raio;
        }
        public override double CalcularArea()
        {
           return Math.PI * Math.Pow(Raio, 0);
        }
        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }
        public override void ImprimirDados()
        {
              System.Console.WriteLine("Forma: " + Nome);
              System.Console.WriteLine("Raio: " + Raio);
            System.Console.WriteLine("Area: " + CalcularArea());
            System.Console.WriteLine("Perímetro: " + CalcularPerimetro());

        }

    }
}