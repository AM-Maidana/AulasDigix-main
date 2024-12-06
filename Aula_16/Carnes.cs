using System;
using System.Runtime.CompilerServices;


namespace Name
{
    // public record Carnes(string NomeCarnes, int PrecoCarnes, int QtdeCarnes);
    

    //     public string NomeCarnes = NomeCarnes;
    //     public int PrecoCarnes = PrecoCarnes;
    //     public int QtdeCarnes = QtdeCarnes;
    
    class Carnes
    {
        public string NomeCarnes;
        public int PrecoCarnes;

        public int QtdeCarnes;

        public Carnes()
        {
            NomeCarnes = null;
            PrecoCarnes = 0;
            QtdeCarnes = 4;
        }
        public Carnes (string NomeCarnes, int PrecoCarnes, int QtdeCarnes)
        {
            this.NomeCarnes = NomeCarnes;
            this.PrecoCarnes = PrecoCarnes;
            this.QtdeCarnes = QtdeCarnes;
        }

        public int CalcularC()
        {
            return (int)PrecoCarnes * QtdeCarnes;
        }
    }
}
