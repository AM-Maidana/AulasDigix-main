using System;
using   Aula24_Banco;
using ClosedXML.Excel;

namespace Aula24_Banco
{
    public class ExecutarBanco
    {
        static void Main(string [] args)
        {
            var cliente = new Customer("Joao de Deus");
            var contaCorrente = new CurrentAccount(1234, cliente, 500);
            var contaPoupanca = new SavingAccount(5421, cliente, 0.01);

            contaCorrente.Depositar(100);
            contaCorrente.Sacar(50);

            contaPoupanca.Depositar(500);
            contaPoupanca.AplicarRendimento();

            GerarExcel(new List<Account> {contaCorrente, contaPoupanca});

        }

        public static void GerarExcel(List<Account> contas)
        {
            // geração de excel
            //vamos instalar o ClosedXML
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.AddWorksheet("Contas Bancarias");

                //cabeçalho
                worksheet.Cell(1,1).Value = "Numero da conta"; //cell é a célula no excel
                worksheet.Cell(1,2).Value = "Numero do Cliente";
                worksheet.Cell(1,3).Value = "Tipo da Conta";
                worksheet.Cell(1,4).Value = "Saldo";

                //configurar para preencher a partir da linha 2
                int row = 2;
                foreach (var item in contas)
                {
                    worksheet.Cell(row, 1).Value = item.NumeroConta;
                    worksheet.Cell(row, 2).Value = item.Cliente.Nome;
                    worksheet.Cell(row, 3).Value = item.TipoConta.ToString();
                    worksheet.Cell(row, 4).Value = item.Saldo;
                    row++; // Para ir para a próxima linha ai sucessivamente
                }

                workbook.SaveAs("ContasBancarias.xlsx");
                System.Console.WriteLine("Arquivo excel gerado com sucesso");

            }
        }
    }
}