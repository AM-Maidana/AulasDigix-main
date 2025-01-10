using System;
using System.Security.Principal;
namespace Desafio5
{
    public class ATM : Address, IAccountMovement
    {
        public Address Address { get; set; }
        public WithdrawValue WithdrawValue { get; set; }
        

        public ATM(string street, int number, int cep, string city, Address address, WithdrawValue withdrawValue) : base(street, number, cep, city)
        {
            Address = address;
            WithdrawValue = withdrawValue;
        }

        public void Identifies (Account number)
        {
            System.Console.WriteLine("Digite o número da conta:");
            number = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite seu pin");
            
        }



        public void Deposit(int valor)
        {
            System.Console.WriteLine("Digite o valor que deseja depositar: ");
            valor = int.Parse(Console.ReadLine());
            if (valor == 0 && valor < 0)
            {
                throw new BankExcepction("Valor inválido!");
            }
            else
            {
                System.Console.WriteLine($"Depósito no valor de R${valor} realizado com sucesso!");
                return saldo += valor;
            }
            return ""
        }

        public void Withdraw()
        {
            throw new NotImplementedException();
        }

        public void CreateTransaction()
        {
            throw new NotImplementedException();
        }

        
    }
}