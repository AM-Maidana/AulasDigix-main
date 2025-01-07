using System;

namespace Desafio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Empregados empregados = new Empregados();
            GerenteProducao gerenteProducao = new GerenteProducao("Gerente Produção", 3000, TipoEmpregado.GerenteProducao, 240.00, false, 0);
            int opcao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("MENU:");
                Console.WriteLine("1 - Inserir Empregado");
                Console.WriteLine("2 - Listar Empregados");
                Console.WriteLine("3 - Exibir Folha de Pagamento");
                Console.WriteLine("4 - Autorizar Licença");
                Console.WriteLine("5 - Ver Status da Licença");
                Console.WriteLine("6 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        empregados.Inserir();
                        break;

                    case 2:
                        empregados.Imprimir();
                        break;

                    case 3:
                        Console.WriteLine("Exibindo a folha de pagamento de todos os empregados:");

                        foreach (var emp in empregados.GetEmpregados())
                        {
                            empregados.FolhaDePagamento(emp);
                        }

                        break;

                    case 4:
                        Console.WriteLine("Escolha um empregado para autorizar a licença: -- faltar fazer");
                       
                        break;

                    case 5:
                        Console.WriteLine("Escolha um empregado para ver o status da licença: -- falta fazer");
                        
                        break;

                    case 6:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            } while (opcao != 6);
        }
    }
}
