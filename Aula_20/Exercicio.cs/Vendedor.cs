using System;
using System.Reflection;
namespace Aula_20_Exercicio
{
    public class Vendedor : Funcionario
    {
        private EquipeVenda EquipeVenda {get; set;}
        
         public Vendedor(string nome, DateTime dataNascimento, string cpf, Endereco endereco, EquipeVenda equipeVenda, float salario) : base(endereco, nome, dataNascimento, cpf, salario)
        {
     
            EquipeVenda = new EquipeVenda("Automóveis");
        }
        public float SalarioVendedor(float salario)
        {
            return salario * 2;
        }
        
        
    }
}