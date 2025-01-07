using System;
using Desafio4;

namespace Desafio4
{
    public class Empregado : Pessoa
    {
        protected double Salario {get; set;}
        protected TipoEmpregado Cargo {get; set;}
        protected double SalarioMinimo {get; set;} = 240.00;
        public bool StatusLicenca {get; set;}
        protected int LicencaPremioRecebidas {get; set;}

        public Empregado(string nome, double salario, TipoEmpregado cargo, double salarioMinimo, bool statusLicenca, int licencaPremioRecebidas) : base (nome)
        {
            Nome = nome;
            Salario = salario;
            Cargo = cargo;
            SalarioMinimo = salarioMinimo;
            StatusLicenca = false;
            LicencaPremioRecebidas = licencaPremioRecebidas;
        }
        public string GetNome()
        {
            return Nome;
        }
        public double GetSalario()
        {
            return Salario;
        }

        public TipoEmpregado GetCargo()
        {
            return Cargo;
        }
    }
}