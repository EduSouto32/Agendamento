using ReaLTaiizor.Controls;
using System;
using System.Windows.Forms;

namespace Backup
{
    public partial class OpenFolder : UserControl
    {
        public OpenFolder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                aloneTextBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        // Propriedade pública para retornar e definir o caminho selecionado
        public string SelectedPath
        {
            get { return aloneTextBox1.Text; }
            set { aloneTextBox1.Text = value; }
        }
    }
}
