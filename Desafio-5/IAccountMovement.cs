using System;
namespace Desafio5
{
    public interface IAccountMovement
    {
        void Deposit();
        void Withdraw();
        void CreateTransaction();
        void PrintTransaction();
    }
}