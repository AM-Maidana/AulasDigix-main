/*6. Exercício 6: Verificar o tamanho da fila
Implemente uma função que calcule o número de elementos na fila.
o Exemplo de uso:
Fila: 10 -> 20 -> 30
Tamanho() -> 3*/
/* using System;
namespace Aula14_13
{
    class Exercicio6
    {
        static int[] fila = new int[5];

        static int inicio = 0; // inicio da fila
        static int fim = 0; // final da fila

        static int cout = 0; 
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
    
        public static void Mostrar()
        {
            for (int i = 0; i < cout; i++)
            {
                System.Console.WriteLine(fila[(inicio + i) % fila.Length]);
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

    System.Console.WriteLine($"O número de elementos da fila é {cout}");

        }

    }
}
*/