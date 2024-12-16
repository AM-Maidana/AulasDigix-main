using System;
using System.Runtime.CompilerServices;
namespace Aula19_exercicio
{
    public class Animal
    {
        public string Animais;

        public string Comida;

        public Animal(string animais, string comida)
        {
            Animais = animais;
            Comida = comida;
        }
        public string Animall()
        {
            return Animais;
        }
        public void Come()
        {
            System.Console.WriteLine($"O animal comeu: {Comida}");
        }

    }
}