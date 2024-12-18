using System;
using System.Reflection.Metadata.Ecma335;
namespace Desafio2_Aula17
{
   public abstract class Produto
    {
        public int Codigo;
        public double Preco;

        // construtor
        public Produto(int codigo, double preco)
        {
            Codigo = codigo;
            Preco = preco;
        }

        public abstract void setCodigo(int codigo);
        public abstract void setPreco(double preco);
        public abstract int getCodigo();
        public abstract double getPreco();
        public abstract void atualizarPreco(double preco);

    }
}