namespace TMOOP3
{
    partial class MainForm
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
            panel1 = new Panel();
            label4 = new Label();
            X_btn_Login = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button6 = new Button();
            label1 = new Label();
            panel3 = new Panel();
            addtask22 = new addtask2();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(X_btn_Login);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1141, 45);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 11);
            label4.Name = "label4";
            label4.Size = new Size(380, 25);
            label4.TabIndex = 5;
            label4.Text = "TASK MONSTER || MANAGING YOUR TASK\r\n";
            // 
            // X_btn_Login
            // 
            X_btn_Login.BackColor = Color.FromArgb(192, 64, 0);
            X_btn_Login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            X_btn_Login.ForeColor = Color.White;
            X_btn_Login.Location = new Point(1077, 10);
            X_btn_Login.Name = "X_btn_Login";
            X_btn_Login.Size = new Size(50, 31);
            X_btn_Login.TabIndex = 1;
            X_btn_Login.Text = "X";
            X_btn_Login.UseVisualStyleBackColor = false;
            X_btn_Login.Click += X_btn_Login_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 705);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.profile__1_;
            pictureBox1.Location = new Point(83, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.HotTrack;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(21, 653);
            button6.Name = "button6";
            button6.Size = new Size(208, 40);
            button6.TabIndex = 7;
            button6.Text = "Logout";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(69, 136);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 0;
            label1.Text = "WELCOME";
            // 
            // panel3
            // 
            panel3.Controls.Add(addtask22);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(250, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(891, 705);
            panel3.TabIndex = 2;
            // 
            // addtask22
            // 
            addtask22.Location = new Point(0, 0);
            addtask22.Name = "addtask22";
            addtask22.Size = new Size(1114, 881);
            addtask22.TabIndex = 0;
            addtask22.Load += addtask22_Load;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 750);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button X_btn_Login;
        private Label label4;
        private Panel panel2;
        private Label label1;
        private Button button6;
        private PictureBox pictureBox1;
        private Panel panel3;
        private addtask2 addTask21;
        private addtask2 addtask22;
    }
}