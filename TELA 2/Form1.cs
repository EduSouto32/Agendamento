using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TELA_2;

namespace Backup
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem showMenuItem;
        private ToolStripMenuItem exitMenuItem;

        public Form1()
        {
            InitializeComponent();
            AbrirForm(new FHome());
            this.StartPosition = FormStartPosition.CenterScreen;

            // Initialize NotifyIcon and ContextMenuStrip
            notifyIcon = new NotifyIcon();
            contextMenuStrip = new ContextMenuStrip();
            showMenuItem = new ToolStripMenuItem("Abrir");
            exitMenuItem = new ToolStripMenuItem("Sair");

            contextMenuStrip.Items.AddRange(new ToolStripItem[] { showMenuItem, exitMenuItem });
            notifyIcon.ContextMenuStrip = contextMenuStrip;

            // Caminho relativo para o ícone
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string iconPath = Path.Combine(appDirectory, "icone1.ico");
            notifyIcon.Icon = new Icon(iconPath);

            notifyIcon.Text = "Backup";
            notifyIcon.Visible = true;

            showMenuItem.Click += ShowMenuItem_Click;
            exitMenuItem.Click += ExitMenuItem_Click;

            this.Resize += Form1_Resize;
            notifyIcon.DoubleClick += NotifyIcon_DoubleClick;

            // Minimize the form at startup
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false; // Hide from taskbar when minimized
        }

        private void ShowMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            Application.Exit();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon.BalloonTipText = "Backup está minimizado.";
                notifyIcon.ShowBalloonTip(1000);
            }
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void ShowForm()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true; // Show in taskbar when restored
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirForm(new FHome());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirForm(new FBanco());
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirForm(object Form)
        {
            if (this.panel5.Controls.Count > 0)
                this.panel5.Controls.RemoveAt(0);
            Form fh = Form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel5.Controls.Add(fh);
            this.panel5.Tag = fh;
            fh.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirForm(new FConfig());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirForm(new FNuvem());
        }

        public void panelControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void controlBoxEdit1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(28, 28, 28);
            this.WindowState = FormWindowState.Minimized;
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(28, 28, 28);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirForm(new FAgenda());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirForm(new FXml());
        }
    }
}
