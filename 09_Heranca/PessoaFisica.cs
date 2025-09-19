using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Herenca
{
    internal class PessoaFisica : Pessoa //Herança
    {
        public string CPF;
        public override string GetDocumento()
        {
            return $"CPF: {this.CPF}";
        }
    }
}
