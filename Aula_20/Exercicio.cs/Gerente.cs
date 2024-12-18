using System;
namespace Aula_20_Exercicio
{
    public class Gerente : Funcionario
    {
        public Gerente(Endereco endereco, string nome, DateTime dataNascimento, string cpf, float salario) : base(endereco, nome, dataNascimento, cpf, salario)
        {}

        public float SalarioGerente(float salario)
        {
            return salario * 4;
        }
    }
}