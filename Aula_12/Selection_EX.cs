/* using System;
namespace Aula12_2
{
    class SelectionSort
    {
        // ============================= USANDO SELECTION DE FORMA DECRESCENTE =============================
        static void Ordenar(int[] vetor)
        {
            int menor, aux;
            for (int i = 0; i < vetor.Length; i++)
            {
                menor = i;
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[j] > vetor[menor])
                    {
                        menor = j;
                    }
                }
                aux = vetor[i];
                vetor[i] = vetor[menor];
                vetor[menor] = aux;
            }
        }
        static void Imprimir(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {

            }

            System.Console.WriteLine($"[{string.Join(", ", vetor)}]");
            System.Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] vetor = { 3, 1, 5, 7, 3, 4 };
            System.Console.WriteLine("vetor desordenado");
            Imprimir(vetor);
            Ordenar(vetor);
            System.Console.WriteLine("vetor ordenado");
            Imprimir(vetor);

        }
    }
}

*/