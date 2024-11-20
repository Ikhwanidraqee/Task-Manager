namespace TMOOP3
{
    partial class UserMainPage
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
            button7 = new Button();
            button5 = new Button();
            button4 = new Button();
            panel2 = new Panel();
            X_btn_regUser = new Button();
            label1 = new Label();
            label2 = new Label();
            TaskName_txtbx = new TextBox();
            label3 = new Label();
            label4 = new Label();
            TaskDesc_txtbx = new TextBox();
            label5 = new Label();
            label6 = new Label();
            Link_txtbx = new TextBox();
            label7 = new Label();
            Loc_txtbx = new TextBox();
            TaskPrio_cmbbx = new ComboBox();
            saveAddTask_btn = new Button();
            editAddTask_btn = new Button();
            deleteAddTask_btn = new Button();
            panel3 = new Panel();
            taskList_gridView = new DataGridView();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)taskList_gridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 750);
            panel1.TabIndex = 0;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.HotTrack;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(3, 698);
            button7.Name = "button7";
            button7.Size = new Size(213, 40);
            button7.TabIndex = 23;
            button7.Text = "LOGOUT";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(26, 277);
            button5.Name = "button5";
            button5.Size = new Size(169, 43);
            button5.TabIndex = 21;
            button5.Text = "ADD DUE DATE";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(47, 181);
            button4.Name = "button4";
            button4.Size = new Size(123, 43);
            button4.TabIndex = 20;
            button4.Text = "ADD TASK";
            button4.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(X_btn_regUser);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(219, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1146, 50);
            panel2.TabIndex = 1;
            // 
            // X_btn_regUser
            // 
            X_btn_regUser.BackColor = Color.FromArgb(192, 64, 0);
            X_btn_regUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            X_btn_regUser.ForeColor = Color.White;
            X_btn_regUser.Location = new Point(1084, 3);
            X_btn_regUser.Name = "X_btn_regUser";
            X_btn_regUser.Size = new Size(50, 31);
            X_btn_regUser.TabIndex = 18;
            X_btn_regUser.Text = "X";
            X_btn_regUser.UseVisualStyleBackColor = false;
            X_btn_regUser.Click += X_btn_regUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(503, 9);
            label1.Name = "label1";
            label1.Size = new Size(185, 31);
            label1.TabIndex = 2;
            label1.Text = "TASK MONSTER";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(719, 53);
            label2.Name = "label2";
            label2.Size = new Size(188, 38);
            label2.TabIndex = 2;
            label2.Text = "Manage Task";
            // 
            // TaskName_txtbx
            // 
            TaskName_txtbx.Location = new Point(289, 160);
            TaskName_txtbx.Name = "TaskName_txtbx";
            TaskName_txtbx.Size = new Size(248, 27);
            TaskName_txtbx.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(289, 129);
            label3.Name = "label3";
            label3.Size = new Size(115, 28);
            label3.TabIndex = 4;
            label3.Text = "Task Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(580, 129);
            label4.Name = "label4";
            label4.Size = new Size(168, 28);
            label4.TabIndex = 6;
            label4.Text = "Task Description";
            // 
            // TaskDesc_txtbx
            // 
            TaskDesc_txtbx.Location = new Point(580, 160);
            TaskDesc_txtbx.Name = "TaskDesc_txtbx";
            TaskDesc_txtbx.Size = new Size(248, 27);
            TaskDesc_txtbx.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(867, 129);
            label5.Name = "label5";
            label5.Size = new Size(130, 28);
            label5.TabIndex = 8;
            label5.Text = "Task Priority";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(443, 206);
            label6.Name = "label6";
            label6.Size = new Size(51, 28);
            label6.TabIndex = 10;
            label6.Text = "Link";
            // 
            // Link_txtbx
            // 
            Link_txtbx.Location = new Point(443, 237);
            Link_txtbx.Name = "Link_txtbx";
            Link_txtbx.Size = new Size(248, 27);
            Link_txtbx.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(741, 206);
            label7.Name = "label7";
            label7.Size = new Size(93, 28);
            label7.TabIndex = 12;
            label7.Text = "Location";
            // 
            // Loc_txtbx
            // 
            Loc_txtbx.Location = new Point(741, 237);
            Loc_txtbx.Name = "Loc_txtbx";
            Loc_txtbx.Size = new Size(248, 27);
            Loc_txtbx.TabIndex = 11;
            // 
            // TaskPrio_cmbbx
            // 
            TaskPrio_cmbbx.FormattingEnabled = true;
            TaskPrio_cmbbx.Items.AddRange(new object[] { "High", "Medium", "Low" });
            TaskPrio_cmbbx.Location = new Point(867, 159);
            TaskPrio_cmbbx.Name = "TaskPrio_cmbbx";
            TaskPrio_cmbbx.Size = new Size(248, 28);
            TaskPrio_cmbbx.TabIndex = 13;
            // 
            // saveAddTask_btn
            // 
            saveAddTask_btn.BackColor = SystemColors.ActiveCaption;
            saveAddTask_btn.FlatAppearance.BorderSize = 0;
            saveAddTask_btn.FlatStyle = FlatStyle.Flat;
            saveAddTask_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            saveAddTask_btn.Location = new Point(1199, 114);
            saveAddTask_btn.Name = "saveAddTask_btn";
            saveAddTask_btn.Size = new Size(123, 43);
            saveAddTask_btn.TabIndex = 14;
            saveAddTask_btn.Text = "Save";
            saveAddTask_btn.UseVisualStyleBackColor = false;
            saveAddTask_btn.Click += saveAddTask_btn_Click;
            // 
            // editAddTask_btn
            // 
            editAddTask_btn.BackColor = SystemColors.Highlight;
            editAddTask_btn.FlatAppearance.BorderSize = 0;
            editAddTask_btn.FlatStyle = FlatStyle.Flat;
            editAddTask_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            editAddTask_btn.Location = new Point(1199, 172);
            editAddTask_btn.Name = "editAddTask_btn";
            editAddTask_btn.Size = new Size(123, 43);
            editAddTask_btn.TabIndex = 15;
            editAddTask_btn.Text = "Edit";
            editAddTask_btn.UseVisualStyleBackColor = false;
            editAddTask_btn.Click += editAddTask_btn_Click;
            // 
            // deleteAddTask_btn
            // 
            deleteAddTask_btn.BackColor = SystemColors.HotTrack;
            deleteAddTask_btn.FlatAppearance.BorderSize = 0;
            deleteAddTask_btn.FlatStyle = FlatStyle.Flat;
            deleteAddTask_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            deleteAddTask_btn.Location = new Point(1199, 229);
            deleteAddTask_btn.Name = "deleteAddTask_btn";
            deleteAddTask_btn.Size = new Size(123, 43);
            deleteAddTask_btn.TabIndex = 16;
            deleteAddTask_btn.Text = "Delete";
            deleteAddTask_btn.UseVisualStyleBackColor = false;
            deleteAddTask_btn.Click += deleteAddTask_btn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Location = new Point(219, 315);
            panel3.Name = "panel3";
            panel3.Size = new Size(1146, 5);
            panel3.TabIndex = 17;
            // 
            // taskList_gridView
            // 
            taskList_gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            taskList_gridView.GridColor = SystemColors.HotTrack;
            taskList_gridView.Location = new Point(225, 396);
            taskList_gridView.Name = "taskList_gridView";
            taskList_gridView.RowHeadersWidth = 51;
            taskList_gridView.Size = new Size(1140, 342);
            taskList_gridView.TabIndex = 18;
            taskList_gridView.CellClick += taskList_gridView_CellClick;
            taskList_gridView.CellContentClick += taskList_gridView_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(741, 338);
            label8.Name = "label8";
            label8.Size = new Size(127, 38);
            label8.TabIndex = 19;
            label8.Text = "Task List";
            // 
            // UserMainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 750);
            Controls.Add(label8);
            Controls.Add(taskList_gridView);
            Controls.Add(panel3);
            Controls.Add(deleteAddTask_btn);
            Controls.Add(editAddTask_btn);
            Controls.Add(saveAddTask_btn);
            Controls.Add(TaskPrio_cmbbx);
            Controls.Add(label7);
            Controls.Add(Loc_txtbx);
            Controls.Add(label6);
            Controls.Add(Link_txtbx);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TaskDesc_txtbx);
            Controls.Add(label3);
            Controls.Add(TaskName_txtbx);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserMainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserMainPage";
            Load += UserMainPage_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)taskList_gridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private TextBox TaskName_txtbx;
        private Label label3;
        private Label label4;
        private TextBox TaskDesc_txtbx;
        private Label label5;
        private Label label6;
        private TextBox Link_txtbx;
        private Label label7;
        private TextBox Loc_txtbx;
        private ComboBox TaskPrio_cmbbx;
        private Button saveAddTask_btn;
        private Button editAddTask_btn;
        private Button deleteAddTask_btn;
        private Panel panel3;
        private Button button5;
        private Button button4;
        private Button X_btn_regUser;
        private DataGridView taskList_gridView;
        private Label label8;
        private Button button7;
    }
}