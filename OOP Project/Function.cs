using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace TMOOP3
{
    internal class Function
    {
        private Microsoft.Data.SqlClient.SqlConnection Con;
        private Microsoft.Data.SqlClient.SqlCommand Cmd;
        private DataTable dt;
        private Microsoft.Data.SqlClient.SqlDataAdapter sda;
        private string Constr;
        public Function()
        {
            Constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\idraq\Documents\OOP PROJECT\TMOOP3\Task Monster.mdf"";Integrated Security=True;Connect Timeout=30";
            Con = new Microsoft.Data.SqlClient.SqlConnection(Constr);
            Cmd = new Microsoft.Data.SqlClient.SqlCommand();
            Cmd.Connection = Con;
        }

        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            sda = new Microsoft.Data.SqlClient.SqlDataAdapter(Query,Con);
            sda.Fill(dt);
            return dt;
        }

        public int SetData(string Query)
        {
            int Cnt = 0;
            if(Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            Cmd.CommandText = Query;
            Cnt = Cmd.ExecuteNonQuery();
            return Cnt;
        }
    }
}
