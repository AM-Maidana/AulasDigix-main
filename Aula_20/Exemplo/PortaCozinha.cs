using System;
namespace Aula_20_Exemplo
{
    public class PortaCozinha : Porta
    {
        public PortaCozinha(string cor, float largura, float altura, double peso)  : base (cor, largura, altura, peso)
        {
            
        }
        //subeescrevendo o metodo Abrir
        public override void Abrir()
        {
            System.Console.WriteLine("Porta da cozinha aberta");
        }
        //subeescrevendo o metodo Fechar

        public override void Fechar()
        {
            System.Console.WriteLine("Porta da cozinha fechada");
        }
    }
}
