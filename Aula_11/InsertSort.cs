using System;
namespace Aula11_2
{
    //makeagif.com
    //Insert Sort é uma função de ordenação: é um algoritmo de ordenação simples que cria o array(ou lista) final ordenando um item por vez
    // exemplo {3,2,8,1,5} -> vetor desordenado
    // o insert vai ver o {3,2} // depois o {3,2,8} // dps o {3,2,8,1} -- ai ele corrige {1,2,3,8} // {1,2,3,8,5} -- {1,2,3,5,8} etc
    class InsertSort
    {
        static void Ordenar(int[] vetor)
        {
            int aux, j;
            for (int i = 1; i < vetor.Length; i++)
            {
                aux = vetor[i];
                j = i - 1;
                while (j >= 0 && vetor[j] > aux)
                {
                    vetor[j + 1] = vetor[j];
                    j--;
                }
                vetor[j + 1] = aux;
            }
        }
        static void Imprimir(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                System.Console.WriteLine(vetor[i] + " ");
            }
            System.Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] vetor = { 3, 1, 5, 7, 3, 8, 7, 2, 6 };
            System.Console.WriteLine("vetor desordenado");
            Imprimir(vetor);
            Ordenar(vetor);
            System.Console.WriteLine("vetor ordenado");
            Imprimir(vetor);

        }
    }
}