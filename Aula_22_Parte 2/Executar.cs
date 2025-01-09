using System;
namespace Exercicio_Fixacao
{
    public class Executar
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Clear();
                System.Console.WriteLine("Entre com o numéro da conta: ");
                int num = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Entre com o nome da conta: ");
                string titular = Console.ReadLine();
                System.Console.WriteLine("Saldo inicial: ");
                double saldo = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Limite de saque = Saldo, atualmente está em: " + saldo);

                Exercicio conta = new Exercicio(num, titular, saldo, limiteSaque: saldo);

                System.Console.WriteLine("Deseja realizar um deposito? (s/n)");
                string resposta = Console.ReadLine();

                if (resposta == "s")
                {
                    System.Console.WriteLine("Digite o valor do depósito: ");
                    double valor = double.Parse(Console.ReadLine());
                    saldo += valor;
                }
                else if (resposta == "n")
                {
                    System.Console.WriteLine("Operação cancelada");
                }
            }
            catch (SaqueException e)
            {
                System.Console.WriteLine(e.Message);
            }

            try
            {
                System.Console.WriteLine();
                System.Console.WriteLine($"Saldo atual: {conta.Saldo}");
                System.Console.WriteLine("Deseja realizar um saque? (s/n)");
                string reposta2 = Console.ReadLine();

            }
            catch (SaqueException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}