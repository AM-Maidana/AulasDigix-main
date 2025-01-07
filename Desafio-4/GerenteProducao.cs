using System;
using System.Runtime.CompilerServices;
namespace Desafio4
{
    public class GerenteProducao : Empregado, IGerente
    {
        public GerenteProducao(string nome, double salario, TipoEmpregado cargo, double salarioMinimo, bool statusLicenca, int licencaPremioRecebidas) : base(nome, salario, cargo, salarioMinimo, statusLicenca, licencaPremioRecebidas)
        {
            Nome = nome;
            Salario = salario;
            Cargo = cargo;
            SalarioMinimo = salarioMinimo;
            StatusLicenca = false;
            LicencaPremioRecebidas = licencaPremioRecebidas;

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

        public bool ConcedeAumentoEmpregado(Empregado empregado)
        {
            if (empregado.GetSalario() <= 600.00)
            {
                System.Console.WriteLine("Aumento concedido");
                return true;
            }
            else
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

        public bool ConcedeAumentoVendedor(Vendedor vendedor)
        {
            if (vendedor.GetSalario() <= 2500)
            {
                Console.WriteLine("Aumento concedido ao vendedor");
                return true;
            }
            else
            {
                Console.WriteLine("Aumento Negado ao vendedor");
                return false;
            }
        }
        public double getSalario()
        {
            return Salario;
        }

    }
}
