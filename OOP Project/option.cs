using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMOOP3
{
    public partial class option : Form
    {
        public option()
        {
            InitializeComponent();
        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }

        private void X_btn_Login_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void User_btn_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();

            this.Hide();
        }
    }
}
