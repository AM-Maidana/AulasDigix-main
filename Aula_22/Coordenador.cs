using System;
namespace Aula_22
{
    public class Coordenador : Funcionario
    {
        public override void Salario(int salario)
        {
            Console.WriteLine("Salario base: " + salario * 1.2);
        }
        public sealed override void Trabalhar()
        {
            Console.WriteLine("Coordenador trabalhando");
        }
    }
}