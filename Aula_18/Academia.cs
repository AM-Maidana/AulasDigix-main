using System;
namespace Aula_18
{
    public class Academia
    {
        public string Nome {get; set;}

        private double Mensalidade {get; set;} // Classes está com erro

        //construtor padrão
        public Academia ()
        {

        }
        public Academia(string nome, double mensalidade)
        {
            Nome = nome;
            Mensalidade = mensalidade;
        }

    }
}