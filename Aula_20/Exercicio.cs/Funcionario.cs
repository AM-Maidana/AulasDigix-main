using System;
using System.Runtime.CompilerServices;
namespace Aula_20_Exercicio
{
  public class Funcionario
  {
    public Endereco Endereco {get; set;}
    public string Nome {get; set;}
    public DateTime DataNascimento {get; set;}
    public string Cpf {get; set;}
    public float Salario {get; set;}

    public Funcionario(Endereco endereco, string nome, DateTime dataNascimento, string cpf, float salario)
    {
        Endereco = endereco;
        Nome = nome;
        DataNascimento = dataNascimento;
        Cpf = cpf;
        Salario = salario;
    }

    public void ExibirInformacoes()
    {
        System.Console.WriteLine($"Nome do funcionário: {Nome}");
        System.Console.WriteLine($"Data de nascimento: {DataNascimento}");
        System.Console.WriteLine($"CPF: {Cpf}");
        System.Console.WriteLine($"Salario: {Salario}");
        
    }


  }
}