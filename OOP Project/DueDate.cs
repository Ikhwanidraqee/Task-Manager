using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace TMOOP3
{
    public partial class DueDate : Form
    {
        Function Con;
        public DueDate()
        {
            InitializeComponent();
            Con = new Function();
            ShowDueDate();
            GetTaskManager();
            
        }

        private void ShowDueDate()
        {
            string Query = "SELECT * FROM DueDateTable";
            DueDateGrid.DataSource = Con.GetData(Query);
        }
        
        private void LoadData()
        {
            
        }

        private void GetTaskManager()
        {
            string Query = "select * from TaskManagerTable";
            TaskName_cmbbx.DisplayMember = Con.GetData(Query).Columns["TaskName"].ToString();
            TaskName_cmbbx.ValueMember = Con.GetData(Query).Columns["TaskMId"].ToString();
            TaskName_cmbbx.DataSource = Con.GetData(Query);
        }

        
        public void diaplayAllUserData()
        {
            UserData userData = new UserData();

            List<UserData> listData = userData.AllUsersData();

            DueDateGrid.DataSource = listData;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserMainPage um = new UserMainPage();
            um.Show();

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void saveAddTask_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (TaskName_cmbbx.SelectedIndex == -1 || statuscmbbx.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    int TaskName = Convert.ToInt32(TaskName_cmbbx.SelectedValue?.ToString());
                    int TaskStatus = Convert.ToInt32(statuscmbbx.SelectedValue?.ToString());
                    string StartDate = startDatePicker.Value.Date.ToString();
                    string EndDate = EnddateTimePicker.Value.Date.ToString();
                    string Query = "insert into DueDateTable (TaskName, Status, DateStart, DateEnd) values ({0}, {1}, '{2}', '{3}')";
                    Query = string.Format(Query, TaskName, TaskStatus, StartDate, EndDate);
                    Con.SetData(Query);
                    ShowDueDate();


                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void DueDate_Load(object sender, EventArgs e)
        {

        }

        int Key = 0;
        private void DueDateGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TaskName_cmbbx.Text = DueDateGrid.SelectedRows[0].Cells[1].Value.ToString();
                statuscmbbx.Text = DueDateGrid.SelectedRows[0].Cells[2].Value.ToString();
                startDatePicker.Text = DueDateGrid.SelectedRows[0].Cells[3].Value.ToString();
                EnddateTimePicker.Text = DueDateGrid.SelectedRows[0].Cells[4].Value.ToString();

                if (TaskName_cmbbx.SelectedIndex == -1)
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(DueDateGrid.SelectedRows[0].Cells[0].Value.ToString());
                }

            }
        }

        private void editAddTask_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (TaskName_cmbbx.SelectedIndex == -1 || statuscmbbx.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    int TaskName = Convert.ToInt32(TaskName_cmbbx.SelectedValue?.ToString());
                    int TaskStatus = Convert.ToInt32(statuscmbbx.SelectedValue?.ToString());
                    string StartDate = startDatePicker.Value.Date.ToString();
                    string EndDate = EnddateTimePicker.Value.Date.ToString();
                    string Query = "update DueDateTable set TaskName = {0}, Status = {1}, DateStart = '{2}', DateEnd = '{3}'  where DId= {4}";
                    Query = string.Format(Query, TaskName, TaskStatus, StartDate, EndDate, Key);
                    Con.SetData(Query);
                    ShowDueDate();
                    /*TaskName_cmbbx.Text = "";
                    statuscmbbx.Text = "";
                    startDatePicker.Text = "";
                    EnddateTimePicker.Text = "";

                    diaplayAllUserData();*/


                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void deleteAddTask_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (TaskName_cmbbx.SelectedIndex == -1 || statuscmbbx.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {

                    string Query = "delete from DueDateTable where DId= {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowDueDate();
                    /*TaskName_cmbbx.Text = "";
                    statuscmbbx.Text = "";
                    startDatePicker.Text = "";
                    EnddateTimePicker.Text = "";

                    diaplayAllUserData();*/


                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowDueDate();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
