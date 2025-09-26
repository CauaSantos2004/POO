using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ColecaoFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria uma fila (Queue) com nome de "filaDeAtendimento" para guardar nomes (string).
            //O primeiro que entra é o primeiro a sair
            Queue<string> filaDeAtendimento = new Queue<string>();

            //Exibe a mensagem
            Console.WriteLine("Por favor, digite nomes para a fila de atendimento. Eles devem conter no mínimo 3 carácteres ");
            Console.WriteLine("Para parar de adicionar nomes, digite 'sair'.\n");

            //Declaração do contador
            int contador = 0;

            // Aqui o Loop infinito ("true" significa "verdadeiro") esse loop nunca vai parar sozinho, só vai parar se usar a instrução "break" 
            //Enquanto a instrução for verdadeira, continue executando o código
            while (true)
            {
                Console.Write("Digite um nome ou 'sair': ");
                string nome = Console.ReadLine(); // guarda os nomes digitados na variavel "nome"

                // Verifica se o usuário quer sair do loop
                // "nome.ToLower() == "sair" - Quando for digitado "sair" o sistema sai do loop
                if (nome.ToLower() == "sair") // O ".ToLower()" transforma todas as letras de um texto (uma string) em letras minúsculas.
                                              // Se o usuario digitar "sair", "Sair" ou "SAIR" o sistema entende normalmente. O usuario não teria que digitar somente "sair".
                {
                    break; // Sai do loop
                }

                // Valida se o nome tem pelo menos 3 caracteres.
                if (nome.Length >= 3) // Se o tamanho do nome digitado for maior ou igual a 3 caracteres
                {
                    // Adiciona o nome ao final da fila.
                    filaDeAtendimento.Enqueue(nome); // O ".Enqueue" adiciona o nome digitado ao final da fila, dentro da variavel "filaDeAtendimento"
                    Console.WriteLine($"{nome} adicionado à fila. \n");
                }
                // Se o nome não conter pelo menos 3 caracteres, ele exibe a mensagema abaixo
                else
                {
                    Console.WriteLine("Nome inválido. Digite um nome com 3 ou mais caracteres.");
                }

            }

            Console.WriteLine("Atendimento Inciado: \n");

            // Se a fila não estiver vazia, atende as pessoas.
            if (filaDeAtendimento.Count > 0) // ".Count" ele faz contagem, ou seja, se a quantidade de itens na fila de atendimento for maior que zero
            {

                // "Dequeue()" remove o item (nome) que está no começo da fila (detro da variavel filaDeAtendimento) e retorna esse item (esse nome) que foi removido da fila
                //ou seja, retira o primeiro nome e devolve ele, e faz a mesma coisa com os outros 2 nomes
                Console.WriteLine($"1º atendido: {filaDeAtendimento.Dequeue()}");

                if (filaDeAtendimento.Count > 0)
                {
                    Console.WriteLine($"2º atendido: {filaDeAtendimento.Dequeue()}");
                }

                if (filaDeAtendimento.Count > 0)
                {
                    Console.WriteLine($"3º atendido: {filaDeAtendimento.Dequeue()}");
                }

                Console.WriteLine("\n Pessoas que ainda aguardam na fila: \n");

                // Exibe os nomes que ainda restam na fila.
                foreach (string nomeRestante in filaDeAtendimento)//pega os nomes que não foram removidos da fila (de dentro da Variavel "filaDeAtendimento")
                                                                  // e joga dentro da variavel "nomeRestante" que foi criada
                {
                    Console.WriteLine($"- {nomeRestante}"); //exibe os nomes restantes
                }
            }
            else
            {
                Console.WriteLine("A fila está vazia. Ninguém foi atendido.");
            }

        }
    }
}   
