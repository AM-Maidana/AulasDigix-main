using System;
using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;
namespace Aula17_1
{
    public class Assalariado : Empregado
    {
        public double salario;

        public Assalariado(string nome, string sobrenome, string cpf, double salario) : base(nome, sobrenome, cpf)
        {
            this.salario = salario;
        }

        public override double Vencimento()
        {
            double inss =  0.11;
            double ir = 0.275;
            double desconto = salario * inss + salario * ir;
            return desconto;
        }

        public override void MostrarDados()
        {
            base.MostrarDados();
            Console.WriteLine("Salário: " + salario);
        }
    }
}