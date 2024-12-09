using System;
namespace Aula17_2
{
    public class Gerente : Funcionario
    {
        // Construtor
        public Gerente(string nome, double salario) :  base (nome, salario, "Gerente")
        {

        }
        // Chamar metodo publico da classe base
        public void Imprimir()
        {
            Dados();
        }
        // metodo protegido
        public void AtualizarGerente(string novoCargo)
        {
            AtualizarCargo(novoCargo);
        }
        // metodo privado
        public void CalcularImpostoGerente(){
            //System.Console.WriteLine(CalcularImposto());
        }
    }
}