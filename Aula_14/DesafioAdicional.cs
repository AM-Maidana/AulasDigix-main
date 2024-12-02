/*Exercício Avançado de Lista Duplamente Encadeada
Exercício: Remover Todos os Elementos de um Valor Específico
Crie uma função que remova todas as ocorrências de um valor específico de uma lista duplamente encadeada.

Requisitos:

A função deve percorrer a lista inteira.
Todas as ocorrências do valor especificado devem ser removidas.
A lista deve permanecer íntegra após a remoção (ou seja, os ponteiros Proximo e Anterior devem ser ajustados adequadamente).
Exemplo de Uso:


Copiar código
Lista: 10 <-> 20 <-> 30 <-> 20 <-> 40
Remover(20)
Resultado: 10 <-> 30 <-> 40*/
using System;
namespace Aula14_14
{
        class DesafioAdicional
    {
        class Node
        {
            public int valor;
            public Node? proximo;
            public Node? anterior;
        }
        static Node? inicio = null;

        static void Inserir(int valor)
        {
            Node novoNode = new Node { valor = valor, proximo = null, anterior = null };
            if (inicio == null)
            {
                inicio = novoNode;
            }
            else
            {
                Node atual = inicio;
                while (atual.proximo != null)
                {
                    atual = atual.proximo;
                }
                atual.proximo = novoNode;
                novoNode.anterior = atual;
            }
        }
        static void Excluir(int valor)
{
    if (inicio == null)
    {
        System.Console.WriteLine("Lista vazia");
        return;
    }
    Node atual = inicio;
    while (atual != null)
    {
        if (atual.valor == valor)
        {
            if (atual == inicio)
            {
                inicio = atual.proximo;
                if (inicio != null) 
                {
                    inicio.anterior = null; 
                }
            }
            else
            {
                if (atual.anterior != null)
                {
                    atual.anterior.proximo = atual.proximo;
                }
                if (atual.proximo != null)
                {
                    atual.proximo.anterior = atual.anterior;
                }
            }
        }
        atual = atual.proximo;
    }
}
        static void Listar()
        {
            Node? atual = inicio;
            while (atual != null)
            {
                System.Console.WriteLine(atual.valor);
                atual = atual.proximo;
            }
        }
        static void Main (string[] args)
        {
            Inserir(7);
            Inserir(2);
            Inserir(7);
            Inserir(8);
            Inserir(9);
            Inserir(7);
            System.Console.WriteLine("Lista: ");
            Listar();
            Excluir(7);
            System.Console.WriteLine("Nova lista");
            Listar();
        }
    }
}
    
