using System;
namespace Aula_20_Exercicio
{
    public class Cidade
    {
        
        public Estado Estado {get; set;}
        private string Nome;

        public Cidade(Estado estado, string nome)
        {
            Estado = estado;
            Nome = nome;
        }
    }
}