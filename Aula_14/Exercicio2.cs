//using System;
/**2. Exercício 2: Verificar se um valor está na lista
o Crie uma função que percorra a lista encadeada e verifique se um valor 
específico existe nela.

/*namespace Aula14_9
{
    class Exercicio2
    {
        class Node
        {
            public int valor;
            public Node? Proximo;
        }
        static Node? inicio = null;

        static void Inserir(int valor)
        {
            Node novoNode = new Node { valor = valor, Proximo = null };

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
        public static bool Contem(int valor)
    {
        Node atual = inicio;
        while (atual != null)
        {
            if (atual.valor == valor)
            {
                return true; 
            }
            atual = atual.Proximo;
        }
        return false; 
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
                System.Console.WriteLine(atual.valor);
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
            Listar();
            System.Console.WriteLine(Contem(2));
            System.Console.WriteLine(Contem(7));

        }

    }
}
*/