using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_DivisaoComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o primeiro número inteiro (dividendo): ");
                int numero1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número inteiro (divisor): ");
                int numero2 = int.Parse(Console.ReadLine());

                // Se o numero2 for 0, a linha abaixo vai gerar uma DivideByZeroException
                double resultado = (double)numero1 / numero2;
                Console.WriteLine($"O resultado de {numero1} / {numero2} é: {resultado}");
            }
            catch (FormatException) //erro de formato, da ao tentar converter string (texto) para numero
            {
                // Captura o erro se o usuário digitar algo que não seja um número (letras, símbolos)
                Console.WriteLine("Erro de conversão! Digite apenas números inteiros.");
            }
            catch (DivideByZeroException) //erro de divisão por 0, da ao tentar dividir um numero por 0
            {
                // Captura o erro de divisão por zero
                Console.WriteLine("Erro! Não é possível realizar uma divisão por zero.");
            }
            finally
            {
                // Este bloco é executado sempre, com ou sem erro
                //O Finally Garante que um código seja executado independentemente do que aconteceu dentro do try e do catch
                Console.WriteLine("Operação finalizada.");
            }
        }
    }
}
