using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ColecaoPilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numeros = new Stack<int>(); //cria uma Stack (coleção) com o nome "numeros" e tpio inteiro (int)

            //adiciona os 5 números à Stack
            // o ".Push( )" adiciona um item (número) ao topo da Pilha, então o numero "5" (ultimo adicionado) estaria em primeiro na Pilha (um número sobrepõe o outro)
            numeros.Push(1); // O 10 é o primeiro a entrar, fica na base (por último)
            numeros.Push(2); // O 20 é empilhado em cima do 10
            numeros.Push(3); // O 30 é empilhado em cima do 20
            numeros.Push(4); // O 40 é empilhado em cima do 30
            numeros.Push(5); // o 5 é o ultimo a entrar e fica no topo da pilha

            Console.WriteLine("Números adicionados à pilha: \n"); //Exibe a a mensagem

            foreach (int numero in numeros) // O 'foreach' percorre a coleção "numeros", guarda temporáriamente cada número em "numero" e vai substituindo numero por numero
            {
                Console.WriteLine(numero); // Imprime cada número da pilha. A ordem de impressão de baixo para cima: 5,4,3,2,1
            }

            //utilizado o método ".Peek( )" para mostrar qual número esta no topo da coleção (sendo o número "5"). Sem remove-lo da coleção
            // o método ".Pop( )" removeria o número do topo, por isso foi substituido pelo "Peek( )"
            int UltimoNumero = numeros.Peek(); //criado a variavel "UltimoNumero" para guardar o número do topo da coleção nela

            Console.WriteLine($"\n O último número inserido é: {UltimoNumero}"); //Exibe o último número

        }
    }
}
