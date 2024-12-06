using System;
namespace Desafio
{
    class Animal
    {
        public bool Vivo;

        public Animal(bool vivo)
        {
            this.Vivo = vivo;
        }
        public virtual void ImprimirDados()
        {
            System.Console.WriteLine("O animal está vivo? : " + Vivo);
        }
    }
}