using System;

namespace Atividade_Aula7
{
    class atividades
    {
        static void Main(string[] args)
        {
            // ==== Exercicio 1 ========================
            Console.WriteLine("======== Exercicio 1 ========");
            int[] numeros = new int[10];
            int soma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
                soma += numeros[i];
            }

            double media = (double)soma / 10;
            Console.WriteLine($"\nA média dos números é: {media}");
            Console.WriteLine();

            // ==== Exercicio 2 ========================
            Console.WriteLine("======== Exercicio 2 ========");
            int[,] matrizEx2 = {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 }
            };

            for (int a = 0; a < 4; a++)
            {
                int somaLinha = 0;
                for (int b = 0; b < 4; b++)
                {
                    somaLinha += matrizEx2[a, b];
                }
                Console.WriteLine($"Soma da linha {a + 1}: {somaLinha}");
            }
            Console.WriteLine();

            // ==== Exercicio 3 ========================
            Console.WriteLine("======== Exercicio 3 ========");
            int[] vetor = { 1, 2, 3, 2, 1 };
            bool ehPalindromo = true;

            for (int i = 0; i < vetor.Length / 2; i++)
            {
                if (vetor[i] != vetor[vetor.Length - 1 - i])
                {
                    ehPalindromo = false;
                    break;
                }
            }

            if (ehPalindromo)
                Console.WriteLine("O vetor é um palíndromo.");
            else
                Console.WriteLine("O vetor não é um palíndromo.");
            Console.WriteLine();

            // ==== Exercicio 4 ========================
            Console.WriteLine("======== Exercicio 4 ========");
            int[,] matrizEx4 = {
                { 2, 3, 4 },
                { 5, 6, 7 },
                { 8, 9, 10 }
            };

            int n = matrizEx4.GetLength(0);
            int somaPrincipal = 0, somaSecundaria = 0;

            for (int i = 0; i < n; i++)
            {
                somaPrincipal += matrizEx4[i, i];
                somaSecundaria += matrizEx4[i, n - 1 - i];
            }

            Console.WriteLine($"Soma da diagonal principal: {somaPrincipal}");
            Console.WriteLine($"Soma da diagonal secundária: {somaSecundaria}");
        }
    }
}
