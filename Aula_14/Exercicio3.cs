/*using System;

namespace Aula14_10
{
    class Exercicio3
    {
       public static int[] pilha = new int[5];

        public static int topo = 0; // topo da pilha - 1° a sair

        // ADICIONA ELEMENTOS NA PILHA
        public static void Adicionar(int valor)
        {
            if (topo < pilha.Length)
            {
                pilha[topo] = valor;
                topo++;

            }
            else
            {
                System.Console.WriteLine("Pilha Cheia!!!");
                
            }
        }
        public static void Listar()
        {
            for (int i = topo - 1; i >= 0; i--)
            {
                System.Console.WriteLine(pilha[i]);
            }
        }

        static void Main(string[] args)
        {
            Adicionar(5);
            Adicionar(6);
            Adicionar(7);
            Adicionar(8);
            Adicionar(9);
            Listar();
System.Console.WriteLine($"O topo da pilha é: {pilha[topo - 1]}");
        }
    }
}*/