using System;

namespace Desafio5
{
    public class Address
    {
        public string Street { get; }
        public int Number { get; }
        public string CEP { get; }
        public string City { get; }

        public Address(string street, int number, string cep, string city)
        {
            Street = street;
            Number = number;
            CEP = cep;
            City = city;
        }
    }
}