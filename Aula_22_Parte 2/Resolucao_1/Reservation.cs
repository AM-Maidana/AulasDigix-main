// using System;
// namespace Resolucao_1
// {
//     public class Reservation
//     {
//         public int RoomNumber { get; set; }
//         public DateTime CheckIn { get; set; }
//         public DateTime CheckOut { get; set; }

//         public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
//         {
//             RoomNumber = roomNumber;
//             CheckIn = checkIn;
//             CheckOut = checkOut;
//         }
//         public int Duration()
//         {
//             TimeSpan timeSpan = CheckOut.Subtract(CheckIn);//Substract faz a diferença entre duas datas
//             return (int)timeSpan.TotalDays;//TotalDays retorna a diferença em dias
//         }
//         public override string ToString()
//         {
//             return "Quarto " + RoomNumber + ", check-in: " + CheckIn.ToString("dd/MM/yyyy") + ", check-out: " + CheckOut.ToString("dd/MM/yyyy") + ", " + Duration() + " noites";
//         }
//         public void UpdateDates(DateTime checkIn, DateTime checkOut)
//         {
//             CheckIn = checkIn;
//             CheckOut = checkOut;
//         }
//     }
// }