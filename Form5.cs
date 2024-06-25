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
    public partial class Form5 : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        DataRow dr;
        SqlCommandBuilder cmd;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtItem.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtPrice.Text = dataGridView1.SelectedCells[1].Value.ToString();
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dr = ds.Tables[0].Rows.Find(txtItem.Text);
            dr.Delete();
            MessageBox.Show("deleted");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            da.Update(ds, "items");
            cmd = new SqlCommandBuilder(da);
            MessageBox.Show("saved to server");
        }
    }
}
