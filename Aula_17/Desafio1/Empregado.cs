using System;
using System.Diagnostics.Contracts;
namespace Aula17_1
{
     public abstract class Empregado
    {
        public string Nome;
        public string Sobrenome;
        public string CPF;

        public Empregado(string nome, string sobrenome, string cpf)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            CPF = cpf;
        }

        public abstract double Vencimento();

        public virtual void MostrarDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Sobrenome: " + Sobrenome);
            Console.WriteLine("CPF: " + CPF);
        }
    }
}