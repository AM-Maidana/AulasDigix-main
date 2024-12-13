using System;
namespace Aula_18_exercicios
{
    public class Agencia
    {
        static void Main(string[] args)
        {
            Banco b = new Banco(1234, 90, 0, 36);

Console.WriteLine("Bem vindo ao Banco X");
Console.WriteLine("N° da sua conta: " + b.AbrirConta());
Console.WriteLine("Valor atual da sua cc: " + b.CC()); //cc = conta corrente
Console.WriteLine("O valor depositado será: " + b.Depositar());
Console.WriteLine();
Console.WriteLine("Sua cc: " + b.CCAposDeposito());
Console.WriteLine("Sacando.. " + b.Saques());
Console.WriteLine("cc após o saque: " + b.SaqueFeito());


        }
    }
}