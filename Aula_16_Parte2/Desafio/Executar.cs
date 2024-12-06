using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
namespace Desafio
{
    class Executar
    {
        static void Main(string[] args)
        {
            Cobra C = new Cobra(true, false);
            Javali J = new Javali(true, true);
            

            System.Console.WriteLine("Cobra");
            C.ImprimirDados();
            System.Console.WriteLine(C.TipoAlimento());

System.Console.WriteLine();
            System.Console.WriteLine("Javali");
            J.ImprimirDados();
            System.Console.WriteLine("Velocidade máxima: " + J.GetVelocidade());



        }
    }
}