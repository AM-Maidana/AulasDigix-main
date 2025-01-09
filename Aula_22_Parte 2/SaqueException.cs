using System;
namespace Exercicio_Fixacao
{
    public class SaqueException : ApplicationException
    {
        public SaqueException(string message) : base(message)
        {
        }
    }
}
