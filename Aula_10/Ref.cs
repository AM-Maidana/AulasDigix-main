/* using System;

namespace Aula10_2
{
    class Ref
    {
        static int Quadrado(int x)
        {
            return x * x;
        }
        // Usando ref para ´passar a variavel por referencia
        static void QuadradoRef(ref int x)
        {
            x = x * x;
        }
        //out é usado para passar a variavel referencia, mas nao é a
        static int QuadradoOut(out int y)
        {
            y = 6;
            return y * y;
        }
// / / / / /  / / /  MAIN / / / / / / / / / / / / 
        static void teste2(string[] args)
        {
            int a = 10;
            //Console.WriteLine(Quadrado(a));
            //Console.WriteLine(a);
            //QuadradoRef(ref a);
            //Console.WriteLine(a);

            a = Quadrado(a);
            Console.WriteLine(a);

            // diferente do ref o out nao precisa declarar a variavel na "main" pode se declarar na função msm.
            int y;
            QuadradoOut(out y);
            Console.WriteLine(y);


        }
    }
}

*/