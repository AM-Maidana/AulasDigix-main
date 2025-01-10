using System;
namespace Desafio5
{
    public class SavingAccount : Account
    {
        protected Customer Customer { get; set; }
        protected int CPNumber;
        protected double CPBalance;

        public SavingAccount(Customer customer, int accountNumber, double balance, int cpNumber, double cpBalance) : base(customer, accountNumber, balance)
        {
            Customer = customer;
            CPNumber = cpNumber;
            CPBalance = cpBalance;
        }

    }
}