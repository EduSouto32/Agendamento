namespace TELA_2
{
    partial class FLoading
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Image = Properties.Resources.Spinner_1x_0_8s_200px_200px;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label1.Location = new Point(-1, -9);
            label1.Name = "label1";
            label1.Size = new Size(257, 187);
            label1.TabIndex = 0;
            label1.Text = "Por favor aguarde ...";
            label1.TextAlign = ContentAlignment.BottomCenter;
            label1.UseCompatibleTextRendering = true;
            label1.UseMnemonic = false;
            label1.Click += label1_Click;
            // 
            // FLoading
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 179);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FLoading";
            Text = "FLoading";
            Load += FLoading_Load;
            ResumeLayout(false);
        }

        #endregion

        public Label label1;
    }
}