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
    public partial class Form3 : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmd;
        DataRow dr;
        public Form3()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            da.Update(ds, "Items");
            cmd = new SqlCommandBuilder(da);
            MessageBox.Show("Added to server");
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            string Constr = @"server=(LocalDB)\MSSQLLocalDB;user Id=sa;password=123;database = microproject";
            conn = new SqlConnection(Constr);
            string Query = "select * from items";
            ds = new DataSet();
            da = new SqlDataAdapter(Query, conn);
            da.Fill(ds, "Items");
            da.FillSchema(ds, SchemaType.Source, "Items");
            cmd = new SqlCommandBuilder(da);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dr = ds.Tables[0].NewRow();
            dr[0] = txtItem.Text;
            dr[1] = txtPrice.Text;
            ds.Tables[0].Rows.Add(dr);
            MessageBox.Show("added");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
