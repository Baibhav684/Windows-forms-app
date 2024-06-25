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
    public partial class Form6 : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        DataRow dr;
        SqlCommandBuilder cmd;
        public Form6()
        {
            InitializeComponent();
        }
        private void Form6_Load(object sender, EventArgs e)
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
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            dr = ds.Tables[0].NewRow();
            dr[0] = txtUsername.Text;
            GlobalData.Username = txtUsername.Text;
            dr[1] = txtPassword.Text;
            dr[2] = txtFname.Text;
            dr[3] = txtLname.Text;
            dr[4] = cmbHQ.Text;
            dr[5] = txtHans.Text;
            ds.Tables[0].Rows.Add(dr);
            MessageBox.Show("you are registered \n click on save","user created",MessageBoxButtons.OK);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            da.Update(ds, "users");
            cmd = new SqlCommandBuilder(da);
            MessageBox.Show("registered");
        }
    }
}
