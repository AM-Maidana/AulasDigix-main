//using System;
/*5. Exercício 5: Inserir elementos de outra fila
o Crie uma função que insira os elementos de uma segunda fila no final da 
fila atual.
o Exemplo de uso:
Fila 1: 10 -> 20
Fila 2: 30 -> 40
Resultado: 10 -> 20 -> 30 -> 40*/
/*namespace Aula14_12
{
    class Exercicio5
    {
        class Node
        {
            public int valor1;
            public Node? proximo1;
            public int valor2;
            public Node? proximo2;
        }

        static Node? inicio1 = null;
        static Node? fim1 = null;

        static Node? inicio2 = null;
        static Node? fim2 = null;

        static int contador = 0;
        static int contador2 = 0;

        static void EnfileirarFila1(int valor1)
        {
            Node novoNode = new Node { valor1 = valor1, proximo1 = null };
            if (inicio1 == null)
            {
                inicio1 = novoNode;
            }
            else
            {
                fim1!.proximo1 = novoNode;
            }
            fim1 = novoNode;
            contador++;
        }
        static void EnfileirarFila2(int valor2)
        {
            Node novoNode = new Node { valor2 = valor2, proximo2 = null };

            if (inicio2 == null)
            {
                inicio2 = novoNode;
            }
            else
            {
                fim2!.proximo2 = novoNode;
            }
            fim2 = novoNode;
            contador2++;
        }
        static void ListarFila1()
        {
            if (inicio1 == null)
            {
                Console.WriteLine("Fila 1 vazia!");
                return;
            }
            System.Console.WriteLine("Fila 1");
            Node? atual = inicio1;
            while (atual != null)
            {
                Console.WriteLine(atual.valor1 + " ");
                atual = atual.proximo1;
            }
            System.Console.WriteLine();
        }
        static void ListarFila2()
        {
            if (inicio2 == null)
            {
                Console.WriteLine("Fila 2 vazia!");
                return;
            }
            System.Console.WriteLine("Fila 2");
            Node? atual2 = inicio2;
            while (atual2 != null)
            {
                Console.WriteLine(atual2.valor2 + " ");
                atual2 = atual2.proximo2;
            }
            System.Console.WriteLine();
        }
        static void JuntarFilas()
        {
            if (inicio2 == null)
            {
                System.Console.WriteLine("Fila 2 está vazia, não há nada para inerir");
                return;
            }
            Node? atual2 = inicio2;
            while (atual2 != null)
            {
                EnfileirarFila1(atual2.valor2);
                atual2 = atual2.proximo2;
            }
            System.Console.WriteLine();
        }

        static void Main()
        {
            EnfileirarFila1(10);
            EnfileirarFila1(20);
            EnfileirarFila1(30);
            ListarFila1();

            EnfileirarFila2(40);
            EnfileirarFila2(50);
            EnfileirarFila2(60);
            ListarFila2();


            System.Console.WriteLine("juntando as filas: ");
            JuntarFilas();

            ListarFila1();

        }
    }
}
*/
