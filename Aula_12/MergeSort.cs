/* using System;

namespace Aula12_1
{
    class MergeSort
    {
        //Algoritmo de dividir e conquistar
        //Ordenação atraves de recursividade
        static void Ordenar(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int meio = (inicio + fim) / 2;
                Ordenar(vetor, inicio, meio);
                Ordenar(vetor, meio + 1, fim);
                Intercalar(vetor, inicio, meio, fim);
            }
        }
        static void Intercalar(int[] vetor, int inicio, int meio, int fim)
        {
            int[] aux = new int[vetor.Length];
            for (int j = inicio; j <= fim; j++)
            {
                aux[j] = vetor[j];
            }
            int i1 = inicio;
            int i2 = meio + 1;
            int i3 = inicio;

            while (i1 <= meio && i2 <= fim)
            {
                if (aux[i1] < aux[i2]) // para tornar-lo decrescente é só mudar o sinal
                {
                    vetor[i3] = aux[i1];
                    i1++;
                }
                else
                {
                    vetor[i3] = aux[i2];
                    i2++;
                }
                i3++;
            }
            while (i1 <= meio)
            {
                vetor[i3] = aux[i1];
                i1++;
                i3++;
            }

        }

        static void Imprimir(int[] vetor)
        {
            System.Console.WriteLine($"[{string.Join(", ", vetor)}]"); //sugestão de impressão : [0, 3, 4, 5, 8, 9]
        }

        static void Main(string[] args)
        {

            int[] vetor = { 0, 8, 4, 3, 9, 5 };
            //System.Console.WriteLine("MERGESORT EM ORDEM DECRESCENTE");
           // System.Console.WriteLine();
            System.Console.WriteLine("vetor desordenado");
            Imprimir(vetor);
            System.Console.WriteLine();
            Ordenar(vetor, 0, vetor.Length - 1); //-- INICIO é 0 e o FIM é vetor.Length
            System.Console.WriteLine("vetor ordenado");
            Imprimir(vetor);

        }
    }
}

*/