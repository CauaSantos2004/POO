using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _03_Propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criar um objeto Conta
            //Conta conta = new Conta();
            Conta conta = new Conta("999-88");

            conta.Nome = "Cauã Alves dos Santos";

            //Não é possível atribuir valor em um atributo privado
            //conta.numero = "999-88";
            
            //conta.Saldo = -1000;
            conta.Depositar(-1000m);

            //Utilizando o método acessador
            conta.setSaldo(1000.00m);
            //Console.WriteLine($"Saldo Atua: {conta.getSaldo(): c2}");
            conta.ImprimirSaldo();

            while (true)
            {
                Console.WriteLine("Informe a Operação: [D]-Depositar, [S]-Sacar ou [E]-Sair"); // cw - atalho para colocar o Console.WriteLine()
                string operacao = Console.ReadLine();

                if (operacao.ToUpper() == "D")
                {
                    Console.WriteLine("Informe o valor para depósito: ");
                    decimal valorDeposito = decimal.Parse(Console.ReadLine());
                    conta.Depositar(valorDeposito);
                    conta.ImprimirSaldo();
                }

                else if (operacao.ToUpper() == "S")
                {
                    Console.WriteLine("Informe o valor para saque: ");
                    decimal valorSaque = decimal.Parse(Console.ReadLine());
                    conta.Sacar(valorSaque);
                    conta.ImprimirSaldo();

                }

                else if (operacao.ToUpper() == "E")
                {
                    Console.WriteLine($"Conta: {conta.getNumero()} Nome: {conta.Nome} Saldo: {conta.getSaldo()}");
                    break;
                }

                else
                {
                    Console.WriteLine("Informe apenas as letras [D]-Depositar, [S]-Sacar ou [E]-Sair ");
                }


            }
        }
    }

    public class Conta //declaração da classe
    {
        //declaração dos atributos
        private string numero;
        public string Nome;

        //declaração do construtor
        public Conta(string numero)
        {
            this.numero = numero;
        }
        //Transformar a conta saldo com acesso privado
        //public decimal Saldo;
        private decimal saldo; //é privado, só pode ser acessado dentro dessa classe


        //métodos acessadores
        public void setSaldo(decimal valor)
        {
            this.Depositar(saldo);
        }
        
        public string getNumero()
        {
            return numero;
        }

        public decimal getSaldo()
        {
            return saldo;
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                saldo += valor;
            }

            else
            {
                Console.WriteLine("Valor de depósito incorreto, deve ser maior que zero!");
            }
        }   

        public void Sacar(decimal valor)
        {
            saldo -= valor;
        }

        public void ImprimirSaldo()
        {
            //Console.WriteLine($"Saldo Atual: {getSaldo(): c2}");
            Console.WriteLine($"Saldo Atual: {saldo:c2}");
        }
    
    
    }
}
