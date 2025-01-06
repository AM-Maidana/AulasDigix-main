using System;
using System.Diagnostics.Tracing;
namespace Exercicio1
{
    public abstract class Taxonomia
    {
        protected string Reino;
        protected string Filo;
        protected string Classe;
        protected string Ordem;
        protected string Familia;
        protected string Genero;
        protected string Especie;

        public Taxonimia(string reino, string filo, string classe, string ordem, string familia, string genero, string especie)
        {
            Reino = reino;
            Filo = filo;
            Classe = classe;
            Ordem = ordem;
            Familia = familia;
            Genero = genero;
            Especie =  especie;
        }

    }
}