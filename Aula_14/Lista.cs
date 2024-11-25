/*using System;

namespace Aula14
{
    public class Lista
    {
        //LISTA VIA ARRAY
        static int[] vetor = new int[5];

        //metodo inserir
        static void Inserir(int valor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if(vetor[i] == 0)
                {
                    vetor[i] = valor;
                    break;
                }
            }
        }
        static void Remover(int valor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if(vetor[i] == valor)
                {
                    vetor[i] = 0;
                    break;
                }
            }
        }
        static void Listar()
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if(vetor[i] != 0)
                {
                    System.Console.WriteLine(vetor[i]);
                }
            }
        }

        // Listar de forma inversa
        static void ListaInversa()
        {
            for (int i = vetor.Length - 1; i >= 0; i--)
            {
                if(vetor[i] != 0)
                {
                    System.Console.WriteLine(vetor[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            
            Inserir(50);
            Inserir(60);
            Inserir(70);
            Inserir(80);
            Inserir(90);
            Inserir(100);
            Listar();
            System.Console.WriteLine("Listar de forma inversa");
            ListaInversa();
            Remover(50);
            System.Console.WriteLine("Lista depois de remover o 50");
            Listar();

        }
    }
}
*/