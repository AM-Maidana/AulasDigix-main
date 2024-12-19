using System;
namespace Uml
{
    public class Usuario
    {
        private string Nome;
        private string Cpf;

        public Usuario(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public string GetCpf()
        {
            return Cpf;
        }

        public void SetCpf(string cpf)
        {
            Cpf = cpf;
        }

    }
}