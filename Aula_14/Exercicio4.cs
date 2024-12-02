/*using System;

namespace Aula14_11
{
    class Exercicio4
    {
        class Node
        {
            public int valor;
            public Node? Proximo;
        }
        static Node? topo = null;
        // EMPILHAR
        static void Empilhar(int valor)
        {
            Node novoNode = new Node { valor = valor, Proximo = topo };
            //atualixa
            topo = novoNode;
        }
        static void Listar()
        {
            if (topo == null)
            {
                System.Console.WriteLine("Pilha Vazia");
                return;
            }
            System.Console.WriteLine("Listando a Pilha");
            Node? atual = topo;
            while (atual != null)
            {
                System.Console.WriteLine(atual.valor);
                atual = atual.Proximo;
            }
        }
static void AlterarPilha()
{
    if (topo == null || topo.Proximo == null)
    {
        return;
    } 
    Node? anterior = null;
    Node? atual = topo;
    Node? proximo;

    while (atual != null)
    {
        proximo = atual.Proximo;
        atual.Proximo = anterior;
        anterior = atual;
        atual = proximo;
    }
    topo = anterior;
}
        static void Main(string[] args)

        {
            Empilhar(1);
            Empilhar(2);
            Empilhar(3);

            Listar();
            System.Console.WriteLine("Empilhado ao contrário: ");
            AlterarPilha();

        }
    }
}
*/