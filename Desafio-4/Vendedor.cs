using System;
using System.Runtime.CompilerServices;
namespace Desafio4
{
    public class Vendedor : Empregado
      {
        private bool v;

        public RegiaoAtuacao Regiao { get; set; }
        public double Comissao { get; set; }

        public Vendedor(string nome, double salario, TipoEmpregado cargo, RegiaoAtuacao regiao, double salarioMinimo, bool statusLicenca, int licencaPremioRecebidas, double comissao): base (nome, salario, cargo, salarioMinimo, statusLicenca, licencaPremioRecebidas)
        {
            Regiao = regiao;
            Comissao = comissao;
        }


        public double GetSalario()
         {
            return Salario + Comissao;
         }
    }
}