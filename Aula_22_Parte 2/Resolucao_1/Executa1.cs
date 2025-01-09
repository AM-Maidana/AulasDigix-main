// using System;

// namespace Resolucao_1
// {
//     public class Executar1
//     {
//         public static void Main(string[] args)
//         {
//             Console.Clear();
//             System.Console.WriteLine("Entre com o n° do quarto");
//             int roomNumber = int.Parse(Console.ReadLine());
//             System.Console.WriteLine("Check-in date (dd/MM/yyyy): ");
//             DateTime checkIn = DateTime.Parse(Console.ReadLine());
//             System.Console.WriteLine("Check-out date (dd/MM/yyyy): ");
//             DateTime checkOut = DateTime.Parse(Console.ReadLine());

//             if (checkIn < DateTime.Now && checkOut < DateTime.Now)
//             {
//                 System.Console.WriteLine("Erro na reserva: as datas para reserva devem ser futuras");
//             }
//             else if (checkOut <= checkIn)
//             {
//                 System.Console.WriteLine("Erro na reserva: a data de check-out deve ser posterior à data de check-in");
//             }else
//             {
//                 Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
//                 System.Console.WriteLine("Reserva: " + reservation);
//             }
//         }
//     }
// }