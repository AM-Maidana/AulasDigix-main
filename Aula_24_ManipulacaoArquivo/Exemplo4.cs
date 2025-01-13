// using System;
// namespace Aula24
// {
//     public class Exemplo4
//     {
//         public static void Main(string[] args)
//         {
//          string inicioParh = @"C:\Users\amandamaidana\Desktop\Teste.txt";
//          string finalParh = @"C:\Users\amandamaidana\Desktop\Teste.txt";
          

//          try
//          {
//           //  string [] lines = FileReadLines(inicioParh);
//             using (StreamWriter sw = File.AppendText(finalParh))
//             {
//                 foreach (string item in lines)
//                 {
//                     sw.WriteLine(item.Reverse(). ToArray());
//                 }
//             }

//          }
//           catch (IOException e)
//         {
            
//             System.Console.WriteLine("Ocorreu um erro");
//             System.Console.WriteLine(e.Message);
//         }
//         }
//     }
// }