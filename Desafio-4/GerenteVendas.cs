using System;
using System.Net;
namespace Desafio4
{
    public class GerenteVendas : Vendedor, IGerente
    {
        public GerenteVendas(string nome, double salario, TipoEmpregado cargo, RegiaoAtuacao regiao, double salarioMinimo, bool statusLicenca, int licencaPremioRecebidas, double comissao) : base(nome, salario, cargo, regiao, salarioMinimo, statusLicenca, licencaPremioRecebidas, comissao)
        {
            Nome = nome;
            Salario = salario;
            Cargo = cargo;
            Regiao = regiao;
            SalarioMinimo = salarioMinimo;
            StatusLicenca = statusLicenca;
            LicencaPremioRecebidas = licencaPremioRecebidas;
            Comissao = comissao;
        }
        public void Autorizar()
        {
            Console.WriteLine("Autorização concedida");
        }

        public void VerStatusLicenca(Empregado empregado)
        {
            bool statusLicenca = AutorizarLicenca(empregado);
            System.Console.WriteLine($"Autorização: {statusLicenca}");
        }

        public bool ConcedeAumentoVendedor(Vendedor vendedor)
        {
            if(vendedor.GetSalario() <= 2500)
            {
                System.Console.WriteLine("Aumento concedido");
                return true;
            } else
            {
                System.Console.WriteLine("Aumento Negado");
                return false;
            }
        }

        public bool AutorizarLicenca(Empregado empregado)
        {
            
            if (empregado.StatusLicenca)
            {
                Console.WriteLine($"{empregado.GetNome()} já está de licença.");
                return false;
            }
            else
            {
                empregado.StatusLicenca = true;
                Console.WriteLine($"Licença autorizada para {empregado.GetNome()}.");
                return true;
            }
        }

        public bool ConcedeAumentoEmpregado(Empregado empregado)
        {
            if (empregado.GetCargo() == TipoEmpregado.Vendedor)
            {
                Vendedor vendedor = (Vendedor)empregado;
                return ConcedeAumentoVendedor(vendedor);
            } else
            {
                System.Console.WriteLine("Aumento não concedido, pois o funcionário não é um vendedor");
                return false;
            }
        }
        public double getSalario()
        {
            return Salario + Comissao;
        }
    }
}
