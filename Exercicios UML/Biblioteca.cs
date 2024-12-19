using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Uml
{
    public class Biblioteca
    {
        private string Nome;
        private string Endereco;
        private List<Funcionario> funcionarios; 
        private Catalogo catalogo; 
     
        public Biblioteca(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
            funcionarios = new List<Funcionario>();
            catalogo = new Catalogo();  
        }

        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public string GetEndereco()
        {
            return Endereco;
        }
        public void SetEndereco(string endereco)
        {
            Endereco = endereco;
        }
// Add Funcionario
        public void AdicionarFuncionario(Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
            Console.WriteLine($"Funcionário {funcionario.GetNome()} adicionado à biblioteca: {GetNome()}");
        }
        public void RemoverFuncionario(Funcionario funcionario)
        {
            funcionarios.Remove(funcionario);
            Console.WriteLine($"Funcionário {funcionario.GetNome()} removido da biblioteca.");
        }
        public void ExibirFuncionarios()
        {
            if (funcionarios.Count > 0)
            {
                Console.WriteLine($"Funcionários da Biblioteca: {GetNome()}");
                foreach (var funcionario in funcionarios)
                {
                    Console.WriteLine($"Nome: {funcionario.GetNome()}; \nCargo: {funcionario.GetCargo()}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum funcionário na biblioteca.");
            }
        }

        // Biblioteca gerenciando os livros
        public void AtualizarCatalogo()
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
    }
}
