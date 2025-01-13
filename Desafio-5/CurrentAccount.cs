using System;

namespace Desafio5
{
    public class CurrentAccount : Account
    {
        public CurrentAccount(int number, double initialBalance) : base(number, initialBalance)
        {
        }

        public override void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                base.Withdraw(amount);
            }
            else
            {
                throw new BankException("Saldo insuficiente.");
            }
        }
    }
}