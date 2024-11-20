using Microsoft.Data.SqlClient;
using System.Data;

namespace TMOOP3
{
    public partial class addtask2 : UserControl
    {
        public addtask2()
        {
            InitializeComponent();

            diaplayAllUserData();
        }


        SqlConnection
           connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\idraq\Documents\OOP PROJECT\TMOOP3\Task Monster.mdf"";Integrated Security=True;Connect Timeout=30");

        public void diaplayAllUserData()
        {
            UserData userData = new UserData();

            List<UserData> listData = userData.AllUsersData();

            dataGridView1.DataSource = listData;
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void addTask_btn_Click(object sender, EventArgs e)
        {
            if (addTask_btn.Text == "" || addTask_password.Text == "")
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string checkUsername = "SELECT * FROM users2 WHERE username = @usern";

                        using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", addTask_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(addTask_username.Text.Trim()
                                    + "is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users2 (username, password, date)" +
                                    "VALUES(@usern, @pass, @date)";
                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@usern", addTask_username.Text.Trim());
                                    insertD.Parameters.AddWithValue("@pass", addTask_password.Text.Trim());

                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();
                                    clearField();
                                    diaplayAllUserData();

                                    MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Failed" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
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
            addTask_username.Text = "";
            addTask_password.Text = "";
        }
        private void clearTask_btn_Click(object sender, EventArgs e)
        {
            clearField();
        }

        private void updateTask_btn_Click(object sender, EventArgs e)
        {
            if (addTask_btn.Text == "" || addTask_password.Text == "")
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update ID:" + getID + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();


                            string updateData = "UPDATE users2 SET username = @usern, " +
                                "password = @pass WHERE id = @id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@usern", addTask_username.Text.Trim());
                                updateD.Parameters.AddWithValue("@pass", addTask_password.Text.Trim());
                                updateD.Parameters.AddWithValue("@id", getID);

                                updateD.ExecuteNonQuery();
                                clearField();
                                diaplayAllUserData();

                                MessageBox.Show("Update Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection Filed" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }

            }
        }

        private int getID = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                string username = row.Cells[1].Value.ToString();
                string password = row.Cells[2].Value.ToString();


                addTask_username.Text = username;
                addTask_password.Text = password;


            }
        }

        private void removeTask_btn_Click(object sender, EventArgs e)
        {
            if (addTask_btn.Text == "" || addTask_password.Text == "")
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Remove ID:" + getID + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();


                            string updateData = "DELETE FROM users2 WHERE id = @id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {

                                updateD.Parameters.AddWithValue("@id", getID);
                                updateD.ExecuteNonQuery();

                                clearField();
                                diaplayAllUserData();

                                MessageBox.Show("Delete Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection Failed" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
