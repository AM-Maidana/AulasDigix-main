using System;
namespace Aula17_2
{
    public class Executar
    {
        static void Main(string [] args)
        {
            Funcionario funcionario = new Funcionario("Luix", 2000, "Analista");
            System.Console.WriteLine("Funcionario: " + funcionario.Nome); 
            funcionario.Nome = "Fulano";
            System.Console.WriteLine("Funcionario: " + funcionario.Nome);
            // funcionario.Cargo = "Gerente"; -- atributo protegido 
            // Instanciar o objeto gerente
            Gerente gerente = new Gerente("Maria", 5000);
            System.Console.WriteLine("Gerente: " + gerente.Nome);
            gerente.Nome = "Anna";
            System.Console.WriteLine("Gerente: " + gerente.Nome);
            gerente.AtualizarGerente("Diretor");

        //    gerente.CalcularImpostoGerente() -- ,etodo privado
        }
    }
}