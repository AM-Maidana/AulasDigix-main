using System;
namespace Aula_19
{
    public class CartaoCredito : Ipagamento, IAnuidade
    {
        public string NumCartao {get; set;}
        public DateTime DataVencimento {get; set;}
        public double ValorAnuidade {get; set;}
        // construtor
        public CartaoCredito(string numCartao, DateTime dataVencimento, double valorAnuidade)
        {
            NumCartao = numCartao;
            DataVencimento = dataVencimento;
            ValorAnuidade = valorAnuidade;
        }
        public void RealizarPagamento(double valor)
        {
            System.Console.WriteLine($"Pagamento de R$ {valor} realizado com sucesso!");
        }
        public void ExibirComprovante()
        {
            System.Console.WriteLine($"Comprovante de pagamento com o cartão {NumCartao} -- dia: {DataVencimento}");
        }
        public DateTime CalcularDataVencimento()
        {
            return DateTime.Now.AddYears(1);
        }
        public double CalcularValorAnuidade()
        {
            return 100;
        }
    }
    }

