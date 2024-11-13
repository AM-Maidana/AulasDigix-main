/* using System;

namespace Aula10_4
{
    class FuncaoRecursiva_2
    {
        static int[] ObterPares(int[] vetor, int indice = 0)
        {
            if (indice >= vetor.Length)
            {
                return new int[0];
            }
            // Chama recurisvamente os pares do vetor
            int[] paresRestantes = ObterPares(vetor, indice + 1);
            if (vetor[indice] % 2 == 0)
            {
                int[] resultado = new int[paresRestantes.Length + 1];
                resultado[0] = vetor[indice];
                paresRestantes.CopyTo(resultado, 1); // CopyTo é copiar tudo de um array p/ outro
                return resultado;
            }
            else
            {
                return paresRestantes;
            }
        }
// / / /  / / / / / / / / /  MAIN / / / / / / / / / / / / / / / 
        static void Main(string[] args)
        {
            int[] vetor = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int[] pares = ObterPares(vetor);

            foreach (var item in pares)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
*/