using System;
using System.Reflection.Metadata;
namespace Desafio
{
    class Cobra : Animal
    {
        public bool Veneno;

        public Cobra(bool vivo, bool veneno) : base(vivo)
        {
            this.Veneno = veneno;
        }
        public string TipoAlimento()
        {
            return "Tipo do alimentação: Carnívora";
        }
          public override void ImprimirDados()
        {
            System.Console.WriteLine("O animal está vivo? : " + Vivo);
            System.Console.WriteLine("A cobra é venenosa: " + Veneno);
            
        }
        
    }
}