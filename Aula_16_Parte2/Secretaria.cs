using System;
using System.Security.Cryptography;
namespace Aula16_parte2
{
    class Secretaria : Funcionario
    {
        public string ramal;
        public Secretaria(string nome, string cpf, double salario, string ramal) : base(nome, cpf, salario)
        {
            this.ramal = ramal;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.05;
        }
        public override void ImprimirDados()
        {
            System.Console.WriteLine("Nome: " + Nome);
            System.Console.WriteLine("CPF: " + CPF);
            System.Console.WriteLine("Salario: " + Salario);
            System.Console.WriteLine("Bonificação: " + GetBonificacao());
        }
        public void AtenderTelefone()
        {
            System.Console.WriteLine("Atendendo o telefone");
        }
    }
}