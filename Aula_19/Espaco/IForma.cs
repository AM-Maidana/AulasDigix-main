using System;
namespace Aula19_1
{
    public interface IForma
    {
        double CalcularArea();
        double CalcularPerimetro();

        //Esse tipo de declaração de função
        void ExibirInformacoes()
        {
            System.Console.WriteLine("Area: " + CalcularArea());
            System.Console.WriteLine("Perímetro: " + CalcularPerimetro());
        }
    }
}