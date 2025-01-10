using System;
using System.IO;
using System.Runtime.CompilerServices;
namespace Desafio5
{
    public class Customer : Address
    {
        protected string Name;
        public Address Address;
        protected DateTime Dob;
        protected int CardNumber;
        protected string Pin;

        public Customer(string name, Address address, DateTime dob, int cardNumber, string pin = "0000")
             : base(address.Street, address.Number, address.CEP, address.City)
        {
            Name = name;
            Address = address;
            Dob = dob;
            CardNumber = cardNumber;
            Pin = pin;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public Address GetAddress()
        {
            return Address;
        }
        public void SetAddress(Address address)
        {
            Address = address;
        }
        public DateTime GetDob()
        {
            return Dob;
        }
        public void SetDob(DateTime dob)
        {
            Dob = dob;
        }
        public int GetCardNumber()
        {
            return CardNumber;
        }
        public void SetCardNumber(int cardNumber)
        {
            CardNumber = cardNumber;
        }
        public string GetPin()
        {
            return Pin;
        }
        public void SetPin(string pin)
        {
            Pin = pin;
        }

        public void VerifyPassword(string pin)
        {
            if (pin != Pin)
            {
                throw new BankExcepction("Senha inválida");
            }
            else
            {
                Console.WriteLine("Senha correta! Bem Vindo " + Name);
            }
        }

    }
}