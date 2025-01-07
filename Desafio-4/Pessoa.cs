using System;
namespace Desafio4
{
    public class Pessoa
    {
        protected string Nome { get; set; }

        public Pessoa()
        {

        }
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public string GetNome()
        {
            return Nome;
        }
    }
}