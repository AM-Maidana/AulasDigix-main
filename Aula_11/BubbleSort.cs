/* using System;

namespace Aula11
{
    //bubble sort - é uma função de ordenação de 2 em 2 (posição 1, posição 2 -- comparação / posição 2, posição 3 -- comparação / etc)
    //em ordem crescente
    class BubbleSort
    {
        static void Ordenar(int[] vetor)
        {
            //2 for, um que vai andar de primeira e um que vai comparar as posições
            int aux;
            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = 0; j < vetor.Length - 1; j++)
                {
                    if(vetor[j] > vetor[j+1])
                    {
                        aux = vetor[j];
                        vetor[j] = vetor[j+1];
                        vetor[j+1] = aux;
                    }
                }
            }
        }

        static void Imprimir(int[] vetor)
        {
            System.Console.WriteLine($"[{string.Join(", ", vetor)}]"); //sugestão de impressão : [3, 1, 5, 7, 3, 4]
        }

        static void Main (string[] args)
        {
            int[] vetor  = { 3,1,5,7,3,4 };
            System.Console.WriteLine("vetor desordenado");
            Imprimir(vetor);
            Ordenar(vetor);
            System.Console.WriteLine("vetor ordenado");
            Imprimir(vetor);

        }
    }
}
*/