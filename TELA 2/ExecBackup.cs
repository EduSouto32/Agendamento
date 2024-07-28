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
            // Mensagem de log para verificar a chamada do método
            MessageBox.Show("Método ExecBackup.Execute chamado");

            // Carrega as configurações do arquivo config.xml
            string caminhoConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.xml");
            BackupConfig config = BackupConfig.Load(caminhoConfig);

            // Substitui as variáveis origem, destino e historico pelos valores do arquivo XML
            string origem = config.Origem;
            string destino = config.Destino;
            int historico = config.DiasDeRetencao;

            string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");

            try
            {
                _logger = new Logger(logPath); // Supondo que a classe Logger exista e tenha um construtor que receba o caminho do arquivo de log
                Compact compactador = new Compact(_logger); // Supondo que a classe Compact exista e tenha um construtor que receba um Logger
                Backup2 backupOperacao = new Backup2(origem, destino, _logger, compactador);
                await backupOperacao.ExecutarBackupAsync(historico);

                _logger.AdicionarLog("Backup concluído com sucesso!", sucesso: true); // Log de sucesso
            }
            catch (Exception ex)
            {
                _logger?.AdicionarLog($"Erro no programa: {ex.Message}", sucesso: false); // Log de erro
                MessageBox.Show($"Erro no programa: {ex.Message}");
                throw; // Relança a exceção para ser tratada no nível superior
            }
        }
    }
}
