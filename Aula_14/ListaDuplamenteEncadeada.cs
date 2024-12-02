/*using System;

namespace Aula14_7
{
    class ListaDuplamenteEncadeada
    {
        class Node
        {
            public int valor;
            public Node? proximo;
            public Node? anterior;
        }
        static Node? inicio = null;

        static void Inserir(int valor)
        {
            Node novoNode = new Node { valor = valor, proximo = null, anterior = null };
            if (inicio == null)
            {
                inicio = novoNode;
            }
            else
            {
                Node atual = inicio;
                while (atual.proximo != null)
                {
                    atual = atual.proximo;
                }
                atual.proximo = novoNode;
                novoNode.anterior = atual;
            }
        }
        static void Excluir(int valor)
        {
            if (inicio == null)
            {
                System.Console.WriteLine("Lista vazia");
                return;

            }
                // verifica se o valor excluido está no inicio
                if (inicio.valor == valor)
                {
                    inicio = inicio.proximo;
                    inicio.anterior = null;
                    return;
                }

            // percorrer a lista para encontrar o nó com o valor
            Node atual = inicio;
            while (atual != null && atual.valor != valor)
            {
                atual = atual.proximo;
            }

            //verifica se o nó foi encontrado
            if (atual != null)
            {
                if (atual.anterior != null)
                {
                    atual.anterior.proximo = atual.proximo;
                }
                if (atual.proximo != null)
                {
                    atual.proximo.anterior = atual.anterior;
                }
            }
        }
        static void Listar()
        {
            Node? atual = inicio;
            while (atual != null)
            {
                System.Console.WriteLine(atual.valor);
                atual = atual.proximo;
            }
        }
        static void Main (string[] args)
        {
            Inserir(50);
            Inserir(60);
            Inserir(70);
            Inserir(80);
            Inserir(90);
            Inserir(100);
            System.Console.WriteLine();
            System.Console.WriteLine("Lista: ");
            Listar();
            Excluir(80);
            System.Console.WriteLine("Lista depois do excluir");
            Listar();
        }
    }
}
*/