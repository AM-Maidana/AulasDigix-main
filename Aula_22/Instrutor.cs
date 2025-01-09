using System;
namespace Aula_22
{
    public class Instrutor : Coordenador
    {
        public override void Salario(int salario)
        {
            Console.WriteLine("Salario base: " + salario * 1.1);
        }
        // public override void Trabalhar()
        // {
        //     Console.WriteLine("Instrutor trabalhando");
        // }
    }
}