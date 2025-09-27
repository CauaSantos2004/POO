using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ColecaoHash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria um HashSet de inteiros
            // Um HashSet é uma coleção que não permite itens duplicados
            HashSet<int> numeros = new HashSet<int>();

            Console.WriteLine("Adicionando números à coleção...");

            // Adiciona 10 números, incluindo números repetidos.
            // O HashSet vai aceitar os números  10, 20, 30, 40, 50, mas vai ignorar os repetidos
            numeros.Add(10);
            numeros.Add(20);
            numeros.Add(20); // Este número duplicado não será aceito
            numeros.Add(20); // Este número duplicado não será aceito
            numeros.Add(50);
            numeros.Add(20); // Este número duplicado não será aceito
            numeros.Add(60);
            numeros.Add(70);
            numeros.Add(70); // Este número duplicado também não será aceito
            numeros.Add(80);
            //será exibino no final no console, somente 6 números ao invez de 10 números que seria o total de adicionados

            Console.WriteLine("\n Lista Final: \n");

            // O loop 'foreach' percorre e mostra apenas os números que foram aceitos pela coleção HashSet
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero); //Exibe esses números
            }
        }
    }
}
