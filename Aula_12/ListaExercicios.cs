using System;

namespace Aula12_3
{
    class ListaExercicios
    {
        // EXERCICIO 01 = Implementação do Bubble Sort
        static void OrdenarBubble(int[] vetor)
        {
            int n = vetor.Length;
            int aux;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                    }
                }
            }
        }

        static void ImprimirBubble(int[] vetor)
        {
            Console.WriteLine($"[{string.Join(", ", vetor)}]");
        }
        // EXERCICIO 02 = MELHORANDO O BUBBLE

        // EXERCICIO 03 = Implementação do Selection Sort -- usando a solução de ordenação com adição
        static void OrdenarSelection(string[] array)
        {
            for (int i = 0; i < array. Length; i++)
            {
                int menorIndice = i;
                for (int j = 0; j < array.Length; j++)
                {
                    if (EhMenor(array[j], array[menorIndice]))
                    {
                        menorIndice = j;
                    }
                }
            
            string temp = array[i];
            array[i] = array[menorIndice];
            array[menorIndice] = temp;
        }
        static bool Eh menor(string a, string b)
        {
         int tamanho = Math.Min(a.Length, b.Length)

        }
    }
    



        // EXERCICIO 04 = Inserção em Ordem Decrescente com Insert Sort
        static void OrdenarInsert(int[] vetor)
        {
            int n = vetor.Length;
            int aux;
            for (int i = 1; i < n; i++)
            {
                aux = vetor[i];
                int j = i - 1;
                while (j >= 0 && vetor[j] < aux)
                {
                    vetor[j + 1] = vetor[j];
                    j--;
                }
                vetor[j + 1] = aux;
            }
        }
        static void ImprimirInsert(int[] vetor)
        {
            Console.WriteLine($"[{string.Join(", ", vetor)}]");
        }
// EXERCICIO 05
// https://www.macoratti.net/17/01/c_dicas1.htm#:~:text=Para%20medir%20o%20tempo%20decorrido%20de%20uma%20opera%C3%A7%C3%A3o%20C%23%20basta,total%20medido%20pela%20inst%C3%A2ncia%20atual.
// Site que ensina a calcular o tempo

        // ======================================= MAIN ========================================

        // CORRIGIR PARA QUE O USUÁRIO NAO INSIRA O TAMANHO DO VETOR -- QUE EU JÁ FORNEÇA  O TAMANHO DO VETOR
        static void Main(string[] args)
        {
            // Exercicio 01 =============================================
            Console.WriteLine("====== Exercicio 01 ======");
            Console.WriteLine("Digite o tamanho do vetor:");
            int n = int.Parse(Console.ReadLine());
            int[] vetor = new int[n];

            Console.WriteLine("Digite os números do vetor:");
            for (int i = 0; i < n; i++)
            {
                vetor[i] = int.Parse(Console.ReadLine());
            }
            OrdenarBubble(vetor);
            Console.WriteLine("Vetor ordenado:");
            ImprimirBubble(vetor);
            Console.WriteLine();

            // Exercicio 02 =============================================
            Console.WriteLine("====== Exercicio 02 ======");
            // Exercicio 03 =============================================
            Console.WriteLine("====== Exercicio 03 ======");
            System.Console.WriteLine("Digite o número de nomes");
            int n3 = int.Parse(Console.ReadLine());
            int[] vetor3 = new int[n4];
            // Exercicio 04 =============================================
            Console.WriteLine("====== Exercicio 04 ======");
            Console.WriteLine("Digite o tamanho do vetor:");
            int n4 = int.Parse(Console.ReadLine());
            int[] vetor4 = new int[n4];

            Console.WriteLine("Digite os números do vetor:");
            for (int i = 0; i < n4; i++)
            {
                vetor4[i] = int.Parse(Console.ReadLine());
            }
            OrdenarInsert(vetor4);
            Console.WriteLine("Vetor ordenado em ordem decrescente:");
            ImprimirInsert(vetor4);
            Console.WriteLine();
            //EXERCICIO 5 ==============================================
            


        }
    }
}
