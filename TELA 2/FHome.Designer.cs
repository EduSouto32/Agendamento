namespace Backup
{
    partial class FHome
    {
        private System.ComponentModel.IContainer components = null;
        private ReaLTaiizor.Controls.AloneComboBox CombHistorico;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private OpenFolder openFolder1;
        private OpenFolder openFolder2;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ReaLTaiizor.Controls.AloneComboBox CombHistorico;
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            openFolder1 = new OpenFolder();
            openFolder2 = new OpenFolder();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            SalvaConfig = new ReaLTaiizor.Controls.Button();
            executarBackup = new ReaLTaiizor.Controls.Button();
            panel1 = new Panel();
            this.CombHistorico = new ReaLTaiizor.Controls.AloneComboBox();
            SuspendLayout();
            // 
            // CombHistorico
            // 
            this.CombHistorico.AutoCompleteCustomSource.AddRange(new string[] { "Diário", "Semanal", "Quinzenal", "Mensal" });
            this.CombHistorico.DrawMode = DrawMode.OwnerDrawFixed;
            this.CombHistorico.DropDownStyle = ComboBoxStyle.DropDownList;
            this.CombHistorico.EnabledCalc = true;
            this.CombHistorico.FormattingEnabled = true;
            this.CombHistorico.ItemHeight = 20;
            this.CombHistorico.Items.AddRange(new object[] { "Diário", "Semanal", "Quinzenal", "Mensal" });
            this.CombHistorico.Location = new Point(601, 46);
            this.CombHistorico.Name = "CombHistorico";
            this.CombHistorico.Size = new Size(133, 26);
            this.CombHistorico.TabIndex = 5;
            this.CombHistorico.SelectedIndexChanged += aloneComboBox1_SelectedIndexChanged;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel1.Location = new Point(12, 9);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(111, 46);
            bigLabel1.TabIndex = 0;
            bigLabel1.Text = "Home";
            // 
            // openFolder1
            // 
            openFolder1.Location = new Point(12, 128);
            openFolder1.Name = "openFolder1";
            openFolder1.SelectedPath = "";
            openFolder1.Size = new Size(575, 41);
            openFolder1.TabIndex = 1;
            // 
            // openFolder2
            // 
            openFolder2.Location = new Point(12, 229);
            openFolder2.Name = "openFolder2";
            openFolder2.SelectedPath = "";
            openFolder2.Size = new Size(575, 41);
            openFolder2.TabIndex = 2;
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel2.Location = new Point(35, 100);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(88, 25);
            bigLabel2.TabIndex = 3;
            bigLabel2.Text = "Caminho";
            // 
            // bigLabel3
            // 
            bigLabel3.AutoSize = true;
            bigLabel3.BackColor = Color.Transparent;
            bigLabel3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel3.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel3.Location = new Point(35, 198);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new Size(79, 28);
            bigLabel3.TabIndex = 4;
            bigLabel3.Text = "Destino";
            // 
            // bigLabel4
            // 
            bigLabel4.AutoSize = true;
            bigLabel4.BackColor = Color.Transparent;
            bigLabel4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel4.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel4.Location = new Point(631, 22);
            bigLabel4.Name = "bigLabel4";
            bigLabel4.Size = new Size(72, 21);
            bigLabel4.TabIndex = 6;
            bigLabel4.Text = "Histórico";
            // 
            // SalvaConfig
            // 
            SalvaConfig.BackColor = Color.Transparent;
            SalvaConfig.BorderColor = Color.FromArgb(32, 34, 37);
            SalvaConfig.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            SalvaConfig.EnteredColor = Color.FromArgb(32, 34, 37);
            SalvaConfig.Font = new Font("Microsoft Sans Serif", 12F);
            SalvaConfig.Image = null;
            SalvaConfig.ImageAlign = ContentAlignment.MiddleLeft;
            SalvaConfig.InactiveColor = Color.FromArgb(32, 34, 37);
            SalvaConfig.Location = new Point(631, 536);
            SalvaConfig.Name = "SalvaConfig";
            SalvaConfig.PressedBorderColor = Color.FromArgb(165, 37, 37);
            SalvaConfig.PressedColor = Color.FromArgb(165, 37, 37);
            SalvaConfig.Size = new Size(120, 40);
            SalvaConfig.TabIndex = 8;
            SalvaConfig.Text = "Salvar";
            SalvaConfig.TextAlignment = StringAlignment.Center;
            SalvaConfig.Click += SalvaConfig_Click;
            // 
            // executarBackup
            // 
            executarBackup.BackColor = Color.Transparent;
            executarBackup.BorderColor = Color.FromArgb(32, 34, 37);
            executarBackup.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            executarBackup.EnteredColor = Color.FromArgb(32, 34, 37);
            executarBackup.Font = new Font("Microsoft Sans Serif", 12F);
            executarBackup.Image = null;
            executarBackup.ImageAlign = ContentAlignment.MiddleLeft;
            executarBackup.InactiveColor = Color.FromArgb(32, 34, 37);
            executarBackup.Location = new Point(467, 536);
            executarBackup.Name = "executarBackup";
            executarBackup.PressedBorderColor = Color.FromArgb(165, 37, 37);
            executarBackup.PressedColor = Color.FromArgb(165, 37, 37);
            executarBackup.Size = new Size(120, 40);
            executarBackup.TabIndex = 9;
            executarBackup.Text = "Executar";
            executarBackup.TextAlignment = StringAlignment.Center;
            executarBackup.Click += executarBackup_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(236, 343);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 187);
            panel1.TabIndex = 10;
            // 
            // FHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 600);
            Controls.Add(panel1);
            Controls.Add(executarBackup);
            Controls.Add(SalvaConfig);
            Controls.Add(bigLabel4);
            Controls.Add(this.CombHistorico);
            Controls.Add(bigLabel3);
            Controls.Add(bigLabel2);
            Controls.Add(openFolder2);
            Controls.Add(openFolder1);
            Controls.Add(bigLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FHome";
            Text = "FHome";
            Load += FHome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private ReaLTaiizor.Controls.Button SalvaConfig;
        private ReaLTaiizor.Controls.Button executarBackup;
        private Panel panel1;
    }
}
