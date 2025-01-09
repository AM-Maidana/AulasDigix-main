using System;
namespace Aula_22
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            f.Salario(1000);
            f.Trabalhar();
            Console.WriteLine("===================================");
            Gerente g = new Gerente();
            g.Salario(1000);
            g.Trabalhar();
            Console.WriteLine("===================================");
            Coordenador c = new Coordenador();
            c.Salario(1000);
            c.Trabalhar();
            Console.WriteLine("===================================");
            Instrutor i = new Instrutor();
            i.Salario(1000);
            i.Trabalhar();
        }
    }
}