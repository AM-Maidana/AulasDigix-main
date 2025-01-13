using System;
namespace Desafio5
{
    public class SavingAccount : Account
    {
        protected double Balance = 0.0;

        public SavingAccount(int number, double initialBalance) : base(number, initialBalance)
        {
        }
    }
}