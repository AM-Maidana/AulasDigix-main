/*using System;
using System.Security.Cryptography;
namespace Aula16_parte2
{
    class Empresa
    {
        static void Main(string[] args)
        {
            Gerente G = new Gerente("Luiz", "123-456-789-10", 5000, "Vendas");
            System.Console.WriteLine("Salário gerente: " + G.Salario);
            System.Console.WriteLine("Bonificacao: " + G.GetBonificacao());
            System.Console.WriteLine("Função do gerente: ");
            G.GerirEquipes();
            G.ImprimirDados();
            System.Console.WriteLine("============================================");
            Secretaria S = new Secretaria("Anna", "123-456-789-10", 2000, "2204");
            System.Console.WriteLine("Salário secretaria: " + S.Salario);
            System.Console.WriteLine("Bonificacao: " + S.GetBonificacao());
            System.Console.WriteLine("Função da secretaria: ");
            S.AtenderTelefone();
            S.ImprimirDados();
            System.Console.WriteLine("============================================");

            Telefonista T = new Telefonista("Luiz", "123-456-789-10", 5000, "Vendas");
            System.Console.WriteLine("Salário Telefonista: " + T.Salario);
            System.Console.WriteLine("Bonificacao: " + T.GetBonificacao());
            System.Console.WriteLine("Função doTelefonista: ");
            T.AtenderTelefone();
            T.ImprimirDados();
        }
    }
}
*/