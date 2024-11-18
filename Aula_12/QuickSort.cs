/*using System;

namespace Aula12
{
    class QuickSort
    {
        // Dividir para conquistar - um algoritmo de divisão e conquista pega o problema e divide em subproblemas para solucionar
        //Algoritmo de ordenação QuickSort
        static void Ordenar(int[] vetor, int inicio, int fim)
        {

            if (inicio < fim)
            {
                int p = Particionar(vetor, inicio, fim);
                Ordenar(vetor, inicio, p - 1);
                Ordenar(vetor, p + 1, fim);
            }
        }
        static int Particionar(int[] vetor, int inicio, int fim)
        {
            int pivo = vetor[fim];
            int i = inicio - 1;
            for (int j = inicio; j < fim; j++)
            {
                if (vetor[j] < pivo)  //Para tornar decrescente muda o sinal
                {
                    i++;
                    int aux = vetor[i];
                    vetor[i] = vetor[j];
                    vetor[j] = aux;
                }
            }
            int aux2 = vetor[i + 1];
            vetor[i + 1] = vetor[fim];
            vetor[fim] = aux2;
            return i + 1;
        }
        static void Imprimir(int[] vetor)
        {
            System.Console.WriteLine($"[{string.Join(", ", vetor)}]");
        }
        static void Main(string[] args)
        {

            int[] vetor = { 3, 1, 5, 7, 3, 4 };
            //System.Console.WriteLine("QUICKSORT EM ORDEM DECRESCENTE");
            //System.Console.WriteLine();
            System.Console.WriteLine("vetor desordenado");
            Imprimir(vetor);
            Ordenar(vetor, 0, vetor.Length - 1); //-- Inicio é 0 (pois em *Particionar* definimos o inicio como (inicio -1) e o FIM é vetor.Length
            System.Console.WriteLine("vetor ordenado");

            Imprimir(vetor);

        }
    }
}

*/
