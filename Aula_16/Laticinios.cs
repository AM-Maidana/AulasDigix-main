using System;


namespace Aula16_2
{
    class Laticinios
    {
        public string NomeLat;
        public int PrecoLat;

        public int QtdeLat;

        public Laticinios()
        {
            NomeLat = "Produto de limpeza";
            PrecoLat = 12;
            QtdeLat = 4;
        }
        public Laticinios (string nomeLat, int precoLat, int qtdeLat)
        {
            this.NomeLat = nomeLat;
            this.PrecoLat = precoLat;
            this.QtdeLat = qtdeLat;
        }

        public int CalcularLat()
        {
            return (int)PrecoLat * QtdeLat;
        }
    }
}
