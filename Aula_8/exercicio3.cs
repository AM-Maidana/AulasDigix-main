/* namespace Aula8_3
{
    public class exercicio3
    {

        public delegate bool VerificarPalindromoDelegate(int[] vetor);

        static bool VerificarPalindromo(int[] vetor)
        {
            for (int i = 0; i < vetor.Length / 2; i++)
            {
                if (vetor[i] != vetor[vetor.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

//        static void Main(string[] args)
        {

            VerificarPalindromoDelegate verificar = VerificarPalindromo;

            int[] vetor = { 1, 2, 3, 2, 1 };

            bool resultado = verificar(vetor);

            if (resultado)
                Console.WriteLine("O vetor é um palíndromo.");
            else
                Console.WriteLine("O vetor não é um palíndromo.");
        }
    }
}
*/