/*using System;

namespace Aula15_OrientadaoObj
{
    class Cachorro
    {
        private string Nome;
        private string Raca;
        private int Idade;

        public void escrevaSaida()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Raça: " + Raca);
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("Idade em anos humanos: " + getIdadeHumano());
        }
        public int getIdadeHumano()
        {
            int idadeHumano = 0;
            if (Idade < 2)
            {
                idadeHumano = Idade * 11;
            }
            else
            {
                idadeHumano = 22 + ((Idade - 2) * 5);
            }
            return idadeHumano; 
        }

        static void Main(string[] args)
        {
            
                   tita.escrevaSaida();

            int idadeHumano = tita.getIdadeHumano();

            Console.WriteLine("A idade humana do " + tita.Nome + " é " + idadeHumano + " anos.");
        }
    }
}
*/