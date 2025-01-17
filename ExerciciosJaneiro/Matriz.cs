using System;
using System.IO;

namespace Exe17JAN
{
    public class Matriz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para começar, digite o número de linhas da Matriz: ");
            int opLinhas = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora, digite o número de colunas da matriz: ");
            int opColunas = int.Parse(Console.ReadLine());

            Random numeros = new Random();
            int[,] matriz = new int[opLinhas, opColunas];
            for (int i = 0; i < opLinhas; i++)
            {
                for (int j = 0; j < opColunas; j++)
                {
                    matriz[i, j] = numeros.Next(1, 101);
                }
            }
            Console.WriteLine($"\nMatriz de {opLinhas} linhas e {opColunas} colunas preenchida com números aleatórios:");
            for (int i = 0; i < opLinhas; i++)
            {
                for (int j = 0; j < opColunas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("===========================");
            Console.WriteLine("Escolha uma das opções: ");
            Console.WriteLine("\n1. Soma das linhas");
            Console.WriteLine("\n2. Soma das colunas");
            Console.WriteLine("\n3. Transpor a matriz");

            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    SomaLinhas();
                    break;
                case 2:
                    SomaColunas();
                    break;
                case 3:
                    TransporMatriz();
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            void SomaLinhas()
            {
                int[] somasLinhas = new int[opLinhas];
                for (int i = 0; i < opLinhas; i++)
                {
                    int somaLinha = 0;
                    for (int j = 0; j < opColunas; j++)
                    {
                        somaLinha += matriz[i, j];
                    }
                    somasLinhas[i] = somaLinha;
                    Console.WriteLine($"Soma da linha {i + 1}: {somaLinha}");
                }

                SaveToCsv("somas_linhas.csv", somasLinhas, "Soma das Linhas");
            }

            void SomaColunas()
            {
                int[] somasColunas = new int[opColunas];
                for (int j = 0; j < opColunas; j++)
                {
                    int somaColuna = 0;
                    for (int i = 0; i < opLinhas; i++)
                    {
                        somaColuna += matriz[i, j];
                    }
                    somasColunas[j] = somaColuna;
                    Console.WriteLine($"Soma da coluna {j + 1}: {somaColuna}");
                }

                SaveToCsv("somas_colunas.csv", somasColunas, "Soma das Colunas");
            }

            void TransporMatriz()
            {
                int[,] transposta = new int[opColunas, opLinhas];
                for (int i = 0; i < opLinhas; i++)
                {
                    for (int j = 0; j < opColunas; j++)
                    {
                        transposta[j, i] = matriz[i, j];
                    }
                }
                Console.WriteLine("Matriz Transposta:");
                for (int i = 0; i < opColunas; i++)
                {
                    for (int j = 0; j < opLinhas; j++)
                    {
                        Console.Write(transposta[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }

            void SaveToCsv(string filepath, int[] array, string primeiro)
            {
                using (StreamWriter writer = new StreamWriter(filepath))
                {
                    writer.WriteLine(primeiro);
                    foreach (int item in array)
                    {
                        writer.WriteLine(item);
                    }
                }
            }
            void SaveMatrizCsv(string filepath, int[,] matriz)
            {
                using (StreamWriter writer = new StreamWriter(filepath))
                {
                    for (int i = 0; i < opLinhas; i++)
                    {
                        for (int j = 0; j < opColunas; j++)
                        {
                            writer.Write(matriz[i, j]);
                            if (j < opColunas - 1)
                            {
                                writer.Write(", ");
                            }
                        }
                        writer.WriteLine();
                    }
                }
            }
        }
    }
}
