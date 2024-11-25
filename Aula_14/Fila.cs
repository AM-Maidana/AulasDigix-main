/*using System;

namespace Aula14_1
{
    public class Fila
    {
        static int[] fila = new int[5];

        static int inicio = 0; // inicio da fila
        static int fim = 0; // final da fila

        static int cout = 0; // qtde de elementos na fila (contador)
                             // add um elemento na fila, Enqueue
        public static void Adicionar(int valor)
        {
            if (cout < fila.Length)
            {
                fila[fim] = valor;
                fim = (fim + 1) % fila.Length; // movimenta o fim da fila
                cout++; //incrementa a qtde de elementos na fila
            }
            else
            {
                System.Console.WriteLine("Fila Cheia!!!");
            }
        }
        // remover um elemento, dequeue
        static void Remover()
        {
            if (cout > 0)
            {
                fila[fim] = 0;
                inicio = (inicio + 1) % fila.Length; // move o inicio da fila
                cout--; //Remove a qtde de elementos na fila
            }
            else
            {
                System.Console.WriteLine("Fila Vazia!!!");
            }
        }
        // mostra a fila
        public static void Mostrar()
        {
            for (int i = 0; i < cout; i++)
            {
                System.Console.WriteLine(fila[(inicio + i) % fila.Length]);
            }
        }
        // primeiro elemento da fila 
        public static void Primeiro()
        {
            if (cout > 0)
            {
                System.Console.WriteLine(fila[inicio]);
            }
            else
            {
                System.Console.WriteLine("Fila Vazia!!!");
            }
        }
        // ultimo elemento da fila
        public static void Ultimo()
        {
            if (cout < 0)
            {
                System.Console.WriteLine(fila[fim]);
            }
            else
            {
                System.Console.WriteLine("Fila Cheia!!!");
            }
        }
        static void Main(string[] args)
        {
            Adicionar(10);
            Adicionar(20);
            Adicionar(30);
            Adicionar(40);
            Adicionar(50);

            Mostrar();

            System.Console.WriteLine("Primeiro elemento da fila: ");
            Primeiro();

            // remover elementos
            //Remover();

            System.Console.WriteLine("Nova lista");

            Mostrar();


            //remover tudo


        }

    }
}
*/