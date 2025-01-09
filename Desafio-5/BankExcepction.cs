using System;
namespace Desafio5
{
    public class BankExcepction : Exception
{
    public BankExcepction(string message) : base(message)
    {
    }   
}
}