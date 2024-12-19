using System;
using System.Collections.Generic;  // Inclua a biblioteca para usar List<T>

namespace Uml
{
    public class RedeBibliotecas
    {

        public List<Biblioteca> Bibliotecas { get; set; }
        public RedeBibliotecas()
        {
            Bibliotecas = new List<Biblioteca>();
        }

        public void ExibirBibliotecas()
        {
            if (Bibliotecas.Count == 0)
            {
                Console.WriteLine("Nenhuma biblioteca na rede.");
            }
            else
            {
                Console.WriteLine("Bibliotecas: ");
                foreach (var biblioteca in Bibliotecas)
                {
                    Console.WriteLine($"Nome: {biblioteca.GetNome()}; \nEndereço: {biblioteca.GetEndereco()}");
                }
            }
        }


        public void AdicionarBiblioteca(Biblioteca biblioteca)
        {
            Bibliotecas.Add(biblioteca);
            Console.WriteLine($"Biblioteca '{biblioteca.GetNome()}' adicionada à rede.");
        }


        public void RemoverBiblioteca(string nome)
        {
            Biblioteca biblioteca = Bibliotecas.Find(b => b.GetNome() == nome);
            if (biblioteca != null)
            {
                Bibliotecas.Remove(biblioteca);
                Console.WriteLine($"Biblioteca '{nome}' removida com sucesso.");
            }
            else
            {
                Console.WriteLine($"Erro: Biblioteca '{nome}' não encontrada.");
            }
        }
    }
}
