using System;
using System.Runtime.CompilerServices;
namespace Ex1
{
    public class Client
    {
        public string Nome {get; set;}
        public string Email {get; set;}
        public DateTime DataNascimento {get; set;}

        public Client(string nome, string email, DateTime dataNascimento)
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
        }
    }
}