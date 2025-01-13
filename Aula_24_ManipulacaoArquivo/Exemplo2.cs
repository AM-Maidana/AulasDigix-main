// using System;
// namespace Aula24
// {
//     public class Exemplo2
//     {
      
//       public void Exe2()
//         {
//             string inicioParh = @"C:\Users\amandamaidana\Desktop\Teste.txt";
//             FileStream fs = null; // Essa é uma classe que permite leitura e escrita de arquivos, e é uma classe de baixo nível
//             StreamReader sr = null; // Também classe de manipulção de arquivo como FileStream mas

//             try
//             {
//                 fs = new FileStream(inicioParh, FileMode.Open); //abre

//                 sr = new StreamReader(fs);
//                 string line = sr.ReadLine();
//                 System.Console.WriteLine(line);


//                 while(line != null)
//                 {
//                     line = sr.ReadLine();
//                     System.Console.WriteLine(line);
//                 }
//             }
//             catch (IOException e)
//             {
//                 System.Console.WriteLine("Ocorreu um erro");
//                 System.Console.WriteLine(e.Message);
//             }
//             finally
//             {
//                 //eu preciso fechar o arquivo, pos o sistema op nao faz issso
//                 if (sr != null) sr.Close();
//                 if (fs != null) fs.Close();
//             }
//         }
//     }
// }