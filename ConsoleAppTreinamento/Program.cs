using ClassLibraryBus;
using ClassLibraryMd;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTreinamento
{
    internal class Program
    {   
        static readonly string logFilePath = @"C:\Logs\Treinamento\Console\TreinamentoConsole.txt";
        private static readonly string errorLogFilePath = @"C:\Logs\Treinamento\Console\Erro\TreinamentoConsoleErro.txt";

        static void Main(string[] args)
        {
            // Cria uma instância da classe Program para acessar os métodos de listagem
            Console.WriteLine("INICIANDO O SERVIÇO DE TREINAMENTO...");

            // Inicia a listagem de Ceps
            Listagem();

            // Aguarda o usuário pressionar Enter para finalizar o console
            Console.WriteLine("FINALIZADO O SERVIÇO DE TREINAMENTO...");
            // Aguarda o usuário pressionar Enter para finalizar o console
            //Console.ReadLine();

            // encerra imediatamente sem pedir ENTER
            Environment.Exit(0);
        }

        static void Listagem()
        {
            try
            {
                // Listagem de Ceps
                var listagemceps = BusClass.Listagem();

                using (StreamWriter sw = new StreamWriter(logFilePath, true))
                {
                    // Monta listagem de Ceps
                    foreach (var item in listagemceps)
                    {
                        // Escreve a mensagem de erro no arquivo de log
                        sw.WriteLine("Cep: " + item.Cep + " | " + DateTime.Now.ToString("dd/MM/yyyy") + " - " + DateTime.Now.ToString("HH:mm:ss"));

                    }
                }
            }
            catch (Exception)
            {
                // Faz um anexo arquivo de log para indicar que o serviço foi executado com erro
                using (StreamWriter sw = new StreamWriter(errorLogFilePath, true))
                {
                    // Escreve a mensagem de erro no arquivo de log
                    sw.WriteLine("Ocorreu um erro ao executar o console em " + DateTime.Now.ToString("dd/MM/yyyy") + " - " + DateTime.Now.ToString("HH:mm:ss"));
                }

                throw;
            }
        }
    }
}
