using System;
using System.Security.Principal;
namespace Desafio5
{
    public class ATM : Address
    {
        public WithdrawValue WithdrawValue { get; set; }
        public Customer CurrentCustomer { get; private set; }

        public ATM(Address address) : base(address.Street, address.Number, address.CEP, address.City)
        {
        }
        public bool Identifies(Customer customer, string pin)
        {
            try
            {
                if (customer.VerifyPassword(pin))
                {
                    CurrentCustomer = customer;
                    Console.WriteLine("Login realizado com sucesso!");
                    return true;
                }
            }
            catch (BankExcepction ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            throw new BankExcepction("Login inválido. Tente novamente.");
        }

   
        public void ManagedBy(AccountMovement accountMovement)
        {
            if (CurrentCustomer == null)
            {
                throw new BankExcepction("Nenhum cliente autenticado. Por favor, faça login primeiro.");
            }

            Console.WriteLine("Selecione uma operação:");
            Console.WriteLine("1 - Depósito");
            Console.WriteLine("2 - Saque");
            Console.WriteLine("3 - Criar Transação");
            Console.WriteLine("4 - Imprimir Transações");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    accountMovement.Deposit();
                    break;
                case 2:
                    accountMovement.Withdraw();
                    break;
                case 3:
                    accountMovement.CreateTransaction();
                    break;
                case 4:
                    Console.WriteLine("Imprima as transações (exemplo).");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            
        }
    }
}