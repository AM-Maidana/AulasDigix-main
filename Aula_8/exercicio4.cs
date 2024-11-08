/*4. Soma das Diagonais de uma Matriz n x n (Função Pública)
Enunciado: Dada uma matriz quadrada n x n, crie uma função pública que exiba a soma
dos elementos da diagonal principal e da diagonal secundária.
Requisitos:

• Criar uma função pública que receba uma matriz quadrada e retorne a soma das
diagonais.
• A função deve somar os elementos da diagonal principal e secundária e retornar o
resultado.
• Exibir a soma das diagonais no console

// MATRIZ 3 X 3
//( N N N )
//( N N N )
//( N N N )
*/
using System;
namespace Aula8_4{

    public class exercicio4{
        
    public delegate int SomaElementos1 (int [] diagonal);
    public delegate int SomaElementos2 (int [] diagonal2);
    static int SomaDiagonal1 (int[] diagonal)
    {
        int soma1 = 0;
        foreach (var num in diagonal)
        {
            soma1 += num;
        }
            return soma1;
    }
    static int SomaDiagonal2 (int[] diagonal2)
    {
        int soma2 = 0;
        foreach (var num in diagonal2){
            soma2 += num;
        }
            return soma2;
    }
    static void Main(string[] args)
    {
        int[,] matriz = {
                { 1, 2, 3},
                { 5, 2, 7},
                { 9, 10, 21}
    };
int somaDiagonal1 = 0, somaDiagonal2 = 0;
        SomaElementos1 somaElementos1 = SomaDiagonal1;
        SomaElementos2 somaElementos2 = SomaDiagonal2;

        int n = matriz.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                somaDiagonal1 += matriz[i, i];
                somaDiagonal2 += matriz[i, n - 1 - i];
            }

            Console.WriteLine($"Soma da diagonal principal: {somaDiagonal1}");
            Console.WriteLine($"Soma da diagonal secundária: {somaDiagonal2}");

        }
    }
}

