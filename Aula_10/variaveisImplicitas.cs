/* using System;

namespace Aula10_1{
    class variaveisImplicitas
    {
// / / / / / / /   MAIN   / / / / / /  / /  / 
      static void teste(string[]args)
        {
// variavel implicita é uma variavel que pode receber qualquer =============================================
             var nome = "C#";
            Console.WriteLine(nome);
            Console.WriteLine(nome.GetType());

            var idade = 20;
            Console.WriteLine(idade);
            Console.WriteLine(idade.GetType());

            const double pi = 3.1415; // const é constituida - tem que informar a tipagem dele 
            Console.WriteLine(pi);
            Console.WriteLine(pi.GetType());

// Lista ==================================================================================================    
/var lista = new List<int> {1,2,3,4,5};
Console.WriteLine(lista);
Console.WriteLine(lista.GetType());
// função para listar os elementos da lista 
foreach (var item in lista)
{
    Console.WriteLine(item); 
}
// Dicionário =============================================================================================
   var Dicionario = new Dictionary<string, int>
     {
         {"C#", 1},
         {"Java", 2},
         {"Python", 3}
     };
     Console.WriteLine(Dicionario);
     foreach (var item in Dicionario)
     {
         Console.WriteLine(item);
     }
 }
}
}
*/
