using System;
namespace Aula_19
{
    public interface Ipagamento
    {
        void RealizarPagamento(double valor); 
        void ExibirComprovante(); // isso é implicitamente um método público
    }
}