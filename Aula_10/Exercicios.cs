using System;

namespace Aula10_5
{
    /*Exercícios usando função e recurção*/
    class Exercicios
    {
        /*1. Faça um programa que calcule a soma dos números de 1 a n, onde n é um número 
        inteiro fornecido pelo usuário.*/
        static int Soma1(int n = 0)
        {
            int R1 = 0;

            for (int i = 1; i <= n; i++)
            {
                R1 += i;
            }
            return R1;
        }
        /*2. Faça um programa que calcule o produto dos números de 1 a n, onde n é um número 
        inteiro fornecido pelo usuário.*/
        static int Produto(int n2 = 0)
        {
            int R2 = 1;

            for (int i = 1; i <= n2; i++)
            {
                R2 *= i;
            }
            return R2;
        }
        /*3. Faça um programa que calcule a potência de um número inteiro x elevado a um número 
        inteiro não-negativo n, fornecidos pelo usuário.*/
        static double Potencia(double n3, double pot)
        {
            if (pot == 0)
            {
                return 1;
            }
            return n3 * Potencia(n3, pot - 1);

        }
        /*4. Faça um programa que calcule o MDC (Máximo Divisor Comum) de dois números 
        inteiros fornecidos pelo usuário.*/
        static int MDC(int n4A, int z)
        {
            if (z == 0)
            {
                return n4A;
            }
            return MDC(z, n4A % z);

        }
        /*5. Faça um programa que calcule a soma dos elementos de um vetor de inteiros.*/
        static int SumVetor(int[] vetor1)
        {
            int Sum = 0;
            for (int i = 0; i < vetor1.Length; i++)
            {
                Sum += vetor1[i];
            }
            return Sum;
        }
        /*6. Faça um programa que calcule a média dos elementos de um vetor de inteiros.*/
        static double MediaVetor(int[] vetor2)
        {
            double Sum2 = 0;
            for (int i = 0; i < vetor2.Length; i++)
            {
                Sum2 += vetor2[i];
            }
            double media = Sum2 / vetor2.Length;
            return media;
        }
        //=/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args)
        {

            // EXERCICIO 1 ==============================================================
            Console.WriteLine("=========== Exercicio 1 ===========");
            Console.WriteLine("Digite um número: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"A soma de 1 até {n} é igual a {Soma1(n)}");
            Console.WriteLine();

            // EXERCICIO 2 ==============================================================    
            Console.WriteLine("=========== Exercicio 2 ===========");
            Console.WriteLine("Digite um número: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"O produto de 1 até {n2} é igual a {Produto(n2)}");
            Console.WriteLine();

            // EXERCICIO 3 ==============================================================
            Console.WriteLine("=========== Exercicio 3 ===========");
            Console.WriteLine("Digite um número: ");
            double n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número: ");
            double pot = double.Parse(Console.ReadLine());
            Console.WriteLine($"A potencia de {n3} elevado a {pot} é igual a {Potencia(n3, pot)}");
            Console.WriteLine();

            // EXERCICIO 4 ==============================================================
            Console.WriteLine("=========== Exercicio 4 ===========");
            Console.WriteLine("Digite um número: ");
            int n4A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            int z = int.Parse(Console.ReadLine());

            int R4 = MDC(n4A, z);

            Console.WriteLine($"O MDC dos número {n4A} e {z} é {R4}");
            Console.WriteLine();

            // EXERCICIO 5 ==============================================================
            int[] vetor1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int R5 = SumVetor(vetor1);
            Console.WriteLine($"O resultado da soma do vetor é: {R5}");

            // EXERCICIO 6 ==============================================================
            int[] vetor2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double R6 = MediaVetor(vetor2);
            Console.WriteLine($"A media do vetor 2 é: {R6}");

/*EXEMPLO DO PROFESSOR -- ACHEI DIFICIL

static (int, double) SomaMediaVetor (int[] vetor, int index, int tamanho)
{
    if(index < 0 )
        return(0,0.0);

        ////chamada recursiva
    (int somaParcial, double _) =  SomaMediaVetor(vetor, index - 1, tamanho)
    int somaTotal = somaParcial + vetor[index];

    double media = (double)somaTotal / tamanho;

    return (SomaTotal, media);

}*/
        }
    }
}
