/* namespace Aula8_2
{
    public class Exercicio2
    {
        public delegate int SomarLinha(int[] linha);

        static int SomaElementosLinha(int[] linha)
        {
            int soma = 0;
            foreach (var num in linha)
            {
                soma += num;
            }
            return soma;
        }

        static void Main(string[] args)
        {
            int[,] matriz = {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 }
            };

            SomarLinha somarLinha = SomaElementosLinha;

            for (int i = 0; i < 4; i++)
            {
                int[] linha = new int[4];
                for (int j = 0; j < 4; j++)
                {
                    linha[j] = matriz[i, j];
                }

                int soma = somarLinha(linha);
                Console.WriteLine($"Soma da linha {i + 1}: {soma}");
            }
        }
    }
}
*/