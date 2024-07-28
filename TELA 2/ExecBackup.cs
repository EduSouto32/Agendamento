using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TELA_2
{
    internal class ExecBackup
    {
        private static Logger _logger;

        public static async Task Execute()
        {
            string caminhoConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.xml");

            if (File.Exists(caminhoConfig))
            {
                try
                {
                    // Carrega as configurações do arquivo config.xml
                    ConfigWrapper configWrapper = ConfigWrapper.Load(caminhoConfig);
                    BackupConfig config = configWrapper.BackupConfig;

                    string origem = config.Origem;
                    string destino = config.Destino;
                    int historico = config.DiasDeRetencao;

                    if (string.IsNullOrEmpty(origem) || string.IsNullOrEmpty(destino))
                    {
                        MessageBox.Show("Origem ou destino não especificado no arquivo config.xml.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Inicializa o logger e as classes de backup
                    string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");
                    _logger = new Logger(logPath);
                    Compact compactador = new Compact(_logger);
                    Backup2 backupOperacao = new Backup2(origem, destino, _logger, compactador);

                    // Executa o backup
                    await backupOperacao.ExecutarBackupAsync(historico);
                    _logger.AdicionarLog("Backup concluído com sucesso!", sucesso: true);
                    MessageBox.Show("Backup concluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    _logger?.AdicionarLog($"Erro ao executar o backup: {ex.Message}", sucesso: false);
                    MessageBox.Show($"Erro ao executar o backup: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Arquivo config.xml não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
