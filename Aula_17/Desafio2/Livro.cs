using System;
using System.Net.WebSockets;
using System.Security.Permissions;
namespace Desafio2_Aula17
{
     public class Livro : Produto
    {
        public string Autor;
        public long ISBN;

        // construtor
        public Livro(int codigo, double preco, string autor, long isbn) : base(codigo, preco)
        {
            Autor = autor;
            ISBN = isbn;
        }

        public override void setCodigo(int codigo)
        {
            Codigo = codigo;
        }

        public override void setPreco(double preco)
        {
            Preco = preco;
        }

        public override int getCodigo()
        {
            return Codigo;
        }

        public override double getPreco()
        {
            return Preco;
        }

        public override void atualizarPreco(double preco)
        {
            Preco = preco;
        }
    }
}