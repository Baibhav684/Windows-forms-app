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
    public partial class Form8 : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        DataRow dr;
        DataRow[] rdr;
        SqlCommandBuilder cmd;

        public Form8()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblHques.Visible = true;
            comboBox1.Visible = true;
            lblHans.Text = "Enter Hint Answer";
        }

        private void radioButtonoldPassword_CheckedChanged(object sender, EventArgs e)
        {
            lblHques.Visible = false;
            comboBox1.Visible = false;
            lblHans.Text = "Enter old Password";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                rdr = ds.Tables[0].Select($"HintQuestion = '{comboBox1.SelectedItem.ToString()}' and HintAnswer = '{txtHans.Text}'");
                if (rdr.Length > 0)
                {
                    dr = rdr[0];
                    dr[1] = txtNpass.Text;
                    da.Update(ds, "users");
                    cmd = new SqlCommandBuilder(da);
                    MessageBox.Show("updated");
                }
                else MessageBox.Show("wrong cresidentials");
            }
            else if (radioButtonoldPassword.Checked)
            {
                dr = ds.Tables[0].Select($"password = '{txtHans.Text}'")[0];
                if (dr != null)
                {
                    dr[1] = txtNpass.Text;
                    da.Update(ds, "users");
                    cmd = new SqlCommandBuilder(da);
                    MessageBox.Show("updated");
                }
                else
                    MessageBox.Show("wrong cresidentials");
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            string Constr = @"server=(LocalDB)\MSSQLLocalDB;user Id=sa;password=123;database = microproject";
            conn = new SqlConnection(Constr);
            string Query = "select * from users";
            ds = new DataSet();
            da = new SqlDataAdapter(Query, conn);
            da.Fill(ds, "users");
            da.FillSchema(ds, SchemaType.Source, "users");
            cmd = new SqlCommandBuilder(da);
        }
    }
}
