using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_ConversaoNumeroComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solicita que o usúario digite um número inteiro
            //Lê a entrada e guarda esse numero na variavel NumeroDigitado
            Console.WriteLine("Digite um número inteiro: ");
            string NumeroDigitado = Console.ReadLine();

            try
            {
                // Tenta converter a string (numero digitado pelo usuário) para um número inteiro
                // Se o usuário digitar "abc", esta linha vai gerar uma FormatException.
                int numero = int.Parse(NumeroDigitado);

                // Se a conversão der certo, calcula e exibe o dobro, ou seja, se a linha de cima não gerou erro
                int dobro = numero * 2;
                Console.WriteLine($"O dobro de {numero} é {dobro}.");
            }
            catch (FormatException)
            {
                // Se a conversão falhar, ou seja, FormatException ocorreu no bloco try, este código é executado
                Console.WriteLine("Valor inválido! Digite apenas números inteiros.");
            }


        }




    }
}
