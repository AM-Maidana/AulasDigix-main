using System;
using System.Runtime.CompilerServices;
namespace Desafio5
{
    public class Address
    {
        public string Street { get; set; }
        public int Number { get; set; }
        public int CEP { get; set; }
        public string City { get; set; }
        

        public Address(string street, int number, int cep, string city)
        {
            Street = street;
            Number = number;
            CEP = cep;
            City = city;
            
        }
    }
}