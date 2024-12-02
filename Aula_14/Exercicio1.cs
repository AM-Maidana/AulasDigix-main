/*using System;

namespace Aula14_8
{
    class Exercicio1
    {
        class Node
        {
            public int Valor;
            public Node? Proximo;
        }

        static Node? inicio = null;

        static void Inserir(int valor, int posicao)
        {
            Node novoNode = new Node { Valor = valor, Proximo = null };

            if (inicio == null)
            {
                inicio = novoNode;
            }
            else
            {
                Node atual = inicio;
                int i = 0;
                while (atual.Proximo != null && i < posicao - 1)
                {
                    atual = atual.Proximo;
                    i++;
                }
                novoNode.Proximo = atual.Proximo;
                atual.Proximo = novoNode;
            }
        }
        static void Listar()
        {
            if (inicio == null)
            {
                System.Console.WriteLine("A lista está Vazia. ");
                return;
            }
            Node? atual = inicio;
            Console.WriteLine("Elementos na lista:");
            while (atual != null)
            {
                System.Console.WriteLine(atual.Valor);
                atual = atual.Proximo;
            }
        }

        static void Main(string[] args)
        {
            Inserir(1, 1);
            Inserir(2, 2);
            Inserir(3, 3);
            Inserir(4, 4);
            Inserir(5, 5);
            Listar();

            System.Console.WriteLine("Inserindo um número em uma posição especifica?");
            Inserir(7, 3);
            Listar();


        }
    }
}
*/