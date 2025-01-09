using System;
using System.IO;
using System.Runtime.CompilerServices;
namespace Desafio5
{
    public class Customer : Address
    {
       

        protected string Name { get; set; }
        public Address Address { get; set; }
        protected DateTime Dob { get; set;}
        protected Int64 CardNumber { get; set; }
        protected string Pin { get; set; } 

       public Customer(string name, Address address, DateTime dob, Int64 cardNumber, string pin = "0000") 
            : base(address.Street, address.Number, address.CEP, address.City)
        {
            Name = name;
            Address = address;
            Dob = dob;
            CardNumber = cardNumber;
            Pin = pin;
        }

        public void VerifyPassword(int pin)
        {
            if (pin != pin)
            {
                throw new BankExcepction("Senha inválida");

            } else
            {
                System.Console.WriteLine("Senha corre
                ta!" + $"\nBem Vindo {Name}");
            }
        }
    
    }
}