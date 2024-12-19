using System;
namespace Uml
{
    public class Leitor : Usuario
    {
        public Leitor(string nome, string cpf) : base(nome, cpf)
        {
            
        }
         public void PegarEmprestado(Livros livro)
        {
            if (livro.QtdeDisponivel > 0)
            {
                livro.QtdeDisponivel--;
                System.Console.WriteLine($"Livro '{livro.Titulo}' emprestado a: {GetNome()}. Exemplares disponíveis: {livro.QtdeDisponivel}");
            }
            else
            {
                System.Console.WriteLine($"O livro '{livro.Titulo}' não está disponível para empréstimo.");
            }
        }
    }
}