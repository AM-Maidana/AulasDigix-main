using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula24_Banco
{
    public class Customer
    {
        public string Nome { get; private set; }

        public Customer(string nome)
        {
            Nome = nome;
        }
    }
}