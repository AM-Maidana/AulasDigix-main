using System;
using System.Security.Cryptography;
namespace Aula16_parte2
{
    class Gerente : Funcionario //: é o extends
    {
        public string setor;
        public Gerente(string nome, string cpf, double salario, string setor) : base(nome, cpf, salario)
        {
            this.setor = setor;
        }
        public override double GetBonificacao() //override é usado para sobrrescrever o metodod
        {
            return Salario * 0.15;
        }
        public override void ImprimirDados()
        {
            System.Console.WriteLine("Nome: " + Nome);
            System.Console.WriteLine("CPF: " + CPF);
            System.Console.WriteLine("Salario: " + Salario);
            System.Console.WriteLine("Bonificação: " + GetBonificacao());
        }
        public void GerirEquipes()
        {
            System.Console.WriteLine("Cuidando das equipes");
        }
    }
}