using System;
namespace Uml
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Leitor leitor = new Leitor("Amanda", "111.222.333-77");


            Biblioteca biblioteca = new Biblioteca("Biblioteca 1", "R. lalala");
            Biblioteca biblioteca1 = new Biblioteca("Biblioteca 2", "R. Mimimi");

            Funcionario funcionario = new Funcionario("Luiz Victor", "123.456.789-97", "assistente");
            Funcionario funcionario1 = new Funcionario("Cleitin", "987.654.321-10", "gerente de arquivo");
            Funcionario funcionario2 = new Funcionario("Maria", "741.852.963-58", "assistente");


            Livros livros = new Livros("O senhor dos aneis", "Fulano", 2000, 5);
            Livros livros1 = new Livros("Harry Potter", "Fulana lá", 1990, 7);
            Livros livros2 = new Livros("Cinderela", "Disney", 1900, 3);

            Livros livros3 = new Livros("Branca de neve", "disney", 1880, 10);
            Livros livros4 = new Livros("Joao e maria", "Alguem", 1970, 3);


            Catalogo catalogo = new Catalogo();
            Catalogo catalogo1 = new Catalogo();
            catalogo.AdicionarLivro(livros);
            catalogo.AdicionarLivro(livros1);
            catalogo.AdicionarLivro(livros2);

            // == biblioteca 1
            biblioteca.AdicionarFuncionario(funcionario);
            biblioteca.AdicionarFuncionario(funcionario2);

            System.Console.WriteLine();
            biblioteca.ExibirFuncionarios();

            System.Console.WriteLine();
            biblioteca.RemoverFuncionario(funcionario2);
            System.Console.WriteLine();
            biblioteca.ExibirFuncionarios();
            System.Console.WriteLine();


            // == biblioteca 2
            System.Console.WriteLine("================= BIBLIOTECA 2 ===============");
            biblioteca1.AdicionarFuncionario(funcionario1);
            biblioteca1.ExibirFuncionarios();
            System.Console.WriteLine();

            // == biblioteca x catalogo
            System.Console.WriteLine("======= Biblioteca gerenciando o catalogo: =====");
            biblioteca.AtualizarCatalogo();
            System.Console.WriteLine();
            catalogo.ExibirLivros();
            System.Console.WriteLine();

            // == funcionario x catalogo
            System.Console.WriteLine("===== Funcioanrio gerenciando o catalogo: =====");
            funcionario.AtualizarCatalogo(catalogo);
            System.Console.WriteLine();


            // catalogo:
            catalogo.ExibirLivros();
            catalogo1.ExibirLivros();
            System.Console.WriteLine();

            // == Leitor:            
            leitor.PegarEmprestado(livros);
            System.Console.WriteLine($"{leitor.GetNome()} pegou emprestado o livro: {livros.Titulo}");

// == Livros

        }
    }
}