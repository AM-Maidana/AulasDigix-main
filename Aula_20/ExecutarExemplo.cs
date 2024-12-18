using System;
using System.IO.Compression;
namespace Aula_20_Exemplo
{
    public class ExecutarExemplo
    {
        static void Teste(string[] args)
        {
            Console.WriteLine("Herança");
            PortaCozinha portaCozinha = new PortaCozinha("Branca", 1.5f, 2.5f, 10);
            portaCozinha.Abrir();
            portaCozinha.Fechar();
            Console.WriteLine($"portaCozinhaCozinha: Cor: {portaCozinha.Cor}, Largura: {portaCozinha.Largura}, Altura: {portaCozinha.Altura}, Peso: {portaCozinha.Peso}");

System.Console.WriteLine();

            Console.WriteLine("Agregação");
            Cozinha cozinha = new Cozinha(true, 20);
            cozinha.Entrar(portaCozinha);

System.Console.WriteLine();

            Console.WriteLine("Composição");
            PortaQuarto portaQuarto = new PortaQuarto("Marrom", 1.5f, 2.5f, 10);
            Quarto quarto = new Quarto(true, 20);
            Console.WriteLine($"quarto: {quarto.PortaQuarto.Cor}");

System.Console.WriteLine();

            Console.WriteLine("Associação simples");
            PortaSala portaSala = new PortaSala("Azul", 1.5f, 2.5f, 10);
            Sala sala = new Sala(portaSala, portaQuarto, 20);
            sala.AbrirPortaAuxiliar();
        }
    }
}
