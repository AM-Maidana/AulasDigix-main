/* using System;

namespace Aula12_
{
    class Bubble_EX
    {
// ============================= USANDO O BUBBLE SORTE PARA ORDENAÇÃO DECRESCENTE =============================
        static void Ordenar(int[] vetor)
        {
            //2 for, um que vai andar de primeira e um que vai comparar as posições
            int aux;
            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = 0; j < vetor.Length - 1; j++)
                {
                    if(vetor[j] < vetor[j+1])
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
            System.Console.WriteLine($"[{string.Join(", ", vetor)}]");
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