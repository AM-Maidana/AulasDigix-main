/*using System;

namespace Aula14_2
{
    public class Pilha
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
        // REMOVE ELEMENTOS DA  PILHA 
        public static void Remover()
        {
            if (topo > 0)
            {
                topo--; //Decrementa o topo
                pilha[topo] = 0;
            }
            else
            {
                System.Console.WriteLine("Pilha Vazia!!!");
            }
        }
        // LISTAR
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

            Remover();

System.Console.WriteLine();
            Listar();

        }


    }
}
*/