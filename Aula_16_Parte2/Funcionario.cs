﻿using System;
namespace Aula16_parte2
{
    class Funcionario
    {
        public string Nome;
        public string CPF;
        public double Salario;

        public Funcionario(string nome, string cpf, double salario)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Salario = salario;
        }
        public virtual double GetBonificacao() // virtual permite que a classe filha possa sibeescrever o metodo sem alterar no pai
        {
            return Salario * 0.10;
        }
        public virtual void ImprimirDados()
        {
            System.Console.WriteLine("Nome: " + Nome);
            System.Console.WriteLine("CPF: " + CPF);
            System.Console.WriteLine("Salario: " + Salario);
            System.Console.WriteLine("Bonificação: " + GetBonificacao());
        }
    }
}