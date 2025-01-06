using System;
using System.ComponentModel.DataAnnotations;
namespace Exercicio1
{
    public class Animalia
    {
        public string Descricao;
        public Animalia (string descricao)
        {
            Descricao = descricao;
        }


        public virtual string ObterDescricao()
        {
            return "";
        }
    }
}