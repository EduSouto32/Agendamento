namespace TELA_2
{
    partial class FAgenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            hopeNumericHoras = new ReaLTaiizor.Controls.HopeNumeric();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            hopeNumericMinutos = new ReaLTaiizor.Controls.HopeNumeric();
            button1 = new ReaLTaiizor.Controls.Button();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel5 = new ReaLTaiizor.Controls.BigLabel();
            SuspendLayout();
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel1.Location = new Point(12, 9);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(136, 46);
            bigLabel1.TabIndex = 0;
            bigLabel1.Text = "Agenda";
            // 
            // hopeNumericHoras
            // 
            hopeNumericHoras.BackColor = Color.Snow;
            hopeNumericHoras.BaseColor = Color.FromArgb(80, 80, 80);
            hopeNumericHoras.BorderColorA = Color.Silver;
            hopeNumericHoras.BorderColorB = Color.Silver;
            hopeNumericHoras.BorderHoverColorA = Color.Silver;
            hopeNumericHoras.ButtonTextColorA = Color.Snow;
            hopeNumericHoras.ButtonTextColorB = Color.Snow;
            hopeNumericHoras.EnterKey = true;
            hopeNumericHoras.Font = new Font("Segoe UI", 12F);
            hopeNumericHoras.ForeColor = Color.FromArgb(22, 22, 22);
            hopeNumericHoras.HoverButtonTextColorA = Color.Snow;
            hopeNumericHoras.HoverButtonTextColorB = Color.Snow;
            hopeNumericHoras.Location = new Point(217, 453);
            hopeNumericHoras.MaxNum = 24F;
            hopeNumericHoras.MinNum = 0F;
            hopeNumericHoras.Name = "hopeNumericHoras";
            hopeNumericHoras.Precision = 0;
            hopeNumericHoras.Size = new Size(120, 32);
            hopeNumericHoras.Step = 1F;
            hopeNumericHoras.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.LeftRight;
            hopeNumericHoras.TabIndex = 4;
            hopeNumericHoras.Text = "hopeNumericHoras";
            hopeNumericHoras.ValueNumber = 0F;
            hopeNumericHoras.Click += hopeNumeric2_Click;
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Segoe MDL2 Assets", 72F);
            bigLabel2.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel2.Location = new Point(217, 177);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(120, 96);
            bigLabel2.TabIndex = 5;
            bigLabel2.Text = "18";
            bigLabel2.Click += bigLabel2_Click;
            // 
            // hopeNumericMinutos
            // 
            hopeNumericMinutos.BackColor = Color.Snow;
            hopeNumericMinutos.BaseColor = Color.FromArgb(80, 80, 80);
            hopeNumericMinutos.BorderColorA = Color.Silver;
            hopeNumericMinutos.BorderColorB = Color.Silver;
            hopeNumericMinutos.BorderHoverColorA = Color.Silver;
            hopeNumericMinutos.ButtonTextColorA = Color.Snow;
            hopeNumericMinutos.ButtonTextColorB = Color.Snow;
            hopeNumericMinutos.EnterKey = true;
            hopeNumericMinutos.Font = new Font("Segoe UI", 12F);
            hopeNumericMinutos.ForeColor = Color.FromArgb(22, 22, 22);
            hopeNumericMinutos.HoverButtonTextColorA = Color.Snow;
            hopeNumericMinutos.HoverButtonTextColorB = Color.Snow;
            hopeNumericMinutos.Location = new Point(409, 453);
            hopeNumericMinutos.MaxNum = 59F;
            hopeNumericMinutos.MinNum = 0F;
            hopeNumericMinutos.Name = "hopeNumericMinutos";
            hopeNumericMinutos.Precision = 0;
            hopeNumericMinutos.Size = new Size(120, 32);
            hopeNumericMinutos.Step = 1F;
            hopeNumericMinutos.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.LeftRight;
            hopeNumericMinutos.TabIndex = 6;
            hopeNumericMinutos.Text = "hopeNumericMinutos";
            hopeNumericMinutos.ValueNumber = 0F;
            hopeNumericMinutos.Click += hopeNumeric1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BorderColor = Color.FromArgb(32, 34, 37);
            button1.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button1.EnteredColor = Color.FromArgb(32, 34, 37);
            button1.Font = new Font("Microsoft Sans Serif", 12F);
            button1.Image = null;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.InactiveColor = Color.FromArgb(32, 34, 37);
            button1.Location = new Point(631, 536);
            button1.Name = "button1";
            button1.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button1.PressedColor = Color.FromArgb(165, 37, 37);
            button1.Size = new Size(120, 40);
            button1.TabIndex = 7;
            button1.Text = "Salvar";
            button1.TextAlignment = StringAlignment.Center;
            button1.Click += button1_Click;
            // 
            // bigLabel3
            // 
            bigLabel3.AutoSize = true;
            bigLabel3.BackColor = Color.Transparent;
            bigLabel3.Font = new Font("Segoe MDL2 Assets", 72F);
            bigLabel3.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel3.Location = new Point(409, 177);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new Size(120, 96);
            bigLabel3.TabIndex = 8;
            bigLabel3.Text = "00";
            // 
            // bigLabel4
            // 
            bigLabel4.AutoSize = true;
            bigLabel4.BackColor = Color.Transparent;
            bigLabel4.Font = new Font("Segoe MDL2 Assets", 72F);
            bigLabel4.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel4.Location = new Point(343, 177);
            bigLabel4.Name = "bigLabel4";
            bigLabel4.Size = new Size(60, 96);
            bigLabel4.TabIndex = 9;
            bigLabel4.Text = ":";
            // 
            // bigLabel5
            // 
            bigLabel5.AutoSize = true;
            bigLabel5.BackColor = Color.Transparent;
            bigLabel5.Font = new Font("Segoe UI", 25F);
            bigLabel5.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel5.Location = new Point(182, 131);
            bigLabel5.Name = "bigLabel5";
            bigLabel5.Size = new Size(375, 46);
            bigLabel5.TabIndex = 10;
            bigLabel5.Text = "Sua tafera foi agendada";
            // 
            // FAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 600);
            Controls.Add(bigLabel5);
            Controls.Add(bigLabel4);
            Controls.Add(bigLabel3);
            Controls.Add(button1);
            Controls.Add(hopeNumericMinutos);
            Controls.Add(bigLabel2);
            Controls.Add(hopeNumericHoras);
            Controls.Add(bigLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FAgenda";
            Load += FAgenda_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.HopeNumeric hopeNumericHoras;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.HopeNumeric hopeNumericMinutos;
        private ReaLTaiizor.Controls.Button button1;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;
        private ReaLTaiizor.Controls.BigLabel bigLabel5;
    }
}