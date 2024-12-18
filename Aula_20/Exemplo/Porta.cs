using System;
using System.IO.Compression;
namespace Aula_20_Exemplo
{
    public class Porta
    {
        public string Cor { get; set; }
        public float Largura { get; set; }
        public float Altura { get; set; }
        public double Peso { get; set; }


        public Porta(string cor, float largura, float altura, double peso)
        {
            Cor = cor;
            Largura = largura;
            Altura = altura;
            Peso = peso;
        }
        //metoddos que serão herdados
        public virtual void Abrir()
        {
            System.Console.WriteLine("Porta Aberta");
        }
        public virtual void Fechar()
        {
            System.Console.WriteLine("Porta Fechada");
        }

    }
}