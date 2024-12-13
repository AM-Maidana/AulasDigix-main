using System;
using System.Diagnostics.Contracts;
namespace Aula_18_exercicios
{
    public class Banco
    {
        private int NumConta { get; set; }
        private double Deposito {get; set;}
        private double ContaCorrente {get; set;}
        private double Saque {get; set;}
        public double Taxa = 5.0;
        public double Valor = 0;

        public Banco()
        {

        }
        public Banco(int numconta, double deposito, double contacorrente, double saque)
        {
            NumConta = numconta;
            Deposito = deposito;
            ContaCorrente = contacorrente;
            Saque = saque;

        }
        public int AbrirConta()
        {
            return NumConta;
        }
        public double CC()
        {
            return ContaCorrente;
        }
        public double Depositar()
        {
             return Deposito;
        }
        public double CCAposDeposito()
        {
            return ContaCorrente + Deposito;
        }
        public double Saques()
        {
            return Saque + Taxa;
        }
        public double SaqueFeito()
        {
            return CCAposDeposito() - Saques();
        }

    }
}
