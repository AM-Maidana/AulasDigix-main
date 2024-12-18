using System;
namespace Aula_20_Exercicio
{
    public class Endereco
    {
        public Cidade Cidade { get; set; }
        private string Rua;
        private int Numero;
        private string Bairro;
        private string Cep;

        public Endereco(Cidade cidade, string rua, int numero, string bairro, string cep)
        {
            Cidade = cidade;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cep = cep;
        }
    }
}