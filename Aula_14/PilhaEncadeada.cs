/*using System;

namespace Aula14_5
{
    class PilhaEncadeada
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
            Novo novoNode = new Node { valor = valor, Proximo = topo };
            //atualixa
            topo = novoNode;
        }
        static void Desempilhar()
        {
            if (topo == null)
            {
                System.Console.WriteLine("Pilha Vazia!!");
                return;
            }
            
            System.Console.WriteLine($"Desempilhando {topo.valor}");
            topo = topo.Proximo;
        }
//Mostra a pilha
        static void Listar()
        {
            if (topo == null)
            {
                System.Console.WriteLine("Pilha Vazia");
                return;
            }
            System.Console.WriteLine("Listand a Pilha");
            Node? atual = topo;
            while (atual != null)
            {
                System.Console.WriteLine(atual.valor);
                atual = atual.Proximo;
            }
        }

        static void Main(string[] args)

        {
            Empilhar(1);
            Empilhar(2);
            Empilhar(3);
            Empilhar(4);
            Empilhar(5);

            Listar();
            Desempilhar();
            Listar();

        }
    }
}
*/