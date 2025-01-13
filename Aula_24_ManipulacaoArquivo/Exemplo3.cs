// using System;
// namespace Aula24
// {
//     public class Exemplo3
//     {
//         public void Exe3()
//         {
//         string inicioParh = @"C:\Users\amandamaidana\Desktop\Teste.txt";

//         try
//         {
//             using (FileStream fs = new FileStream(inicioParh, FileMode.Open))
//             {
//                 using (StreamReader sr = new StreamReader(fs))
//                 {
//                     string line = sr.ReadLine();
//                     System.Console.WriteLine(line);
//                 }
//             }

//         }
//         catch (IOException e)
//         {
            
//             System.Console.WriteLine("Ocorreu um erro");
//             System.Console.WriteLine(e.Message);
//         }
//     }
// }
// }