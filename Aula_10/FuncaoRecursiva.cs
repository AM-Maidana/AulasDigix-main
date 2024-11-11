/* using System;
//Qualquer função em um programa C pode ser chamada recursivamente, ou seja, pode chamar a si mesma. O número de chamadas recursivas está limitado ao tamanho da pilha.
namespace Aula10_3
{
    class FuncaoRecursiva
    {
// Fatorial. Ex 5! 4! 3! 2!
        static int Fatorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Fatorial(n - 1);
        }
// Fibonacci. A regra básica da sequência é: do terceiro termo em diante, cada novo é a soma dos dois anteriores.
        static int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
// =========== Formato de interação Fatorial  =============================================================
        static int Fatorial2(int n)
        {
            int fatorial = 1;
            for (int i = 1; i < n; i++)
                fatorial *= i;
            return fatorial;
        }
// =========== Formato de interação Fibonacci  =============================================================
        static int Fibonacci2(int n)
        {
            int a = 0, b = 1, c = 1;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
// =========== Os pares de um vetor com recursão  =============================================================
        static int Pares(int[] vetor, int n)
        {
            if (n == 0)
                return 0;
            else if (vetor[n - 1] % 2 == 0)
                return vetor[n - 1] + Pares(vetor, n - 1);
            else
                return Pares(vetor, n - 1);
        }
// =========== Os Impares de um vetor com recursão  =============================================================
static int Impares(int[] vetor2, int n)
{
    if (n == 0)
        return 0;
    else if (vetor2[n - 1] % 2 != 0)
        return vetor2[n - 1] + Impares(vetor2, n - 1);
        return Impares(vetor2, n - 1);
}
        // / / / / / / / / / / / / /  MAIN / / / / / / / / / / / / / / //
        static void Main (string[] args)
        {
            Console.WriteLine("Digite um número");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("O fatorial de " + numero + " é " + Fatorial(numero));
            System.Console.WriteLine();
// =========== Chamando a função Fibonacci  =============================================================
            Console.WriteLine("O fibonacci de " + numero + " é " + Fibonacci(numero));
            System.Console.WriteLine();
// =========== Interativo  =============================================================
            System.Console.WriteLine("Agora as respostas com formato interativo");
            Console.WriteLine("O fatorial de " + numero + " é " + Fatorial2(numero));
            System.Console.WriteLine();
// =========== Chamando a função Recursiva Vetores. EX: pares e impares do vetor =============================================================
            int[] vetor = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            System.Console.WriteLine("A soma dos pares (do vetor de 1 a 10) é: " + Pares(vetor, vetor.Length));

            int[] vetor2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            System.Console.WriteLine("A soma dos impares (do vetor de 1 a 10) é: " + Impares(vetor2, vetor2.Length));
        }
    }
}

*/