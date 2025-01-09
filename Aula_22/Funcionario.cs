using System;
namespace Aula_22
{
    public class Funcionario
    {
        public string Nome { get; set; }

        public virtual void Salario(int salario)
        {
            Console.WriteLine("Salario base: " + salario);
        }
        public virtual void Trabalhar()
        {
            Console.WriteLine("Funcionario trabalhando");
        }
    }
}