// using System;

// namespace Resolucao_2
// {
//     public class Executar2
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

//             Reservation2 reservation = new Reservation2(roomNumber, checkIn, checkOut);

//             string error = reservation.UpdateDates(checkIn, checkOut);
//             if (error != null) // Se o erro for diferente de nulo
//             {
//                 System.Console.WriteLine(error);
//             }
//             else
//             {
//                 System.Console.WriteLine("Reservation: " + reservation);
//             }
//         }
//     }
// }
