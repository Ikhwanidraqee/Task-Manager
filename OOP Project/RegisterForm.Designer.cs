namespace TMOOP3
{
    partial class RegisterForm
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
            register_confirmpassword = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            register_btn = new Button();
            register_showPassword = new CheckBox();
            label4 = new Label();
            register_password = new TextBox();
            register_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            X_btn_Login = new Button();
            back_btn_reg = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(171, 32);
            label1.Name = "label1";
            label1.Size = new Size(449, 41);
            label1.TabIndex = 2;
            label1.Text = "WELCOME TO TASK MONSTER";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(register_confirmpassword);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(register_btn);
            panel1.Controls.Add(register_showPassword);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(register_password);
            panel1.Controls.Add(register_username);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(95, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(594, 475);
            panel1.TabIndex = 4;
            // 
            // register_confirmpassword
            // 
            register_confirmpassword.Location = new Point(234, 254);
            register_confirmpassword.Name = "register_confirmpassword";
            register_confirmpassword.PasswordChar = '*';
            register_confirmpassword.Size = new Size(291, 27);
            register_confirmpassword.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(76, 245);
            label7.Name = "label7";
            label7.Size = new Size(110, 46);
            label7.TabIndex = 9;
            label7.Text = "CONFIRM\r\nPASSWORD";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(328, 427);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 8;
            label6.Text = "Login Here";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(153, 427);
            label5.Name = "label5";
            label5.Size = new Size(178, 20);
            label5.TabIndex = 7;
            label5.Text = "Already have an account?";
            // 
            // register_btn
            // 
            register_btn.BackColor = SystemColors.ActiveCaption;
            register_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            register_btn.ForeColor = Color.White;
            register_btn.Location = new Point(202, 345);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(197, 37);
            register_btn.TabIndex = 6;
            register_btn.Text = "Register";
            register_btn.UseVisualStyleBackColor = false;
            register_btn.Click += register_btn_Click;
            // 
            // register_showPassword
            // 
            register_showPassword.AutoSize = true;
            register_showPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            register_showPassword.Location = new Point(385, 287);
            register_showPassword.Name = "register_showPassword";
            register_showPassword.Size = new Size(140, 24);
            register_showPassword.TabIndex = 5;
            register_showPassword.Text = "Show Password";
            register_showPassword.UseVisualStyleBackColor = true;
            register_showPassword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(202, 71);
            label4.Name = "label4";
            label4.Size = new Size(231, 31);
            label4.TabIndex = 4;
            label4.Text = "REGISTER ACCOUNT";
            // 
            // register_password
            // 
            register_password.Location = new Point(234, 192);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(291, 27);
            register_password.TabIndex = 3;
            // 
            // register_username
            // 
            register_username.Location = new Point(234, 129);
            register_username.Name = "register_username";
            register_username.Size = new Size(291, 27);
            register_username.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(76, 193);
            label3.Name = "label3";
            label3.Size = new Size(110, 23);
            label3.TabIndex = 1;
            label3.Text = "PASSWORD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(76, 128);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 0;
            label2.Text = "USERNAME";
            // 
            // X_btn_Login
            // 
            X_btn_Login.BackColor = Color.FromArgb(192, 64, 0);
            X_btn_Login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            X_btn_Login.ForeColor = Color.White;
            X_btn_Login.Location = new Point(779, 10);
            X_btn_Login.Name = "X_btn_Login";
            X_btn_Login.Size = new Size(50, 31);
            X_btn_Login.TabIndex = 3;
            X_btn_Login.Text = "X";
            X_btn_Login.UseVisualStyleBackColor = false;
            X_btn_Login.Click += X_btn_Login_Click;
            // 
            // back_btn_reg
            // 
            back_btn_reg.BackColor = SystemColors.HotTrack;
            back_btn_reg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back_btn_reg.ForeColor = Color.White;
            back_btn_reg.Location = new Point(12, 12);
            back_btn_reg.Name = "back_btn_reg";
            back_btn_reg.Size = new Size(81, 31);
            back_btn_reg.TabIndex = 11;
            back_btn_reg.Text = "BACK";
            back_btn_reg.UseVisualStyleBackColor = false;
            back_btn_reg.Click += back_btn_reg_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(837, 586);
            Controls.Add(back_btn_reg);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(X_btn_Login);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Button register_btn;
        private CheckBox register_showPassword;
        private Label label4;
        private TextBox register_password;
        private TextBox register_username;
        private Label label3;
        private Label label2;
        private Button X_btn_Login;
        private TextBox register_confirmpassword;
        private Label label7;
        private Button back_btn_reg;
    }
}