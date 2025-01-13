using System;
namespace Desafio5
{
    public class BankException : Exception
{
    public BankException(string message) : base(message)
    {
    }   
}
}