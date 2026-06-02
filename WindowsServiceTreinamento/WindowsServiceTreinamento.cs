using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using ClassLibraryBus;
using ClassLibraryMd;

namespace WindowsServiceTreinamento
{
    public partial class WindowsServiceTreinamento : ServiceBase
    {
        private readonly System.Timers.Timer timer;
        private readonly string logFilePath = @"C:\Logs\Treinamento\Serviço\TreinamentoServico.txt";
        private readonly string errorLogFilePath = @"C:\Logs\Treinamento\Serviço\Erro\TreinamentoServicoErro.txt";
        private readonly string consoleAppPath = @"C:\Console\Release\ConsoleAppTreinamento.exe";

        public WindowsServiceTreinamento()
        {
            InitializeComponent();
            // Configura o timer para executar a cada 30 segundos (10000 milissegundos)
            timer = new System.Timers.Timer { Interval = 30000 };
            timer.Elapsed += Timer_Elapsed;
        }

        protected override void OnStart(string[] args)
        {
            timer.Start();
        }

        protected override void OnStop()
        {
            timer.Stop();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                ProcessStartInfo console = new ProcessStartInfo();
                console.FileName = consoleAppPath;
                console.WorkingDirectory = Path.GetDirectoryName(consoleAppPath);
                console.CreateNoWindow = true;
                console.UseShellExecute = false;
                console.RedirectStandardOutput = true;
                console.RedirectStandardError = true;

                var processo = Process.Start(console);

                string saida = processo.StandardOutput.ReadToEnd();
                string erro = processo.StandardError.ReadToEnd();

                // Starta o console para executar a listagem de Ceps
                Process.Start(consoleAppPath);
                // 
                using (StreamWriter sw = new StreamWriter(logFilePath, true))
                {
                    // Escreve a mensagem de sucesso no arquivo de log
                    sw.WriteLine("Sucesso ao executar o serviço em " + DateTime.Now.ToString("dd/MM/yyyy") + " - " + DateTime.Now.ToString("HH:mm:ss") + " | saída: "+ saida + "erro: " + erro);
                }

            }
            catch (Exception)
            {
                // Faz um anexo arquivo de log para indicar que o serviço foi executado com erro
                using (StreamWriter sw = new StreamWriter(errorLogFilePath, true))
                {
                    // Escreve a mensagem de erro no arquivo de log
                    sw.WriteLine("Ocorreu um erro ao executar o serviço em " + DateTime.Now.ToString("dd/MM/yyyy") + " - " + DateTime.Now.ToString("HH:mm:ss"));
                }
                throw;
            }

        }

        public void Listagem()
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
                    sw.WriteLine("Ocorreu um erro ao executar o serviço em " + DateTime.Now.ToString("dd/MM/yyyy") + " - " + DateTime.Now.ToString("HH:mm:ss"));
                }

                throw;
            }
        }
    }
}
