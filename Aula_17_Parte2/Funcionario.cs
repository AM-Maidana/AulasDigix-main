using System;
namespace Aula17_2
{
    public class Funcionario
    {
        // atriuto publico: acessivel de qualquer lugar
        public string Nome;
        // acesso apenas dentro da classe
        private double Salario;
        // protegido: acessivel apenas dentro da classe e subclasses
       protected string Cargo;

       public Funcionario(string nome, double salario, string cargo)
       {
        Nome = nome;
        Salario = salario;
        Cargo = cargo;
       }

       public void Dados()
       {
        System.Console.WriteLine($"Nome: {Nome}");
        System.Console.WriteLine($"Salario: {Salario}"); // Acessando atributo privado
        System.Console.WriteLine($"Cargo: {Cargo}");

       }

       protected void AtualizarCargo(string novoCargo)
       {
        Cargo = novoCargo;
        System.Console.WriteLine($"Promoção de cargo: {novoCargo}");
       }

       private double CalcularImposto()
       {
        return Salario * 0.1;
       }
    }
}