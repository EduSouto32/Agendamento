using FluentScheduler;
using System;
using System.IO;
using System.Windows.Forms;

namespace TELA_2
{
    public class BackupScheduler : Registry
    {
        public BackupScheduler()
        {
            // Carrega as configurações do arquivo config.xml
            string caminhoConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.xml");

            if (File.Exists(caminhoConfig))
            {
                ConfigWrapper configWrapper = ConfigWrapper.Load(caminhoConfig);

                int horas = configWrapper.Agenda.Horas;
                int minutos = configWrapper.Agenda.Minutos;

                // Define o horário de execução do job baseado nas configurações do arquivo XML
                Schedule<BackupJob>().ToRunEvery(1).Days().At(horas, minutos);
            }
            else
            {
                MessageBox.Show("Arquivo de configuração da agenda não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
