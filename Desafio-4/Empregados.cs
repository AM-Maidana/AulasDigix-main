using System;
using System.Collections.Generic;

namespace Desafio4
{
    public class Empregados
    {
        private const int NumMax = 50;
        private List<Empregado> empregados = new List<Empregado>();
        private int NumEmpregados { get { return empregados.Count; } }

        public void Inserir()
        {
            if (NumEmpregados < NumMax)
            {
                Console.Write("Digite o nome do funcionário: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o salário: ");
                double salario = double.Parse(Console.ReadLine());

                Console.Write("Digite o cargo dele (Vendedor, GerenteVendas, GerenteProducao): ");
                string cargoEmp = Console.ReadLine();
                TipoEmpregado cargo;

                if (!Enum.TryParse(cargoEmp, out cargo))
                {
                    Console.WriteLine("Cargo inválido!");
                    return;
                }

                Console.Write("Salário mínimo base (240.00): ");
                double salarioMinimo = double.Parse(Console.ReadLine());

                Console.Write("Licenças recebidas: ");
                int licencas = int.Parse(Console.ReadLine());

                bool statusLicenca = false;

                if (cargo == TipoEmpregado.Vendedor)
                {
                    Console.WriteLine("Digite a região de atuação (Norte, Sul, Leste, Oeste): ");
                    string regiaoVendedor = Console.ReadLine();
                    RegiaoAtuacao regiao;

                    if (!Enum.TryParse(regiaoVendedor, out regiao))
                    {
                        Console.WriteLine("Região inválida!");
                        return;
                    }

                    Console.Write("Comissão do vendedor: ");
                    double comissao = double.Parse(Console.ReadLine());

                    Vendedor vendedor = new Vendedor(nome, salario, cargo, regiao, salarioMinimo, statusLicenca, licencas, comissao);
                    empregados.Add(vendedor);
                    Console.WriteLine($"Vendedor {nome} da região {regiao} adicionado com sucesso.");
                }
                else
                {
                    Empregado empregado = new Empregado(nome, salario, cargo, salarioMinimo, statusLicenca, licencas);
                    empregados.Add(empregado);
                    Console.WriteLine($"Empregado {nome} do cargo {cargo} adicionado com sucesso.");
                }
            }
            else
            {
                Console.WriteLine("Limite de empregados atingido.");
            }
        }

        public void Imprimir()
        {
            if (NumEmpregados == 0)
            {
                Console.WriteLine("Nenhum empregado cadastrado.");
            }
            else
            {
                foreach (var emp in empregados)
                {
                    if (emp is Vendedor vendedor)
                    {
                        Console.WriteLine($"Vendedor: {vendedor.GetNome()}, Salário: {vendedor.GetSalario()}, Região: {vendedor.Regiao}, Comissão: {vendedor.Comissao}");
                    }
                    else
                    {
                        Console.WriteLine($"Empregado: {emp.GetNome()}, Salário: {emp.GetSalario()}, Cargo: {emp.GetCargo()}");
                    }
                }
            }
        }

        public List<Empregado> GetEmpregados()
        {
            return empregados;
        }

        public double FolhaDePagamento(Empregado empregado)
        {
         
            Console.Clear();

            Console.WriteLine("Dados da folha de pagamento dos empregados");
            Console.WriteLine($"Funcionario: {empregado.GetNome()}");
            Console.WriteLine($"Cargo: {empregado.GetCargo()}");
            Console.WriteLine($"Salario Final: {empregado.GetSalario()}");

            
            return empregado.GetSalario();
        }
    }
}
