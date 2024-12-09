using System;
using System.Diagnostics.Contracts;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
namespace Aula17_1
{
    public class Comissionado : Empregado
    {
        public double totalVenda;
        public double taxaComissao;

        public Comissionado(string nome, string sobrenome, string cpf, double totalVenda, double taxaComissao) : base(nome, sobrenome, cpf)
        {
            this.totalVenda = totalVenda;
            this.taxaComissao = taxaComissao;
        }

        public override double Vencimento()
        {
            double inss =  0.11;
            double ir = 0.275;
            double desconto = totalVenda * taxaComissao * inss + totalVenda * taxaComissao * ir;
            return desconto;
        }

        public override void MostrarDados()
        {
            base.MostrarDados();
            Console.WriteLine("Total de Vendas: " + totalVenda);
            Console.WriteLine("Taxa de Comissão: " + taxaComissao);
        }

    }
}