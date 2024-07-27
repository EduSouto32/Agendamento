using FluentScheduler;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TELA_2
{
    public class BackupScheduler : Registry
    {
        public BackupScheduler()
        {
            // Carrega as configurações do arquivo config.xml
            string caminhoConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.xml");
            BackupConfig config = BackupConfig.Load(caminhoConfig);

            int horas = config.Horas; // Hora no formato 0-23
            int minutos = config.Minutos; // Minutos no formato 0-59

            // Define o horário de execução do job
            Schedule<BackupJob>().ToRunEvery(1).Days().At(horas, minutos);

            // Log para verificar a configuração do job
            MessageBox.Show($"Job agendado para rodar todos os dias às {horas:D2}:{minutos:D2}");
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
                    MessageBox.Show($"Erro ao executar o backup: {ex.Message}");
                }
            }
        }
    }
}
