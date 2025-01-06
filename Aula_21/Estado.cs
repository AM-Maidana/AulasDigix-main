using System;
using Aula_21;
namespace Aula_21
{
    
        public enum Estado
        {
            SP, RJ, MG, BA
        }
    
    // public class EstecaoEstado
    // {
    //     public static string GetDescricao(Estado estado)
    //     {
    //         switch (estado)
    //         {
    //             case Estado.SP
    //             default:
    //         }
    //     }
    // }
    public class Regiao
    {
        public string[] Regioes = new string[] {"sul", "Sudeste", "Centro Oeste", "Norte", "Nordeste" };

        public string GetRegiao(Estado estado)
        {
            return estado switch
            {
//É possível fazer um switch dentro return pq 
            Estado.SP =>Regioes[0],
            Estado.RJ =>Regioes[1],
            Estado.MG =>Regioes[2],
            Estado.BA =>Regioes[3],
            _ => "Regiao não encontrada",
            };
        }
    }
}