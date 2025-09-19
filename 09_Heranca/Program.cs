using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Herenca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //não é possível instanciar uma classe abstrata
            //Pessoa obj = new pessoa();
            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "Geraldo";
            pessoaFisica.CPF = "999.999.999-99";
            pessoaFisica.Telefone = "(14 99999-9999)";
            pessoaFisica.Imprimir();
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Senac Marília";
            pessoaJuridica.CNPJ = "99.999.999/9999-9999";
            pessoaJuridica.Telefone = "(014 9999-9999)";
            pessoaJuridica.Imprimir();
        }
    }
}

