using FluentScheduler;
using System;
using System.IO;
using System.Threading.Tasks;

namespace TELA_2
{
    public class BackupScheduler : Registry
    {
        public BackupScheduler()
        {
            // Carrega as configurações do arquivo config.xml
            string caminhoConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.xml");
            BackupConfig config = BackupConfig.Load(caminhoConfig);

            int horas = config.Horas;
            int minutos = config.Minutos;

            // Define o horário de execução do job
            Schedule<BackupJob>().ToRunEvery(1).Days().At(horas, minutos);
        }

        private class BackupJob : IJob
        {
            public async void Execute()
            {
                try
                {
                    // Chama o método Execute da classe ExecBackup
                    await ExecBackup.Execute();
                }
                catch (Exception ex)
                {
                    // Handle exceptions if needed
                    Console.WriteLine($"Erro ao executar o backup: {ex.Message}");
                }
            }
        }
    }
}
