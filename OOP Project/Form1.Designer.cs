namespace TMOOP3
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
            X_btn_Login = new Button();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            login_btn = new Button();
            login_showpassword = new CheckBox();
            label4 = new Label();
            login_password = new TextBox();
            login_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            back_btn_login = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // X_btn_Login
            // 
            X_btn_Login.BackColor = Color.FromArgb(192, 64, 0);
            X_btn_Login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            X_btn_Login.ForeColor = Color.White;
            X_btn_Login.Location = new Point(793, 12);
            X_btn_Login.Name = "X_btn_Login";
            X_btn_Login.Size = new Size(50, 31);
            X_btn_Login.TabIndex = 0;
            X_btn_Login.Text = "X";
            X_btn_Login.UseVisualStyleBackColor = false;
            X_btn_Login.Click += X_btn_Login_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(login_btn);
            panel1.Controls.Add(login_showpassword);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(login_password);
            panel1.Controls.Add(login_username);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(109, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(594, 475);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(331, 429);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 8;
            label6.Text = "Register Here";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(184, 429);
            label5.Name = "label5";
            label5.Size = new Size(151, 20);
            label5.TabIndex = 7;
            label5.Text = "Have no account yet?";
            // 
            // login_btn
            // 
            login_btn.BackColor = SystemColors.ActiveCaption;
            login_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(202, 344);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(197, 37);
            login_btn.TabIndex = 6;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // login_showpassword
            // 
            login_showpassword.AutoSize = true;
            login_showpassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_showpassword.Location = new Point(385, 260);
            login_showpassword.Name = "login_showpassword";
            login_showpassword.Size = new Size(140, 24);
            login_showpassword.TabIndex = 5;
            login_showpassword.Text = "Show Password";
            login_showpassword.UseVisualStyleBackColor = true;
            login_showpassword.CheckedChanged += login_showpassword_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(161, 84);
            label4.Name = "label4";
            label4.Size = new Size(283, 31);
            label4.TabIndex = 4;
            label4.Text = "ADMIN LOGIN ACCOUNT";
            // 
            // login_password
            // 
            login_password.Location = new Point(234, 210);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(291, 27);
            login_password.TabIndex = 3;
            // 
            // login_username
            // 
            login_username.Location = new Point(234, 147);
            login_username.Name = "login_username";
            login_username.Size = new Size(291, 27);
            login_username.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(76, 211);
            label3.Name = "label3";
            label3.Size = new Size(110, 23);
            label3.TabIndex = 1;
            label3.Text = "PASSWORD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(76, 146);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 0;
            label2.Text = "USERNAME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(185, 34);
            label1.Name = "label1";
            label1.Size = new Size(449, 41);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO TASK MONSTER";
            // 
            // back_btn_login
            // 
            back_btn_login.BackColor = SystemColors.HotTrack;
            back_btn_login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back_btn_login.ForeColor = Color.White;
            back_btn_login.Location = new Point(12, 12);
            back_btn_login.Name = "back_btn_login";
            back_btn_login.Size = new Size(81, 31);
            back_btn_login.TabIndex = 2;
            back_btn_login.Text = "BACK";
            back_btn_login.UseVisualStyleBackColor = false;
            back_btn_login.Click += back_btn_login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(855, 633);
            Controls.Add(back_btn_login);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(X_btn_Login);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button X_btn_Login;
        private Panel panel1;
        private Label label1;
        private Label label4;
        private TextBox login_password;
        private TextBox login_username;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private Button login_btn;
        private CheckBox login_showpassword;
        private Button back_btn_login;
    }
}
