using System;
namespace Desafio5
{
    public class CurrentAccount : Account
    {
        protected Customer Customer { get; set; }
        protected int CCNumber;
        protected double CCBalance;

        public CurrentAccount(Customer customer, int accountNumber, double balance, int ccNumber, double ccBalance) : base(customer, accountNumber, balance)
        {
            Customer = customer;
            CCNumber = ccNumber;
            CCBalance = ccBalance;
        }

        public void double Withdraw()
        {
            System.Console.WriteLine("Digite o valor que deseja sacar: ");
            int CCWithdraw = int.Parse(Console.ReadLine());
            if (CCWithdraw > CCBalance)
            {
                throw new BankExcepction("Saldo insuficiente!");
            }
            else
            {
                CCBalance -= CCWithdraw;
                System.Console.WriteLine($"Saque realizado com sucesso! Saldo atual: {CCBalance}");
            }
            return CCBalance;
        }

    }
}