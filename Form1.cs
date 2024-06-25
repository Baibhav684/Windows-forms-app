using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WAMicroProject
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rdr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Constr = @"server=(LocalDB)\MSSQLLocalDB;user Id=sa;password=123;database = microproject";
            conn = new SqlConnection(Constr);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Query = "select * from users where username = @p1 and password = @p2";
            cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@p1",txtusername.Text);
            cmd.Parameters.AddWithValue("@p2",txtPassword.Text);
            Form2 form = new Form2();
            conn.Open();
            rdr = cmd.ExecuteReader();  
            if(rdr.Read())
            {
                MessageBox.Show("Login Complete");
                form.Show();
                this.Hide();
            }
            GlobalData.Username = txtusername.Text;
            conn.Close();
        }
    }
}
