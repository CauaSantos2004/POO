using System;

namespace _08_Aluno
{
    class Program
    {
        // Ponto de entrada do programa
        static void Main(string[] args)
        {
            Console.WriteLine("=== Cadastro de Aluno ===");

            // Solicita o nome do aluno
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            // Solicita a idade do aluno
            Console.Write("Digite a idade do aluno: ");
            int idade = int.Parse(Console.ReadLine());

            // Solicita a primeira nota
            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            // Solicita a segunda nota
            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            // Cria o objeto aluno
            Aluno aluno = new Aluno(nome, idade, nota1, nota2);

            // Mostra os dados do aluno
            Console.WriteLine("\n--- Dados do Aluno ---");
            Console.WriteLine("Nome: " + aluno.Nome);
            Console.WriteLine("Idade: " + aluno.Idade);
            Console.WriteLine("Nota 1: " + aluno.Nota1);
            Console.WriteLine("Nota 2: " + aluno.Nota2);
            Console.WriteLine("Média: " + aluno.Media);
            Console.WriteLine("Situação: " + aluno.Situacao);

            Console.ReadLine(); // pausa antes de fechar
        }
    }
}
