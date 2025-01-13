using System;

namespace Desafio5
{
    public class Transaction
    {
        public Guid Id { get; }
        public DateTime Date { get; }
        public TransactionsType Type { get; }
        public double Amount { get; }
        public double Balance { get; }

        public Transaction(Guid id, DateTime date, TransactionsType type, double amount, double balance)
        {
            Id = id;
            Date = date;
            Type = type;
            Amount = amount;
            Balance = balance;
        }
    }
}