// using System;
// namespace Aula23
// {
//     public struct PessoaStruct
//     {

//     }

//     class ExecutarExe
//     {
//         public static void ExecutarExemplo1()
//         {
//             // Trabalha com a struct Pessoa
//             PessoaStruct pessoaStruct1 = new PessoaStruct("João", 25);
//             PessoaStruct pessoaStruct2 = pessoaStruct1;
//             pessoaStruct2.Nome = "Maria";

//             System.Console.WriteLine(pessoaStruct1);
//             System.Console.WriteLine(pessoaStruct2);

//             //Trabalha com a classe Pessoa
//             PessoaClasse pessoaClasse1 = new PessoaClasse("João", 25);
//             PessoaClasse pessoaClasse2 = pessoaClasse1;
//             pessoaClasse2.Nome = "Maria";

//             System.Console.WriteLine(pessoaClasse1);
//             System.Console.WriteLine(pessoaClasse2);

//             //1. Struct é um tipo de valorm então atribuições criam copias independentes
//             //2. Classe é um tipo de referência, então atribuições criam referências para o mesmo objeto    
//             //3. Struct são mais leves e geralmente são usados para dados simples e imutáveis.
//             //4. Classes são mais pesadas e são usadas para objetos mais complexos e com estados mutaveis e comportam entidades.    
//         }
//     }
// }