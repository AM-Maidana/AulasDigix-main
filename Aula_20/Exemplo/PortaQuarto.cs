using System;
using System.IO.Compression;
namespace Aula_20_Exemplo
{
    public class PortaQuarto : Porta
    {
        public PortaQuarto(string cor, float largura, float altura, double peso) : base (cor, largura, altura, peso)
        { }
        public override void Abrir()
        {
            System.Console.WriteLine("Porta do quarto aberta");
        }
        //subeescrevendo o metodo Fechar

        public override void Fechar()
        {
            System.Console.WriteLine("Porta do quarto fechada");
        }
    }
}