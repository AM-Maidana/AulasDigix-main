using System;

namespace Uml
{
    public class Funcionario : Usuario
    {
        private string Cargo;

        public Funcionario(string nome, string cpf, string cargo) : base(nome, cpf)
        {
            Cargo = cargo;
        }
        public string GetCargo()
        {
            return Cargo;
        }
        public void SetCargo(string cargo)
        {
            Cargo = cargo;
        }
        public void AtualizarCatalogo(Catalogo catalogo)
        {
            Console.WriteLine("1- Adicionar livro novo:");
            Console.WriteLine("2- Excluir livro:");
            int op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                Console.WriteLine("Digite o título do livro:");
                string titulo = Console.ReadLine();

                Console.WriteLine("Digite o autor do livro:");
                string autor = Console.ReadLine();

                Console.WriteLine("Digite o ano de publicação:");
                int anoLivro = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a quantidade de exemplares disponíveis:");
                int qtdeDisponivel = int.Parse(Console.ReadLine());

                Livros livroNovo = new Livros(titulo, autor, anoLivro, qtdeDisponivel);
                catalogo.AdicionarLivro(livroNovo);

                Console.WriteLine($"Livro '{titulo}' adicionado ao catálogo.");
            }
            else if (op == 2)
            {
                Console.WriteLine("Digite o título do livro a ser excluído:");
                string tituloExcluir = Console.ReadLine();

                catalogo.RemoverLivro(tituloExcluir);

                Console.WriteLine($"Livro '{tituloExcluir}' removido do catálogo.");
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        }

        public void RealizarEmprestimo(Leitor leitor, Livros livro)
        {
            if (livro.QtdeDisponivel > 0)
            {
                livro.QtdeDisponivel--;
                Console.WriteLine($"Empréstimo realizado! Livro '{livro.Titulo}' emprestado para {leitor.GetNome()}. Exemplares disponíveis: {livro.QtdeDisponivel}");
            }
            else
            {
                Console.WriteLine($"O livro '{livro.Titulo}' não está disponível para empréstimo.");
            }
        }
    }
}
