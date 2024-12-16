using System;
namespace Aula19_1
{
    public class Circulo : IForma
    {
        public double Raio;
        
        public Circulo(double raio)
        {
            Raio = raio;
        }
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }
        public void ExibirInformacoes()
        {
            System.Console.WriteLine("circulo");
            System.Console.WriteLine("Raio: " + Raio);
        }
    }
}