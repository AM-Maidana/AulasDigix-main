using System;
namespace Aula19_exercicio
{
    public class Mainn
    {
        static void Main(string[] args)
        {
            Cachorro cachorro = new Cachorro("Totó", "pedaço de osso");
            cachorro.ExibirNomeCachorro();
            cachorro.Brinca();
            cachorro.Come();

            System.Console.WriteLine();

            Peixe peixe = new Peixe("Tilápia", "ração");
            peixe.ExibirNome();
            peixe.Brinca();
            peixe.Come();

            System.Console.WriteLine();

            Formiga formiga = new Formiga("Formiga de fogo", "folhas");
            formiga.Come();
        }
    }
}