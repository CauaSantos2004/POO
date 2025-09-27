using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ColecaoDicionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria um Dictionary para armazenar um RA (int) e um Nome (string).
            // A chave (RA) deve ser única.
            Dictionary<int, string> alunos = new Dictionary<int, string>();

            Console.WriteLine("Por favor, digite o RA e o nome de 5 alunos.");

            int contador = 0;
            while (contador < 5)
            {
                Console.Write($"\nDigite o RA do aluno #{contador + 1}: ");

                // Tenta ler o RA e converter para um número inteiro.
                if (int.TryParse(Console.ReadLine(), out int ra))
                {
                    // Verifica se já existe um RA igual no dicionário. (um RA que ja foi digitado)
                    if (alunos.ContainsKey(ra))
                    {
                        Console.WriteLine("Erro: O RA digitado já existe. Por favor, digite um RA diferente.");
                        continue; // Volta para o início do loop sem incrementar o contador.
                    }

                    Console.Write($"Digite o nome do aluno #{contador + 1}: ");
                    string nome = Console.ReadLine();

                    // Valida se o nome tem pelo menos 3 caracteres.
                    if (nome.Length >= 3)
                    {
                        // Adiciona o RA e o nome ao dicionário.
                        alunos.Add(ra, nome);
                        contador++; // Apenas incrementa se tudo deu certo.
                    }
                    else
                    {
                        Console.WriteLine("Erro: O nome deve conter pelo menos 3 caracteres.");
                    }
                }
                else
                {
                    Console.WriteLine("Erro: O RA deve ser um número inteiro.");
                }
            }

            Console.WriteLine("\n--- Dados dos Alunos ---");
            // Usa um laço foreach para exibir os dados de cada aluno no dicionário.
            foreach (var aluno in alunos)
            {
                // A 'chave' é o RA, e o 'valor' é o nome do aluno.
                Console.WriteLine($"RA: {aluno.Key} - Nome: {aluno.Value}");
            }

        }
    }
}
