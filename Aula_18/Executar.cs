/*using System;
using System.Dynamic;
using System.Reflection;
using System.Reflection.Emit;
namespace Aula_18
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Bomba Atomica", 10000);
            //alterra
            p.SetNome("Bomba Nuclear");
            // alterar preço
            p.Preco = 20000;
            // aletar a qtde
            p.SetQtde(20);
            //imprimir
            System.Console.WriteLine("Nome: " + p.GetNome() + "Preco: " + p.Preco + "qtde: " + p.GetQtde());

            System.Console.WriteLine(p.ToString());

            //Algumas funções para validar seus tipo e Propriedades
            // A classe type representa metadados de uma vlasse em tempo de execução
            Type t = typeof(Produto); // -- retorna o tipo da classe
            System.Console.WriteLine(t.Name); //retorna o nome da clsse;


            // Mostrar todas as suas propriedades:
            System.Console.WriteLine("Propriedades: ");
            foreach (PropertyInfo prop in t.GetProperties())
            {
                System.Console.WriteLine(prop.Name);    
            }
        }
    }
}*/