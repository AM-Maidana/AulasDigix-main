using System;
namespace Aula19_exercicio
{
    public class Cachorro : Animal, IAnimalEstimacao
    {
        private string Nome { get; set; }
        public Cachorro(string nome, string comida) : base("Cachorro", comida) // "Peixe" é passado como 'animais' para a classe pai
        {
            Nome = nome;
            Comida = comida; 
        }
        public void ExibirNomeCachorro()
        {
            System.Console.WriteLine($"O nome do cachorro é: {Nome}");
        }
       public void Brinca()
       {
        System.Console.WriteLine("O cachorro brincou de pegar bolinha");
       }
        public void Come()
        {
            System.Console.WriteLine($"O cachorro comeu: {Comida}");
        }
    }
}