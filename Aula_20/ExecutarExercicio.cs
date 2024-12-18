using System;
using System.Data;
namespace Aula_20_Exercicio
{
    public class ExecutarExercicio
    {
        static void Main(string[] args)
        {
            Estado estado = new Estado("Mato Grosso do SuL", "MS");
            Cidade cidade = new Cidade(estado, "Campo Grande");
            Endereco endereco = new Endereco(cidade, "R. Da Paz", 123, "Bairro do Céu", "79.080-120");
            Endereco endereco1 = new Endereco(cidade, "R. Tal", 456, "Bairro DaOnde", "70-090-120");
            Endereco endereco2 = new Endereco(cidade, "R. Qualquer", 789, "Bairro Aleatorio", "79.040-120");
            EquipeVenda equipeVenda = new EquipeVenda("Peças");

            System.Console.WriteLine("---Funcionario---");
            Funcionario funcionario = new Funcionario(endereco, "Luiz Victor", DateTime.Parse("01/02/2003"), "123.456.789.01", 3.00f);
            funcionario.ExibirInformacoes();

            System.Console.WriteLine("---Vendedor---");

            Vendedor vendedor = new Vendedor("João", DateTime.Parse("12/10/2000"), "987.654.321.10", endereco1, equipeVenda, 4.00f);
            System.Console.WriteLine($"Nome do vendedor: {vendedor.Nome}");
            System.Console.WriteLine($"Data de nascimento: {vendedor.DataNascimento}");
            System.Console.WriteLine($"CPF: {vendedor.Cpf}");
            System.Console.WriteLine($"Salario: {vendedor.SalarioVendedor(4.00f)}");



            System.Console.WriteLine("---Gerente---");

            Gerente gerente = new Gerente(endereco2, "Cleitin", DateTime.Parse("18/07/1988"), "852.963.741-89", 6.00f);
            System.Console.WriteLine($"Nome do gerente: {gerente.Nome}");
            System.Console.WriteLine($"Data de nascimento: {gerente.DataNascimento}");
            System.Console.WriteLine($"CPF: {gerente.Cpf}");
            System.Console.WriteLine($"Salario: {gerente.SalarioGerente(6.00f)}");

        }
    }
}