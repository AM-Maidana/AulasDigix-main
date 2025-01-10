using System;
namespace Desafio5
{
    public class Bank : Address
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public List<ATM> ATMs { get; set; }
        public List<Account> Accounts { get; set; }


        public Bank(int code, string name, Address address) : base(address.Street, address.Number, address.CEP, address.City)
        {
            Code = code;
            Name = name;
            Address = address;
        }

        public void Manage()
        {
            System.Console.WriteLine($"Bem vindo ao banco {Name}! O que gostaria de realizar?");
            System.Console.WriteLine("\n1 - Gerenciar");
            System.Console.WriteLine("\n2 - Monitorar");
            System.Console.WriteLine("\n3 - Sair");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                System.Console.WriteLine("O que gostaria de fazer?");
                System.Console.WriteLine("1 - Abrir uma conta");
                System.Console.WriteLine("2 - Listar contas");
                System.Console.WriteLine("3 - Buscar uma conta");
                System.Console.WriteLine("4 - Listar caixas eletrônicos");
                System.Console.WriteLine("5 - Sair");

                int op2 = int.Parse(Console.ReadLine());
                if (op2 == 1)
                {
                    
                }


            }
        }

    }
}