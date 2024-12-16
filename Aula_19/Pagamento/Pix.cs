using System;
using System.Dynamic;
namespace Aula_19
{
    public class Pix : Ipagamento
    {
        public string ChavePix { get; set; }
        public string NomeTitular { get; set; }
        public string Cpf { get; set; }
        public double Valor { get; set; }
        public DateTime DataPagamento { get; set; }

        public Pix(string chavePix, string nomeTitular, string cpf, double valor, DateTime dataPagamento)
        {
            ChavePix = chavePix;
            NomeTitular = nomeTitular;
            Cpf = cpf;
            Valor = valor;
            DataPagamento = dataPagamento;
        }
        public void RealizarPagamento(double valor)
        {
            Valor = valor;
            System.Console.WriteLine("Pagamento realizado com sucesso via Pix");
        }
        public void ExibirComprovante()
        {
            System.Console.WriteLine("Comprovante de pagamento via Pix");
            System.Console.WriteLine("Chave pix: " + ChavePix);
        }

    }
}