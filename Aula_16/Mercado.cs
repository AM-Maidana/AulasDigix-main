/*using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Xml.Serialization;
using Aula16_1;
using Aula16_2;
using Aula16_3;
using Name;



namespace Aula16_4
{

    class Mercado
    {
        static void Main(string[] args)
        {
            Carnes carnes = new Carnes("Alcatra", 32, 5);
            Laticinios laticinios = new Laticinios("Leite", 4, 3);
            Ferramentas ferramentas = new Ferramentas("Chave de fenda", 17, 5);
            Limpeza limpeza = new Limpeza("Detergente", 2, 10);
            Petiscos petiscos = new Petiscos("Coxinha", 1, 7);

            Console.WriteLine("Produtos:");
            Console.WriteLine();
            Console.WriteLine($"{carnes.NomeCarnes}, {carnes.PrecoCarnes}, qtde: {carnes.QtdeCarnes}");
            Console.WriteLine($"{laticinios.NomeLat}, {laticinios.PrecoLat}, qtde: {laticinios.QtdeLat}");
            Console.WriteLine($"{petiscos.Nome}, {petiscos.Preco}, qtde: {petiscos.Qtde}");
            Console.WriteLine($"{ferramentas.NomeFerramentas}, {ferramentas.PrecoFerramentas}, qtde: {ferramentas.QtdeFerramentas}");
            Console.WriteLine($"{limpeza.NomeLimp}, {limpeza.PrecoLimp}, qtde: {limpeza.QtdeLimp}");

            // double MaiorValor = Math.Max(carnes.CalcularEstoqueCarnes(), 
            // Math.Max(limpeza.CalcularEstoqueLimpeza(), 
            // Math.Max(laticinios.CalcularEstoqueLaticinio(),
            // Math.Max(ferramentas.CalcularEstoqueLimFerramentas(), 
            // Math.Max(petiscos.CalcularEstoque())))));

    int MaiorValor = Math.Max(carnes.CalcularC(), limpeza.CalcularL(),laticinios.CalcularLat(),ferramentas.CalcularF(), petiscos.CalcularP());

        }
    }
}*/