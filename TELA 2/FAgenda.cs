using FluentScheduler;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TELA_2
{
    public partial class FAgenda : Form
    {
        private int Horas;
        private int Minutos;

        public FAgenda()
        {
            InitializeComponent();
        }

        private void hopeNumeric2_Click(object sender, EventArgs e)
        {

        }

        private void bigLabel2_Click(object sender, EventArgs e)
        {

        }

        private void hopeNumeric1_Click(object sender, EventArgs e)
        {

        }

        private void FAgenda_Load(object sender, EventArgs e)
        {
            string configFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.xml");

            if (File.Exists(configFilePath))
            {
                BackupConfig config = BackupConfig.Load(configFilePath);

                Horas = config.Horas;
                Minutos = config.Minutos;

                // Atualiza o valor dos controles hopeNumeric
                hopeNumericHoras.ValueNumber = Horas;
                hopeNumericMinutos.ValueNumber = Minutos;

                // Atualiza o texto das labels para exibir os valores com dois dígitos
                bigLabel2.Text = $"{Horas:D2}";
                bigLabel3.Text = $"{Minutos:D2}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Horas = (int)hopeNumericHoras.ValueNumber;
            Minutos = (int)hopeNumericMinutos.ValueNumber;

            string configFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.xml");
            BackupConfig config;

            if (File.Exists(configFilePath))
            {
                config = BackupConfig.Load(configFilePath);
            }
            else
            {
                config = new BackupConfig();
            }

            config.Horas = Horas;
            config.Minutos = Minutos;

            config.Save(configFilePath);

            // Atualiza as labels com os novos valores
            bigLabel2.Text = $"{Horas:D2}";
            bigLabel3.Text = $"{Minutos:D2}";
            
            // Reinicializa o JobManager com a nova configuração
            JobManager.Stop();
            JobManager.Initialize(new BackupScheduler());

            MessageBox.Show($"Horas: {Horas:D2}, Minutos: {Minutos:D2}\nConfiguração salva com sucesso!", "Valores Salvos", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
