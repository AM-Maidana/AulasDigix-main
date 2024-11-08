/*
using System;

namespace Aula_9{
class Program{
// Sobrecarga da função
    static int ParOuImpar (int num){
           if (num % 2 == 0)
        {
            return 0;
        }
        else
        {
        return 1;
    }

    }
    static string ParOuImpar (double num){
        if (num % 2 == 0)
        {
            return "par";
        }
        else
        {
        return "Impar";
    }
    }
////////////////////////////////////
// Sem parametros
    static void Pi()
    {
        System.Console.WriteLine("3.14");;
    }

    static void Main (string[] args)
    {

//chamando a função --- sobrecarga
        System.Console.WriteLine("Digite um número");
        int num  =  int.Parse(Console.ReadLine());

        System.Console.WriteLine("O número é: " + ParOuImpar(num));
//---------------------------------------------------------------------------
// chamando a funçãi sem parametro

        System.Console.WriteLine(Pi());
//---------------------------------------------------------------------------

    }
}
}
*/