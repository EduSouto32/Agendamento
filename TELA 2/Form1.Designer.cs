namespace Backup
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelControl = new Panel();
            panel7 = new Panel();
            button6 = new Button();
            panel5 = new Panel();
            controlBoxEdit1 = new ReaLTaiizor.Controls.ControlBoxEdit();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            button4 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            panel4 = new Panel();
            button7 = new Button();
            panel6 = new Panel();
            button8 = new Button();
            panel8 = new Panel();
            button3 = new Button();
            panelControl.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panelControl
            // 
            panelControl.BackColor = Color.FromArgb(28, 28, 28);
            panelControl.Controls.Add(panel7);
            panelControl.Dock = DockStyle.Top;
            panelControl.Location = new Point(0, 0);
            panelControl.MaximumSize = new Size(978, 39);
            panelControl.MinimumSize = new Size(978, 39);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(978, 39);
            panelControl.TabIndex = 0;
            panelControl.Paint += panelControl_Paint;
            panelControl.MouseDown += panelControl_MouseDown;
            // 
            // panel7
            // 
            panel7.Controls.Add(button6);
            panel7.Location = new Point(946, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(44, 43);
            panel7.TabIndex = 2;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.Transparent;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(-27, -13);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(86, 66);
            button6.TabIndex = 0;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click_1;
            button6.MouseHover += button6_MouseHover;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(controlBoxEdit1);
            panel5.Location = new Point(197, 39);
            panel5.Name = "panel5";
            panel5.Size = new Size(781, 588);
            panel5.TabIndex = 2;
            panel5.Paint += panel5_Paint_1;
            // 
            // controlBoxEdit1
            // 
            controlBoxEdit1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            controlBoxEdit1.BackColor = Color.Transparent;
            controlBoxEdit1.Cursor = Cursors.Hand;
            controlBoxEdit1.DefaultLocation = true;
            controlBoxEdit1.Location = new Point(913, -1);
            controlBoxEdit1.Name = "controlBoxEdit1";
            controlBoxEdit1.Size = new Size(77, 19);
            controlBoxEdit1.TabIndex = 1;
            controlBoxEdit1.Text = "controlBoxEdit1";
            controlBoxEdit1.Click += controlBoxEdit1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(80, 80, 80);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel8);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 39);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 588);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 57);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-1, -5);
            button1.Name = "button1";
            button1.Size = new Size(211, 73);
            button1.TabIndex = 3;
            button1.Text = "        Home";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Location = new Point(3, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(218, 57);
            panel2.TabIndex = 2;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-1, -5);
            button4.Name = "button4";
            button4.Size = new Size(211, 73);
            button4.TabIndex = 3;
            button4.Text = "        Banco";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Location = new Point(3, 129);
            panel3.Name = "panel3";
            panel3.Size = new Size(218, 57);
            panel3.TabIndex = 2;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-1, -5);
            button2.Name = "button2";
            button2.Size = new Size(211, 73);
            button2.TabIndex = 3;
            button2.Text = "        Nuvem";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button7);
            panel4.Location = new Point(3, 192);
            panel4.Name = "panel4";
            panel4.Size = new Size(218, 57);
            panel4.TabIndex = 2;
            // 
            // button7
            // 
            button7.Cursor = Cursors.Hand;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Black;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(-1, -5);
            button7.Name = "button7";
            button7.Size = new Size(211, 73);
            button7.TabIndex = 4;
            button7.Text = "        Agenda";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(button8);
            panel6.Location = new Point(3, 255);
            panel6.Name = "panel6";
            panel6.Size = new Size(251, 57);
            panel6.TabIndex = 5;
            // 
            // button8
            // 
            button8.Cursor = Cursors.Hand;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.Black;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(-1, -8);
            button8.Name = "button8";
            button8.Size = new Size(222, 73);
            button8.TabIndex = 5;
            button8.Text = "        Xml";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(button3);
            panel8.Location = new Point(3, 318);
            panel8.Name = "panel8";
            panel8.Size = new Size(218, 57);
            panel8.TabIndex = 6;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-1, -14);
            button3.Name = "button3";
            button3.Size = new Size(220, 74);
            button3.TabIndex = 3;
            button3.Text = "        Configuração\r\n";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(978, 627);
            Controls.Add(panel5);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panelControl);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            panelControl.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel5.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelControl;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button button1;
        private Panel panel4;
        private Button button4;
        private Panel panel2;
        private Button button2;
        private Panel panel3;
        private Button button3;
        private Button button5;
        private ReaLTaiizor.Controls.ControlBoxEdit controlBoxEdit1;
        private Panel panel5;
        private Panel panel7;
        private Button button6;
        private Button button7;
        private Panel panel6;
        private Button button8;
        private Panel panel8;
    }
}
