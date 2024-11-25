/*using System;

namespace Aula14_4
{
    public class ListaEncadeadaDelegate
    {
        static delegate void FuncaoDelegate(int valor);
        static FuncaoDelegate? inicio = null;
        
        static FuncaoDelegate CriarNo(int valor, FuncaoDelegate? proximo)
        {
            return v =>
            {
                System.Console.WriteLine(valor);
                proximo?.Invoke(v);
            };

        }

    }
}
*/