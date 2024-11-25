/*using System;

namespace Aula14_3
{
    public class ListaEncadeada
    {
        class Node
        {
            public int Valor;
            public Node? Proximo;
        }
        static Node? inicio = null;

        static void Inserir(int valor)
        {
            // CRIANDO UM NOVO NÓ COM VALOR FORNECIDO = APONTA PARA O INICIO
            Node novoNode = new Node { Valor = valor, Proximo = null };

            if (inicio == null)
            {
                inicio = novoNode;
            }
            else
            {
                Node atual = inicio;
                while (atual.Proximo != null)
                {
                    atual = atual.Proximo;
                }
                atual.Proximo = novoNode;
            }
        }
        static void Excluir(int valor)
        {
            if (inicio == null) return;

            if (inicio.Valor == valor)
            {
                inicio = inicio.Proximo;
                return;
            }
            Node atual = inicio;
            while (atual.Proximo != null && atual.Proximo.Valor != valor)
            {
                atual = atual.Proximo;
            }
            {
                if (atual.Proximo != null)
                {
                    atual.Proximo = atual.Proximo.Proximo;
                }
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
            Inserir(1);
            Inserir(2);
            Inserir(3);
            Inserir(4);
            Inserir(5);
            System.Console.WriteLine();
            Listar();
            System.Console.WriteLine();
            Excluir(3);
            System.Console.WriteLine();
            Listar();

        }

    }
}
*/