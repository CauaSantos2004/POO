using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Colecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criamos uma lista de nomes (texto simples)
            List<string> nomes = new List<string>();
            nomes.Add("Gustavo"); // adiciona "Gustavo" na lista
            nomes.Add("Celso");   // adiciona "Celso" na lista

            // Criamos uma lista de alunos (cada item será um objeto da classe Aluno ou AlunoEspecial)
            List<Aluno> alunos = new List<Aluno>();

            // Criando um aluno normal
            Aluno suely = new Aluno { id = 1, Nome = "Suely" };

            // Criando um aluno especial (além de ID e Nome, também tem Deficiencia)
            AlunoEspecial celso = new AlunoEspecial { id = 2, Nome = "Celso", Deficiencia = "Muito Doido" };

            // Adicionamos os dois alunos na lista
            alunos.Add(suely);
            alunos.Add(celso);

            // Adicionamos outro aluno diretamente (sem criar variável antes)
            alunos.Add(new Aluno { id = 3, Nome = "Gustavo" });

            // Também adicionamos o nome da Suely na lista de nomes
            nomes.Add(suely.Nome);

            // --- Impressão dos nomes ---
            Console.WriteLine("Impressão dos nomes");
            foreach (string nome in nomes) // percorre cada nome da lista
            {
                Console.WriteLine($" - {nome}"); // escreve o nome na tela
            }

            // --- Impressão dos alunos ---
            Console.WriteLine("Impressão dos alunos");
            foreach (Aluno aluno in alunos) // percorre cada aluno da lista
            {
                // Ao invés de escrever manualmente, chamamos o método ImprimirAluno()
                aluno.ImprimirAluno();
                // Aqui entra o polimorfismo: 
                // se for Aluno normal, usa a versão da classe Aluno
                // se for AlunoEspecial, usa a versão sobrescrita da classe AlunoEspecial
            }
        }
    }

    // Classe que representa um aluno "normal"
    class Aluno
    {
        public int id { get; set; }          // número do aluno
        public string Nome { get; set; }    // nome do aluno
        public double[] Notas { get; set; } // notas do aluno (pode ter várias)

        // Método para imprimir os dados do aluno
        // Virtual = permite que as classes filhas (como AlunoEspecial) modifiquem esse comportamento
        public virtual void ImprimirAluno()
        {
            Console.WriteLine($"- ID: {this.id} Nome: {this.Nome}");
        }
    }

    // Classe que representa um aluno especial
    // Ela herda de Aluno, então já tem ID, Nome e Notas
    // Mas também tem a propriedade Deficiencia
    class AlunoEspecial : Aluno
    {
        public string Deficiencia { get; set; }

        // Aqui sobrescrevemos (override) o método da classe Aluno
        // Agora, além de mostrar ID e Nome, também mostra a Deficiencia
        public override void ImprimirAluno()
        {
            Console.WriteLine($"- ID: {this.id} Nome: {this.Nome} - {this.Deficiencia}");
        }
    }

}
