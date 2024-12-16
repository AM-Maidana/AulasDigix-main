using System;
namespace Aula19_exercicio
{
    public class Formiga : Animal
    {
        public string Tipo;
         public Formiga(string tipo, string comida) : base("Formiga", comida) // "Peixe" é passado como 'animais' para a classe pai
        {
            Tipo = tipo;
            Comida = comida; 
        }
        public void Come()
        {
            System.Console.WriteLine($"A Formiga comeu: {Comida}");
        }
    }
}