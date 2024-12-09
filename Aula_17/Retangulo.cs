using System;
using System.Xml.Serialization;
namespace Aula_17
{
    class Retangulo : Forma
    {
        public double Largura;
        public double Altura;



        public Retangulo(String nome, double largura, double altura) : base(nome)
        {
            this.Largura = largura;
            this.Altura = altura;
        }
        public override double CalcularArea()
        {
           return Largura * Altura;
        }
        public override double CalcularPerimetro()
        {
            return 2 * (Largura * Altura);
        }
        public override void ImprimirDados()
        {
              System.Console.WriteLine("Forma: " + Nome);
              System.Console.WriteLine("Largura: " + Largura);
              System.Console.WriteLine("Altura: " + Altura);
              
            System.Console.WriteLine("Area: " + CalcularArea());
            System.Console.WriteLine("Perímetro: " + CalcularPerimetro());

        }

    }
}