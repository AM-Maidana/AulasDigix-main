using System;
namespace Desafio5
{
    public class Bank : Address
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public List<ATM> ATMs { get; private set; }
        public List<Account> Accounts { get; private set; }
        private Random random = new Random();

        public Bank(int code, string name, Address address)
            : base(address.Street, address.Number, address.CEP, address.City)
        {
            Code = code;
            Name = name;
            Accounts = new List<Account>();
            ATMs = new List<ATM>();
        }

        public Bank()
        {
        }


        public void Manage()
        {
            Console.WriteLine($"Bem-vindo ao banco {Name}! O que gostaria de realizar?");
            Console.WriteLine("1 - Gerenciar");
            Console.WriteLine("2 - Monitorar");
            Console.WriteLine("3 - Sair");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    ManageBanking();
                    break;
                case 2:
                    MonitorBanking();
                    break;
                default:
                    Console.WriteLine("Opção inválida! Saindo do banco.");
                    break;
            }
        }

        private void ManageBanking()
        {
            Console.WriteLine("O que gostaria de fazer?");
            Console.WriteLine("1 - Abrir uma conta");
            Console.WriteLine("2 - Listar contas");
            Console.WriteLine("3 - Buscar uma conta");
            Console.WriteLine("4 - Listar caixas eletrônicos");
            Console.WriteLine("5 - Sair");

            int op2 = int.Parse(Console.ReadLine());

            switch (op2)
            {
                case 1:
                    CreateAccount();
                    break;
                case 2:
                    ListAccounts();
                    break;
                case 3:
                    SearchAccount();
                    break;
                case 4:
                    ListATMs();
                    break;
                case 5:
                    Console.WriteLine("Saindo para o menu principal.");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }

        private void CreateAccount()
        {
            Console.WriteLine("Digite o nome do cliente:");
            string name = Console.ReadLine();

            Console.WriteLine("Digite o endereço do cliente (formato: Rua, Número, CEP, Cidade):");
            string[] addressData = Console.ReadLine().Split(", ");

            Console.WriteLine("Digite a data de nascimento do cliente (formato: dd/MM/yyyy):");
            DateTime dob = DateTime.Parse(Console.ReadLine());

            string cardNumber = random.Next(1000, 9999).ToString();
            Console.WriteLine($"Número do cartão: {cardNumber}");

            int accountNumber = random.Next(1000, 9999);
            Console.WriteLine($"Número da conta: {accountNumber}");

            Console.WriteLine("Saldo inicial: R$ 0,00");

            Address customerAddress = new Address
            {
                Street = addressData[0],
                Number = int.Parse(addressData[1]),
                CEP = int.Parse(addressData[2]),
                City = addressData[3]
            };

          
            Account newAccount = new Account
            {
                Number = accountNumber,
                Balance = 0
            };

            Accounts.Add(newAccount);
            Console.WriteLine("Conta criada com sucesso!");
        }

        private void ListAccounts()
        {
            if (Accounts.Count == 0)
            {
                Console.WriteLine("Nenhuma conta encontrada.");
                return;
            }

            Console.WriteLine("Contas registradas:");
            foreach (var account in Accounts)
            {
                Console.WriteLine($"Conta: {account.Number}, Saldo: R$ {account.Balance}");
            }
        }

        private void SearchAccount()
        {
            Console.WriteLine("Digite o número da conta que deseja buscar:");
            int accountNumber = int.Parse(Console.ReadLine());

            var account = Accounts.Find(a => a.Number == accountNumber);
            if (account != null)
            {
                Console.WriteLine($"Conta encontrada: Número {account.Number}, Saldo: R$ {account.Balance}");
            }
            else
            {
                Console.WriteLine("Conta não encontrada.");
            }
        }

        private void ListATMs()
        {
            if (ATMs.Count == 0)
            {
                Console.WriteLine("Nenhum caixa eletrônico encontrado.");
                return;
            }

            Console.WriteLine("Caixas eletrônicos disponíveis:");
            foreach (var atm in ATMs)
            {
                Console.WriteLine($"Caixa eletrônico localizado em: {atm.Address.Street}, {atm.Address.City}");
            }
        }

        private void MonitorBanking()
        {
            Console.WriteLine($"O banco possui {ATMs.Count} caixas eletrônicos disponíveis.");
        }

    }
}