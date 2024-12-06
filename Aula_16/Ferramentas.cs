using System;


namespace Aula16_1
{
    class Ferramentas
    {
        public string NomeFerramentas;
        public int PrecoFerramentas;

        public int QtdeFerramentas;

        public Ferramentas()
        {
            NomeFerramentas = "Produto de limpeza";
            PrecoFerramentas = 5;
            QtdeFerramentas = 4;
        }
        public Ferramentas (string nomeFerramentas, int precoFerramentas, int qtdeFerramentas)
        {
            this.NomeFerramentas= nomeFerramentas;
            this.PrecoFerramentas = precoFerramentas;
            this.QtdeFerramentas = qtdeFerramentas;
        }

        public int CalcularF()
        {
            return (int)PrecoFerramentas * QtdeFerramentas;
        }
    }
}
