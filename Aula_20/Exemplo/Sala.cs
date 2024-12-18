using System;
using System.IO.Compression;
using System.Reflection;
namespace Aula_20_Exemplo
{
     public class Sala
    {
        // Composição de entrada do porta da sala
        // Propriedade
        public PortaSala PortaSala { get; set; }
        public Porta PortaAuxiliar { get; set; }
        public float MetragemQuadrada { get; set; }

        // Construtor
        public Sala(PortaSala portaSala, Porta portaAuxiliar, float metragemQuadrada)
        {
            PortaAuxiliar = portaAuxiliar;
            MetragemQuadrada = metragemQuadrada;
            // Vou fazer a relação de composição
            PortaSala = new PortaSala(portaSala.Cor, portaSala.Largura, portaSala.Altura, portaSala.Peso);
        }

        // Metodo utilizando a porta da sala auxiliar
        public void AbrirPortaAuxiliar()
        {
            // Fazendo uma Associação simples da classe Porta
            PortaAuxiliar.Abrir();
        }
    }
}