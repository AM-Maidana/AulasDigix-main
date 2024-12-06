using System;
using System.Security.Cryptography.X509Certificates;

namespace Name
{
    class Limpeza
    {
        public string NomeLimp;
        public int PrecoLimp;

        public int QtdeLimp;

        public Limpeza()
        {
            NomeLimp = "Produto de limpeza";
            PrecoLimp = 10;
            QtdeLimp = 4;
        }
        public Limpeza (string nomeLimp, int precoLimp, int qtdeLimp)
        {
            this.NomeLimp = nomeLimp;
            this.PrecoLimp = precoLimp;
            this.QtdeLimp = qtdeLimp;
        }

        public int CalcularL()
        {
            return (int)PrecoLimp * QtdeLimp;
        }
    }
}
