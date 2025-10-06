using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_TratamentoExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            int numero;
            while (true)
            {
                Console.Write(" Digite um número inteiro: ");

                //Try é a área protegida
                try
                {

                    numero = int.Parse(Console.ReadLine()); // Lê o número digitado pelo usuário e converte para inteiro
                    break; // Sai do loop se a conversão der certo
                }

                // Esse bloco é executado SOMENTE se ocorrer um erro no "try"
                catch (FormatException)
                {
                    // Mensagem exibida quando o usuário digita algo que não é número inteiro
                    Console.WriteLine(" Número Inválido, informe apenas valores inteiros!\n Pressione qualquer tecla para continuar.\n");
                    Console.ReadKey(); // Espera o usuário apertar uma tecla antes de continuar
                }

                // Esse bloco é executado SEMPRE, independentemente de ter dado certo ou erro
                finally
                {
                    Console.Clear(); // Limpa a tela para deixar o console organizado para a próxima tentativa
                }
                
            }

            // Verifica se o número digitado é par ou ímpar
            if (numero % 2 == 0)
                Console.WriteLine("Número Par!");
            else
                Console.WriteLine("Número Ímpar!");
        }
    }
}
