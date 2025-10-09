using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _24_CriandoExcecaoPersonalizada
{
    internal class Program
    {

        //criada a classe de exceção personalizada
        // Ela herda da classe base Exception, o que a torna um tipo de exceção.
        public class NotaInvalidaException : Exception
        {

            //Este é o construtor da nossa exceção.
            // Ele recebe uma mensagem e a repassa para o construtor da classe base (Exception).
            public NotaInvalidaException() : base("O valor da nota deve estar entre 0 e 10.")
            {
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite a nota do aluno (de 0 a 10): ");
                double nota = double.Parse(Console.ReadLine());

                // Passo 2: Validar a condição e lançar a exceção se necessário
                if (nota < 0 || nota > 10)
                {
                    // Se a nota for inválida, nós "lançamos" nossa exceção personalizada.
                    // Isso interrompe a execução do bloco 'try' e pula para o 'catch'.
                    throw new NotaInvalidaException();
                }

                // Se a nota for válida, o programa continua
                if (nota >= 7.0)
                {
                    Console.WriteLine("Aluno Aprovado!");
                }
                else
                {
                    Console.WriteLine("Aluno Reprovado.");
                }
            }
            catch (NotaInvalidaException)
            {
                // Passo 3: Capturar a exceção personalizada e exibir a mensagem de erro.
                Console.WriteLine("Erro: valor de nota inválido! A nota deve estar entre 0 e 10.");
            }

            // Captura erro de digitação, caso o usuário digite letras

            catch (FormatException)
            {
                Console.WriteLine("Erro: Formato inválido. Digite um número.");
            }
        }


    }
    
}
