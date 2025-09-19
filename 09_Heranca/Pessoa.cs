    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace _09_Herenca
    {
        internal abstract class Pessoa //classe abstrata não pode ser instânciada
        {
            public int Id { get; set; }
            public string Nome;
            public string Telefone;
            public abstract string GetDocumento();
            public void Imprimir()
            {
                Console.WriteLine($"LISTA DE PESSOAS\n\nNome: {this.Nome} Documento: {this.GetDocumento()} Telefone: {this.Telefone}");
            }

            public override string ToString()
            {
                return ($"<ToString()> Nome: {this.Nome} Documento: {this.GetDocumento()} Telefone: {this.Telefone}");
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;
                {
                
                }
                //cast=> Conversão de Objeto
                //((Pessoa)obj)=> converte obj que é don tipo Object para o tipo Pessoa
                return this.Id == ((Pessoa)obj).Id;
            }
            public override int GetHashCode()
            {
                return this.Id.GetHashCode();
            }

        }
    }