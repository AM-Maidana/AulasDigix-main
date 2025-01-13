using System;

namespace Desafio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicializando o banco
            Bank bank = new Bank();

            while (true)
            {
                Console.WriteLine("\n=== Sistema Bancário ===");
                Console.WriteLine("1 - Criar Conta");
                Console.WriteLine("2 - Listar Contas");
                Console.WriteLine("3 - Buscar Conta");
                Console.WriteLine("4 - Sair");
                Console.Write("Escolha uma opção: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Digite o número da conta: ");
                        int number = int.Parse(Console.ReadLine());

                        Console.Write("Digite o saldo inicial: ");
                        double initialBalance = double.Parse(Console.ReadLine());

                        bank.AddAccount(new Account(number, initialBalance));
                        break;

                    case 2:
                        bank.ListAccounts();
                        break;

                    case 3:
                        Console.Write("Digite o número da conta: ");
                        int searchNumber = int.Parse(Console.ReadLine());
                        var account = bank.SearchAccount(searchNumber);

                        if (account == null)
                        {
                            Console.WriteLine("Conta não encontrada.");
                            break;
                        }

                        Console.WriteLine("\n=== Gerenciar Conta ===");
                        Console.WriteLine("1 - Depositar");
                        Console.WriteLine("2 - Sacar");
                        Console.WriteLine("3 - Exibir Transações");
                        Console.Write("Escolha uma opção: ");
                        int accountChoice = int.Parse(Console.ReadLine());

                        try
                        {
                            switch (accountChoice)
                            {
                                case 1:
                                    Console.Write("Digite o valor do depósito: ");
                                    double deposit = double.Parse(Console.ReadLine());
                                    account.Deposit(deposit);
                                    break;

                                case 2:
                                    Console.Write("Digite o valor do saque: ");
                                    double withdraw = double.Parse(Console.ReadLine());
                                    account.Withdraw(withdraw);
                                    break;

                                case 3:
                                    account.PrintTransactions();
                                    break;

                                default:
                                    Console.WriteLine("Opção inválida.");
                                    break;
                            }
                        }
                        catch (BankException ex)
                        {
                            Console.WriteLine($"Erro: {ex.Message}");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Encerrando o sistema.");
                        return;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}