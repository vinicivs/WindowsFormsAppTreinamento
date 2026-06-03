using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBus
{
    public class BusTxt
    {
        //Esse método escreve um texto em um arquivo, criando-o se não existir ou sobrescrevendo-o se já existir
        public static void EscreverTxt(string caminho, string texto)
        {
            try
            {
                // Verifica se o diretório existe, caso contrário, cria-o
                string diretorio = System.IO.Path.GetDirectoryName(caminho);
                if (!System.IO.Directory.Exists(diretorio))
                {
                    System.IO.Directory.CreateDirectory(diretorio);
                }
                // Escreve o texto no arquivo, criando-o se não existir ou sobrescrevendo-o se já existir
                System.IO.File.WriteAllText(caminho, texto + Environment.NewLine);
            }
            catch (Exception ex)
            {
                // Lida com qualquer exceção que possa ocorrer durante a escrita do arquivo
                Console.WriteLine($"Erro ao escrever no arquivo: {ex.Message}");
            }
        }

        //Esse método anexa um texto a um arquivo, criando-o se não existir
        public static void AnexarTxt(string caminho, string texto)
        {
            try
            {
                // Verifica se o diretório existe, caso contrário, cria-o
                string diretorio = System.IO.Path.GetDirectoryName(caminho);
                if (!System.IO.Directory.Exists(diretorio))
                {
                    System.IO.Directory.CreateDirectory(diretorio);
                }
                // Anexa o texto ao arquivo, criando-o se não existir
                System.IO.File.AppendAllText(caminho, texto + Environment.NewLine);
            }
            catch (Exception ex)
            {
                // Lida com qualquer exceção que possa ocorrer durante a escrita do arquivo
                Console.WriteLine($"Erro ao anexar no arquivo: {ex.Message}");
            }
        }

        //Esse método lê o conteúdo de um arquivo e retorna como uma string
        public static string LerTxt(string caminho)
        {
            try
            {
                // Verifica se o arquivo existe antes de tentar ler
                if (System.IO.File.Exists(caminho))
                {
                    // Lê todo o conteúdo do arquivo e retorna como uma string
                    return System.IO.File.ReadAllText(caminho);
                }
                else
                {
                    Console.WriteLine("Arquivo não encontrado: " + caminho);
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                // Lida com qualquer exceção que possa ocorrer durante a leitura do arquivo
                Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
                return string.Empty;
            }
        }
    }
}
