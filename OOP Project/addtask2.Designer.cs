namespace TMOOP3
{
    partial class addtask2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            panel1 = new Panel();
            clearTask_btn = new Button();
            removeTask_btn = new Button();
            updateTask_btn = new Button();
            addTask_btn = new Button();
            addTask_password = new TextBox();
            label2 = new Label();
            addTask_username = new TextBox();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(310, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(569, 680);
            panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(520, 596);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 27);
            label5.Name = "label5";
            label5.Size = new Size(86, 28);
            label5.TabIndex = 12;
            label5.Text = "All User";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(clearTask_btn);
            panel1.Controls.Add(removeTask_btn);
            panel1.Controls.Add(updateTask_btn);
            panel1.Controls.Add(addTask_btn);
            panel1.Controls.Add(addTask_password);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(addTask_username);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 680);
            panel1.TabIndex = 2;
            // 
            // clearTask_btn
            // 
            clearTask_btn.BackColor = SystemColors.ActiveCaption;
            clearTask_btn.FlatAppearance.CheckedBackColor = SystemColors.HotTrack;
            clearTask_btn.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            clearTask_btn.FlatAppearance.MouseOverBackColor = SystemColors.HotTrack;
            clearTask_btn.FlatStyle = FlatStyle.Flat;
            clearTask_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearTask_btn.ForeColor = Color.White;
            clearTask_btn.Location = new Point(145, 483);
            clearTask_btn.Name = "clearTask_btn";
            clearTask_btn.Size = new Size(101, 61);
            clearTask_btn.TabIndex = 11;
            clearTask_btn.Text = "Clear";
            clearTask_btn.UseVisualStyleBackColor = false;
            clearTask_btn.Click += clearTask_btn_Click;
            // 
            // removeTask_btn
            // 
            removeTask_btn.BackColor = SystemColors.ActiveCaption;
            removeTask_btn.FlatAppearance.CheckedBackColor = SystemColors.HotTrack;
            removeTask_btn.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            removeTask_btn.FlatAppearance.MouseOverBackColor = SystemColors.HotTrack;
            removeTask_btn.FlatStyle = FlatStyle.Flat;
            removeTask_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeTask_btn.ForeColor = Color.White;
            removeTask_btn.Location = new Point(19, 483);
            removeTask_btn.Name = "removeTask_btn";
            removeTask_btn.Size = new Size(101, 61);
            removeTask_btn.TabIndex = 10;
            removeTask_btn.Text = "Remove";
            removeTask_btn.UseVisualStyleBackColor = false;
            removeTask_btn.Click += removeTask_btn_Click;
            // 
            // updateTask_btn
            // 
            updateTask_btn.BackColor = SystemColors.ActiveCaption;
            updateTask_btn.FlatAppearance.CheckedBackColor = SystemColors.HotTrack;
            updateTask_btn.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            updateTask_btn.FlatAppearance.MouseOverBackColor = SystemColors.HotTrack;
            updateTask_btn.FlatStyle = FlatStyle.Flat;
            updateTask_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateTask_btn.ForeColor = Color.White;
            updateTask_btn.Location = new Point(145, 400);
            updateTask_btn.Name = "updateTask_btn";
            updateTask_btn.Size = new Size(101, 61);
            updateTask_btn.TabIndex = 9;
            updateTask_btn.Text = "Update";
            updateTask_btn.UseVisualStyleBackColor = false;
            updateTask_btn.Click += updateTask_btn_Click;
            // 
            // addTask_btn
            // 
            addTask_btn.BackColor = SystemColors.ActiveCaption;
            addTask_btn.FlatAppearance.CheckedBackColor = SystemColors.HotTrack;
            addTask_btn.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            addTask_btn.FlatAppearance.MouseOverBackColor = SystemColors.HotTrack;
            addTask_btn.FlatStyle = FlatStyle.Flat;
            addTask_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addTask_btn.ForeColor = Color.White;
            addTask_btn.Location = new Point(19, 400);
            addTask_btn.Name = "addTask_btn";
            addTask_btn.Size = new Size(101, 61);
            addTask_btn.TabIndex = 8;
            addTask_btn.Text = "Add";
            addTask_btn.UseVisualStyleBackColor = false;
            addTask_btn.Click += addTask_btn_Click;
            // 
            // addTask_password
            // 
            addTask_password.Location = new Point(3, 190);
            addTask_password.Name = "addTask_password";
            addTask_password.Size = new Size(266, 27);
            addTask_password.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 159);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // addTask_username
            // 
            addTask_username.Location = new Point(3, 120);
            addTask_username.Name = "addTask_username";
            addTask_username.Size = new Size(266, 27);
            addTask_username.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 89);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // addtask2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "addtask2";
            Size = new Size(891, 705);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label5;
        private Panel panel1;
        private Button clearTask_btn;
        private Button removeTask_btn;
        private Button updateTask_btn;
        private Button addTask_btn;
        private TextBox addTask_password;
        private Label label2;
        private TextBox addTask_username;
        private Label label1;
    }
}
