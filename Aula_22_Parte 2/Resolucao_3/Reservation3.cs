using System;
namespace Reservation_3
{
    // public class Reservation3
    // {
    //     public int RoomNumber { get; set; }
    //     public DateTime CheckIn { get; set; }
    //     public DateTime CheckOut { get; set; }

    //     public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
    //     {
    //        public void UpdateDates(DateTime checkIn, DateTime checkOut)
    //     {
    //         if (checkIn < DateTime.Now || checkOut < DateTime.Now)
    //         {
    //             //throw new é uma exceção que é lançada quando um erro é encontrado
    //             throw new DomainException("Erro na reserva: as datas para reserva devem ser futuras");
    //         }
    //         if (checkOut <= checkIn)
    //         {
    //             // A exceção DomainException é lançada com a mensagem de erro a seguir
    //             // DomainException é uma exceção personalizada, mas ainda fica dentro do padrão de exceções do C#
    //             throw new DomainException("Erro na reserva: a data de check-out deve ser posterior à data de check-in");
    //         }
    //         RoomNumber = roomNumber;
    //         CheckIn = checkIn;
    //         CheckOut = checkOut;
    //     }            
    //     }        
    //     public int Duration()
    //     {
    //         TimeSpan timeSpan = CheckOut.Subtract(CheckIn);//Substract faz a diferença entre duas datas
    //         return (int)timeSpan.TotalDays;//TotalDays retorna a diferença em dias
    //     }
    //     public override string ToString()
    //     {
    //         return "Quarto " + RoomNumber + ", check-in: " + CheckIn.ToString("dd/MM/yyyy") + ", check-out: " + CheckOut.ToString("dd/MM/yyyy") + ", " + Duration() + " noites";
    //     }
    // }
}