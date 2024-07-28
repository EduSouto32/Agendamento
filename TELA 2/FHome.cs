using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using TELA_2;

namespace Backup
{
    public partial class FHome : Form
    {
        private int diasDeRetencao;
        private string caminhoOrigem;
        private string caminhoDestino;
        private FLoading loadingForm;

        public FHome()
        {
            InitializeComponent();
        }

        private void FHome_Load(object sender, EventArgs e)
        {
            string configFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.xml");

            if (File.Exists(configFilePath))
            {
                ConfigWrapper configWrapper = ConfigWrapper.Load(configFilePath);

                caminhoOrigem = configWrapper.BackupConfig.Origem;
                caminhoDestino = configWrapper.BackupConfig.Destino;
                diasDeRetencao = configWrapper.BackupConfig.DiasDeRetencao;

                openFolder1.SelectedPath = caminhoOrigem;
                openFolder2.SelectedPath = caminhoDestino;

                switch (diasDeRetencao)
                {
                    case 1:
                        CombHistorico.SelectedItem = "Diário";
                        break;
                    case 7:
                        CombHistorico.SelectedItem = "Semanal";
                        break;
                    case 15:
                        CombHistorico.SelectedItem = "Quinzenal";
                        break;
                    case 30:
                        CombHistorico.SelectedItem = "Mensal";
                        break;
                    default:
                        CombHistorico.SelectedItem = null;
                        break;
                }
            }
        }

        private void aloneComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CombHistorico.SelectedItem != null)
            {
                string selectedValue = CombHistorico.SelectedItem.ToString();

                switch (selectedValue)
                {
                    case "Diário":
                        diasDeRetencao = 1;
                        break;
                    case "Semanal":
                        diasDeRetencao = 7;
                        break;
                    case "Quinzenal":
                        diasDeRetencao = 15;
                        break;
                    case "Mensal":
                        diasDeRetencao = 30;
                        break;
                    default:
                        diasDeRetencao = 0; // Valor padrão caso não seja nenhum dos valores esperados
                        break;
                }
            }
        }

        private void SalvaConfig_Click(object sender, EventArgs e)
        {
            caminhoOrigem = openFolder1.SelectedPath;
            caminhoDestino = openFolder2.SelectedPath;

            if (string.IsNullOrEmpty(caminhoOrigem) || string.IsNullOrEmpty(caminhoDestino))
            {
                MessageBox.Show("Por favor, selecione os caminhos de origem e destino.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string configFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.xml");
            ConfigWrapper configWrapper;

            if (File.Exists(configFilePath))
            {
                configWrapper = ConfigWrapper.Load(configFilePath);
            }
            else
            {
                configWrapper = new ConfigWrapper
                {
                    BackupConfig = new BackupConfig(),
                    Agenda = new Agenda()
                };
            }

            configWrapper.BackupConfig.Origem = caminhoOrigem;
            configWrapper.BackupConfig.Destino = caminhoDestino;
            configWrapper.BackupConfig.DiasDeRetencao = diasDeRetencao;

            configWrapper.Save(configFilePath);

            MessageBox.Show("Configuração salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void executarBackup_Click(object sender, EventArgs e)
        {
            string caminhoConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.xml");
            if (File.Exists(caminhoConfig))
            {
                // Exibir o formulário de carregamento
                loadingForm = new FLoading();
                AbrirForm(loadingForm);

                try
                {
                    await ExecBackup.Execute();
                    loadingForm.Close(); // Fechar o formulário de carregamento após a conclusão do backup
                }
                catch (Exception ex)
                {
                    loadingForm.Close(); // Fechar o formulário de carregamento em caso de erro
                    MessageBox.Show($"Erro ao executar o backup: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Arquivo config.xml não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AbrirForm(Form form)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(form);
            this.panel1.Tag = form;
            form.Show();
        }
    }
}
