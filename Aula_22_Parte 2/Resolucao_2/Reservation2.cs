// using System;
// namespace Resolucao_2
// {
//     public class Reservation2
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
//         public string UpdateDates(DateTime checkIn, DateTime checkOut)
//         {
//             if (checkIn < DateTime.Now && checkOut < DateTime.Now)
//             {
//                 return "ERRO! As datas para atualização devem ser futuras";
//             }
           
//         }
//     }
// }
