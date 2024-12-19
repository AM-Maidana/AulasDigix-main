using System;

namespace Uml
{
    public class Livros
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoLivro { get; set; }
        public int QtdeDisponivel { get; set; }

        public Livros(string titulo, string autor, int anoLivro, int qtdeDisponivel)
        {
            Titulo = titulo;
            Autor = autor;
            AnoLivro = anoLivro;
            QtdeDisponivel = qtdeDisponivel;
        }
        public void ExibirListaLivros()
        {
            
        }
    }
}
