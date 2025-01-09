using System;

namespace Exercicio_Fixacao
{
    public class Exercicio
    {
        private int Num { get; set; }
        private string Titular { get; set; }
        private double Saldo { get; set; }
        private double LimiteSaque { get; set; } = Saldo;

        public Exercicio(int num, string titular, double saldo, double limiteSaque)
        {
            Num = num;
            Titular = titular;
            Saldo = saldo;
            LimiteSaque = limiteSaque;
        }

        public void Deposito(double quantia)
        {
            System.Console.WriteLine($"Saldo da conta: {Saldo}");
            System.Console.WriteLine("Você deseja realizar um depósito? (s/n)");
            string resposta = Console.ReadLine();

            if (resposta == "s")
            {
                System.Console.WriteLine("Digite o valor do depósito: ");
                double valor = double.Parse(Console.ReadLine());
                Saldo += valor;
                System.Console.WriteLine($"Depósito realizado com sucesso. Novo saldo: {Saldo}");
            }
            else if (resposta == "n")
            {
                System.Console.WriteLine("Operação cancelada");
            }
        }

        public void Saque(double quantia)
        {
            System.Console.WriteLine($"Saldo da conta: {Saldo}");
            System.Console.WriteLine("Você deseja realizar um saque? (s/n)");
            string resposta = Console.ReadLine();

            if (resposta == "s")
            {
                System.Console.WriteLine("Digite o valor do saque: ");
                double valor = double.Parse(Console.ReadLine());
                if (Saldo == 0)
                {
                    throw new SaqueException("ERRO: Saldo insuficiente");
                }
                if (valor > LimiteSaque)
                {
                    throw new SaqueException("ERRO: o valor do saque excede o limite de saque");
                }
                if (valor > Saldo)
                {
                    throw new SaqueException("ERRO: Saldo insuficiente");
                }
                Saldo -= valor;
                System.Console.WriteLine($"Saque realizado com sucesso. Novo saldo: {Saldo}");
            }
            else if (resposta == "n")
            {
                System.Console.WriteLine("Operação cancelada");
            }
        }
    }
}