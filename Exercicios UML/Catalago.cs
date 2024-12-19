using System;
using System.Collections.Generic;

namespace Uml
{
    public class Catalogo
    {
   
        public List<Livros> Livros { get; set; }

        // Construtor
        public Catalogo()
        {
            Livros = new List<Livros>();
        }

 
        public void ExibirLivros()
        {
            if (Livros.Count == 0)
            {
                Console.WriteLine("Nenhum livro no catálogo.");
            }
            else
            {
                Console.WriteLine("Livros no Catálogo:");
                foreach (var livro in Livros)
                {
                    Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Ano: {livro.AnoLivro}, Exemplares: {livro.QtdeDisponivel}");
                }
            }
        }

        public void AdicionarLivro(Livros livro)
        {
            Livros.Add(livro);
        }

        public void RemoverLivro(string titulo)
        {
            Livros livro = Livros.Find(l => l.Titulo == titulo);
            if (livro != null)
            {
                Livros.Remove(livro);
                Console.WriteLine($"Livro '{titulo}' removido com sucesso.");
            }
            else
            {
                Console.WriteLine("erro.");
            }
        }
    }
}
