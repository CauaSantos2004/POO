using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_LeituraArquivoComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o caminho completo do arquivo (ex: C:\\temp\\arquivo.txt): ");
            string caminhoDoArquivo = Console.ReadLine();

            try
            {
                // Tenta ler todo o conteúdo do arquivo especificado.
                // Se o arquivo não existir, esta linha vai gerar uma FileNotFoundException.
                string conteudo = File.ReadAllText(caminhoDoArquivo);
                Console.WriteLine("\nConteúdo do Arquivo: ");
                Console.WriteLine(conteudo);
            }

            catch (FileNotFoundException) //FileNotFoundException  é erro que ocorre quando tentamos acessar um arquivo que não existe no caminho especificado pelo usuario.
            {
                // Se o arquivo não for encontrado, este FileNotFoundException é executado, exibindo a mensagem abaixo.
                Console.WriteLine("Arquivo não encontrado! Verifique o caminho e tente novamente.");
            }
            catch (Exception ex)
            {
                // Um catch genérico para outros possíveis erros (ex: falta de permissão)
                Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
            }

        }
    }
}
