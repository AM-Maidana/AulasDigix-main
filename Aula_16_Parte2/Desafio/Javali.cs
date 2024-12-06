using System;
namespace Desafio
{
    class Javali : Animal
    {
        public bool Selvagem;
        public int Velocidade;

        public Javali(bool vivo, bool selvagem) :  base (vivo)
        {
            this.Selvagem = selvagem;
        }

        public int GetVelocidade()
        {
            return 80;
        }
        public override void ImprimirDados()
        {
            System.Console.WriteLine("O animal está vivo? : " + Vivo);
            System.Console.WriteLine("O Javali é Selvagem?  " + Selvagem);

        }
    }
}