using System;

namespace Aula19_exercicio
{
    public class Peixe : Animal, IAnimalEstimacao
    {
        private string Nome { get; set; }
        
        // O construtor agora recebe o nome e a comida e chama o construtor da classe pai
        public Peixe(string nome, string comida) : base("Peixe", comida) // "Peixe" é passado como 'animais' para a classe pai
        {
            Nome = nome;
            Comida = comida; // Comida será herdado de Animal
        }
        public void ExibirNome()
        {
            System.Console.WriteLine($"O nome do peixe é: {Nome}");
        }
       public void Brinca()
       {
        System.Console.WriteLine("O peixe brincou de nadar atrás de outros peixes");
       }
    }
}
