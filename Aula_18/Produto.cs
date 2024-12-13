using System;
namespace Aula_18
{
    public class Produto
    {
        //private string Nome; // Convenção de nomeclatura do C#: Nome
// Propriedade autoimplementada
private string Nome {get; set;}
        private double _preco;
        private int _qtde;

        // Construtor padrão
        public Produto()
        {

        }
        // construtor com 2 argumentos

        public Produto(string nome, double preco)
        {
            Nome = nome;
            _preco = preco;
        }

        // Reutilizando construtor dentro de outro construtor
        public Produto(string nome, double preco, int _qtde) : this(nome, preco) //Base: herança // this : refêrencia
        {
            _qtde = _qtde;
        }
        // Encapsulamento, que é Get(retornar) e Det(alterar) de atributos privados
        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
            Nome = nome;
            }
        }
        // public double GetPreco()
        // {
        //     return _preco;
        // }
        // public void SetPreco(double preco)
        // {
        //     if (preco > 0 && preco < 100000)
        //     {
        //     _preco = preco;
        //     }
        // }

        //PROPRIEDADE DO C# PARA FAZER O GET E SET -- 
        public double Preco
        {
            get
            {
                return _preco;
            }
            set
            {
                if ((value > 0) && (value < 1000000))
                {
                    _preco = value;
                }
            }
        }
        public int GetQtde()
        {
            return _qtde;
        }
        public void SetQtde(int qtde)
        {
            _qtde = qtde;
        }
        // Fubção adicionar valor em estoque
        public void AdicionarEstoque(int qtde)
        {
            _qtde += qtde;
        }
        //Função remover em estoque
        public void RemoverEstoque(int qtde)
        {
            _qtde -= qtde;
        }
        // Função calcular valot total em estoque
        public double ValorEstoque()
        {
            return _preco * _qtde;
            //Get {return _preco * _qtde}
        }

        // função TOString
        public override string ToString()
        {
            return Nome + ", $" + _preco.ToString("F2") + ", " + _qtde + "unidades, Total $ " + ValorEstoque().ToString("F2");
        }

    }
}

