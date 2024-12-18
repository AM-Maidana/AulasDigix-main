using System;
using System.Runtime.ConstrainedExecution;
namespace Aula_20.Relacionamento
{
    public class Escola
    {
        private Aluno estudante;
        private Professor professor;

        public Escola(string nomeEstudante)
        {
            estudante = new Aluno(nomeEstudante);
        }
        //metodo p/ agregação (que recebe de forma externa o profesor)
        public void ContratarProfessor(Professor professor)
        {
            this.professor = professor;
        }
        //mostrar detalhes
        public void MostrarInfo()
        {
            System.Console.WriteLine($"Nome do aluno: {estudante.Nome}");
            System.Console.WriteLine($"Nome do professor: {professor.Nome}");
            System.Console.WriteLine();
        }
    }
}