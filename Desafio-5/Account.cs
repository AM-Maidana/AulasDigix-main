using System;
using System.Collections.Generic;

namespace Desafio5
{
    public class Account
    {
        public int Number { get; }
        public double Balance { get; private set; }
        private List<Transaction> transactions = new List<Transaction>();

        public Account(int number, double initialBalance)
        {
            Number = number;
            Balance = initialBalance;
        }

        public virtual void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                RecordTransaction(TransactionsType.Withdraw, amount);
            }
            else
            {
                throw new BankExcepction("Saldo insuficiente.");
            }
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            RecordTransaction(TransactionsType.Deposit, amount);
        }

        private void RecordTransaction(TransactionsType type, double amount)
        {
            transactions.Add(new Transaction(Guid.NewGuid(), DateTime.Now, type, amount, Balance));
        }

        public void PrintTransactions()
        {
            foreach (var transaction in transactions)
            {
                Console.WriteLine($"Data: {transaction.Date}, Tipo: {transaction.Type}, Valor: {transaction.Amount}, Saldo: {transaction.Balance}");
            }
        }
    }
}