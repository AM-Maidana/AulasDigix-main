/* using System;
using System.Collections.Generic;

namespace Aula15_1
{
    class Padaria
    {
        private string NomeAlimento;
        public string Bebidas;
        public string Doces;
        public DateTime Data_validade;
        public double Preco;

        public string EncomendaI()
        {
            return ("Sua encomenda: " + NomeAlimento + " foi cadastrada");
        }
        public double CestaCompras(List<(string nome, double preco)> itens)
        {
            double total = 0;
            foreach (var (nome, preco) in itens)
            {
                Console.WriteLine($"{nome}: R${preco}");
                total += preco; 
            }

            return total; 
        }
        static void Main(string[] args)
        {
            int op = 0;

            Console.WriteLine("Digite o alimento que deseja: " +
            "\n 1 - bolo" +
            "\n 2 - pão" +
            "\n 3 - salgado");
            op = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Padaria padoca = new Padaria();

            switch (op)
            {
                case 1:
                    padoca.NomeAlimento = "bolo";
                    break;
                case 2:
                    padoca.NomeAlimento = "pão";
                    break;
                case 3:
                    padoca.NomeAlimento = "salgado";
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    return;
            }

            Console.WriteLine(padoca.EncomendaI());

            padoca.Doces = "Cuca";
            padoca.Bebidas = "Suco de Laranja";
            padoca.Preco = 7.50; 
            padoca.Data_validade = DateTime.Now.AddDays(10);

            List<(string nome, double preco)> itens = new List<(string nome, double preco)>
            {
                ("Bolo", 15.00),
                ("Pão frances (kg)", 3.50),
                ("Cuca", 7.50),
                ("Suco de Laranja", 5.00)
            };

            double total = padoca.CestaCompras(itens);

            Console.WriteLine($"\nTotal da Cesta: R${total}");
        }
    }
}


*/