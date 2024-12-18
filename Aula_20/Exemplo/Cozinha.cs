using System;
using System.IO.Compression;
namespace Aula_20_Exemplo
{
    public class Cozinha
    {
        public PortaCozinha PortaCozinha { get; set; }
        public bool Americana { get; set; }
        public float MetragemQuadrada { get; set; }

        public Cozinha(bool americana, float metragemquadrada)
        {
            Americana = americana;
            MetragemQuadrada = metragemquadrada;
        }
        public void Entrar(PortaCozinha portaCozinha)
        {
            Console.WriteLine("Entrou pela porta da cozinha " + portaCozinha.Cor +
                              " Largura: " + portaCozinha.Largura +
                              " Altura: " + portaCozinha.Altura +
                              " Peso: " + portaCozinha.Peso);
        }

    }
}