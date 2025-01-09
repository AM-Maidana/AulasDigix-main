using System;
namespace Aula_22
{
    public sealed class Gerente : Funcionario //sealed é quando nao pode ser herdado
    {
        public override void Salario(int salario)
        {
            Console.WriteLine("Salario base: " + salario * 1.5);
        }
        public override void Trabalhar()
        {
            Console.WriteLine("Gerente trabalhando");
        }
    }    
}