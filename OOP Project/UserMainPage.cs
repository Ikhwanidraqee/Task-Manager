using System.Drawing;
using Microsoft.Data.SqlClient;
using System.Data;
using System;
using System.Windows.Forms;

namespace TMOOP3
{
    public partial class UserMainPage : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\idraq\Documents\OOP PROJECT\TMOOP3\Task Monster.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=True");
        Function Con;
        
        public UserMainPage()
        {
            InitializeComponent();
            Con = new Function();
            ShowUserMainPage();
            diaplayAllUserData();
        }

        public void diaplayAllUserData()
        {
            UserData userData = new UserData();

            List<UserData> listData = userData.AllUsersData();

            taskList_gridView.DataSource = listData;
        }

        private void LoadData()
        {
            string query = "SELECT * FROM TaskManagerTable";
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\idraq\Documents\OOP PROJECT\TMOOP3\Task Monster.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=True"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                taskList_gridView.DataSource = dt;
            }
        }

        private void ShowUserMainPage()
        {
            string Query = "SELECT * FROM TaskManagerTable";
            taskList_gridView.DataSource = Con.GetData(Query);


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void X_btn_regUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?",
                "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?",
                "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DueDate dd = new DueDate();
            dd.Show();

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void taskList_gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveAddTask_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (TaskName_txtbx.Text == "" || TaskDesc_txtbx.Text == "" || TaskPrio_cmbbx.SelectedItem.ToString() == "" || Link_txtbx.Text == "" || Loc_txtbx.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string TaskName = TaskName_txtbx.Text;
                    string TaskDesc = TaskDesc_txtbx.Text;
                    string TaskPrio = TaskPrio_cmbbx.SelectedItem.ToString();
                    string TaskLink = Link_txtbx.Text;
                    string TaskLoc = Loc_txtbx.Text;
                    string Query = "insert into TaskManagerTable values ('{0}','{1}','{2}','{3}','{4}')";
                    Query = string.Format(Query, TaskName, TaskDesc, TaskPrio, TaskLink, TaskLoc);
                    Con.SetData(Query);
                    ShowUserMainPage();
                    TaskName_txtbx.Text = "";
                    TaskDesc_txtbx.Text = "";
                    TaskPrio_cmbbx.SelectedItem = "";
                    Link_txtbx.Text = "";
                    Loc_txtbx.Text = "";

                    diaplayAllUserData();


                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int Key = 0;
        private void taskList_gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TaskName_txtbx.Text = taskList_gridView.SelectedRows[0].Cells[1].Value.ToString();
                TaskDesc_txtbx.Text = taskList_gridView.SelectedRows[0].Cells[2].Value.ToString();
                TaskPrio_cmbbx.SelectedItem = taskList_gridView.SelectedRows[0].Cells[3].Value.ToString();
                Link_txtbx.Text = taskList_gridView.SelectedRows[0].Cells[4].Value.ToString();
                Loc_txtbx.Text = taskList_gridView.SelectedRows[0].Cells[5].Value.ToString();

                if (TaskName_txtbx.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(taskList_gridView.SelectedRows[0].Cells[0].Value.ToString());
                }

            }
        }

        public bool checkConnection()
        {
            if (connect != null && connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void clearField()
        {
            TaskName_txtbx.Text = "";
            TaskDesc_txtbx.Text = "";
            TaskPrio_cmbbx.SelectedItem = "";
            Link_txtbx.Text = "";
            Loc_txtbx.Text = "";
        }
        private void UserMainPage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private int getID()
        {
            return Convert.ToInt32(taskList_gridView.SelectedRows[0].Cells[0].Value);
        }

        private void deleteAddTask_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected
                if (taskList_gridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("No row selected. Please select a task to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get TaskID from the selected row
                int taskId = Convert.ToInt32(taskList_gridView.SelectedRows[0].Cells["TaskMId"].Value);

                // Confirm delete action
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this task?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Perform delete
                    string query = "DELETE FROM TaskManagerTable WHERE TaskMId = @TaskMId";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@TaskMId", taskId);

                        connect.Open();
                        cmd.ExecuteNonQuery();
                        connect.Close();

                        MessageBox.Show("Task deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        diaplayAllUserData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void editAddTask_btn_Click(object sender, EventArgs e)
        {
            int TaskId = 0;
            string taskName = TaskName_txtbx.Text;
            string taskDescription = TaskDesc_txtbx.Text;
            string taskPriority = TaskPrio_cmbbx.Text;
            string taskLink = Link_txtbx.Text;
            string taskLoc = Loc_txtbx.Text;

            // Validate TaskMId
            string taskIdInput = taskList_gridView.SelectedRows[0].Cells["TaskMId"].Value.ToString();
            int taskId;
            if (!int.TryParse(taskIdInput, out taskId))
            {
                MessageBox.Show("Task ID must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate TaskName
            if (string.IsNullOrWhiteSpace(taskName))
            {
                MessageBox.Show("Task Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "UPDATE TaskManagerTable SET TaskName = @TaskName, TaskDescription = @TaskDescription, TaskPriority = @TaskPriority, TaskLoc = @TaskLoc WHERE TaskMId = @TaskMId";

            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\idraq\Documents\OOP PROJECT\TMOOP3\Task Monster.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=True"))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TaskMId", taskId);
                        cmd.Parameters.AddWithValue("@TaskName", taskName);
                        cmd.Parameters.AddWithValue("@TaskDesc", taskDescription);
                        cmd.Parameters.AddWithValue("@TaskPriority", taskPriority);
                        cmd.Parameters.AddWithValue("@TaskLink", taskLoc);
                        cmd.Parameters.AddWithValue("@TaskLoc", taskId);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Task updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
