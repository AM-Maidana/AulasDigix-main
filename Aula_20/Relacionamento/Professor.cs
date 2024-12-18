using System;
namespace Aula_20.Relacionamento
{
    public class Professor
    {
        public string Nome{ get; set;}


        public Professor(string nome)
        {
            Nome = nome;
        }
        public void Ensinar()
        {
            System.Console.WriteLine($"Professor: {Nome} ensina o ABDC");
        }
    }
}