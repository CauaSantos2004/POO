using System;
// Importa a biblioteca System, que permite usar funções básicas como Console.WriteLine e Console.ReadLine

namespace _08_Aluno
{
    // Classe Aluno: define como criar e armazenar informações de um aluno
    public class Aluno
    {
        // Propriedade Nome: guarda o nome do aluno
        // Somente leitura fora da classe (não pode ser alterado depois)
        public string Nome { get; private set; }

        // Campo privado para armazenar a idade
        // Não pode ser acessado diretamente de fora da classe
        private int idade;

        // Propriedade Idade: permite ler e alterar a idade
        // Aqui podemos aplicar regras, como impedir valores negativos
        public int Idade
        {
            get { return idade; }                 // Retorna a idade armazenada
            set { idade = value >= 0 ? value : 0; } // Se o valor for negativo, define 0
        }

        // Propriedade Nota1: armazena a primeira nota do aluno
        // Pode ser lida e alterada normalmente
        public double Nota1 { get; set; }

        // Propriedade Nota2: armazena a segunda nota do aluno
        // Também pode ser lida e alterada normalmente
        public double Nota2 { get; set; }

        // Propriedade Media: calcula automaticamente a média das notas
        // Não armazenamos um valor fixo, ela depende de Nota1 e Nota2
        public double Media
        {
            get { return (Nota1 + Nota2) / 2; } // Soma as notas e divide por 2
        }

        // Propriedade Situacao: verifica se o aluno está aprovado ou reprovado
        // Depende da média calculada automaticamente
        public string Situacao
        {
            get
            {
                // Se a média for maior ou igual a 6, retorna "Aprovado"
                // Caso contrário, retorna "Reprovado"
                return Media >= 6 ? "Aprovado" : "Reprovado";
            }
        }

        // Construtor da classe Aluno
        // Cria um objeto Aluno com nome, idade e notas iniciais
        public Aluno(string nome, int idade, double nota1, double nota2)
        {
            Nome = nome;       // Define o nome do aluno
            Idade = idade;     // Define a idade, aplicando a regra de não negativo
            Nota1 = nota1;     // Define a primeira nota
            Nota2 = nota2;     // Define a segunda nota
        }
    }
}
