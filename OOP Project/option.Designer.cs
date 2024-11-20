namespace TMOOP3
{
    partial class option
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
            panel1 = new Panel();
            admin_btn = new Button();
            User_btn = new Button();
            label4 = new Label();
            X_btn_Login = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(187, 33);
            label1.Name = "label1";
            label1.Size = new Size(449, 41);
            label1.TabIndex = 2;
            label1.Text = "WELCOME TO TASK MONSTER";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(admin_btn);
            panel1.Controls.Add(User_btn);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(111, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(594, 475);
            panel1.TabIndex = 4;
            // 
            // admin_btn
            // 
            admin_btn.BackColor = SystemColors.ActiveCaption;
            admin_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            admin_btn.ForeColor = Color.White;
            admin_btn.Location = new Point(172, 244);
            admin_btn.Name = "admin_btn";
            admin_btn.Size = new Size(240, 58);
            admin_btn.TabIndex = 6;
            admin_btn.Text = "ADMIN";
            admin_btn.UseVisualStyleBackColor = false;
            admin_btn.Click += admin_btn_Click;
            // 
            // User_btn
            // 
            User_btn.BackColor = SystemColors.ActiveCaption;
            User_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            User_btn.ForeColor = Color.White;
            User_btn.Location = new Point(172, 128);
            User_btn.Name = "User_btn";
            User_btn.Size = new Size(240, 58);
            User_btn.TabIndex = 5;
            User_btn.Text = "USER";
            User_btn.UseVisualStyleBackColor = false;
            User_btn.Click += User_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(120, 36);
            label4.Name = "label4";
            label4.Size = new Size(351, 31);
            label4.TabIndex = 4;
            label4.Text = "WHAT TYPE OF USER ARE YOU?";
            // 
            // X_btn_Login
            // 
            X_btn_Login.BackColor = Color.FromArgb(192, 64, 0);
            X_btn_Login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            X_btn_Login.ForeColor = Color.White;
            X_btn_Login.Location = new Point(795, 11);
            X_btn_Login.Name = "X_btn_Login";
            X_btn_Login.Size = new Size(50, 31);
            X_btn_Login.TabIndex = 3;
            X_btn_Login.Text = "X";
            X_btn_Login.UseVisualStyleBackColor = false;
            X_btn_Login.Click += X_btn_Login_Click;
            // 
            // option
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(855, 633);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(X_btn_Login);
            FormBorderStyle = FormBorderStyle.None;
            Name = "option";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "option";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button admin_btn;
        private Button User_btn;
        private Label label4;
        private Button X_btn_Login;
    }
}