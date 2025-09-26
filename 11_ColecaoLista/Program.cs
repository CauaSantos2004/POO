using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ColecaoLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();
            int contador = 0;

            Console.WriteLine("Digite 5 nomes com pelo menos 3 caractéres: ");//Pede para digitar 5 nomes

            while (contador < 5) // Este é o Loop - enquanto o contador (nõ tiver digitado 5 nomes) for menor que 5, ele vai solicitar que seja digitado o nome
            {
                Console.Write($"Digite o nome {contador + 1}: "); // Pede para digitar o nome, mostrando ao mesmo tempo qual nome ele está digitando
                string nome = Console.ReadLine(); // Pega os nomes e vai gurdando na variavel "nome"

                // Validação: o nome deve ter pelo menos 3 caracteres.
                if (nome.Length >= 3) //Aqui verifica se o tamanho do nome que foi digitado é maior ou igual a 3.
                {
                    nomes.Add(nome); //se a condição acima for verdadeira, ele pega o nome e adiciona na variavel "nome"
                    contador++;
                }
                else // Caso contrário, ele exibe a mensagem de erro para o usúario
                {
                    Console.WriteLine("Erro: O nome deve conter pelo menos 3 caracteres. Por favor, Digite novamente.");
                }
            }

            Console.WriteLine("\nNomes digitados:");// aqui ele pula uma linha no console "\n" e coloca o titulo para listar os nomes abaixo
            foreach (string nome in nomes) //inicia o Loop que percorre cada item na lista "nomes"
            {
                Console.WriteLine($"- {nome}"); //Exibe no console cada nome da lista, sendo um nome por linha.
            }


        }
    }
}
