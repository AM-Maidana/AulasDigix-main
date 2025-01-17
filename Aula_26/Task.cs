using System;
namespace Aula26
{
    public class ClasseTestk
    {
        // O ascync é quanndo a função é assincrona, ou seja
        // ela não é executada de forma que o programa não trava enquanto espera o retorno
        //O Task é uma tarefa que é executada de forma

        static async Task Main(string[] args)
        {
            System.Console.WriteLine('Inicio do programa');
            int resultado = await Soma(10, 20);
        }
        static Task<int> Soma(int a, int b)
        {
            Task.Delay(2000).Wait();
            return a +b;
        };
    }
}
