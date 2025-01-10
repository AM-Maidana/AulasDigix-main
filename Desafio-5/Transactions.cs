using System;
namespace Desafio5
{
    public class Transactions
    {
        public int Id;
        public DateTime Date;
        public TransactionsType Transfer;
        public double Value;

        public Transactions(int id, DateTime date, TransactionsType type, double value)
        {
            Id = id;
            Date = date;
            Transfer = type;
            Value = value;
        }
        public int GetId()
        {
            return Id;
        }
        public void SetId(int id)
        {
            Id = id;
        }
        public DateTime GetDate()
        {
            return Date;
        }
        public void SetDate(DateTime date)
        {
            Date = date;
        }
        public TransactionsType GetTransfer()
        {
            return Transfer;
        }
        public void SetTransfer(TransactionsType type)
        {
            Transfer = type;
        }
        public double GetValue()
        {
            return Value;
        }
        public void SetValue(double value)
        {
            Value = value;
        }
    }
}