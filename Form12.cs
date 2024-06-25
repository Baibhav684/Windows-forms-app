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
    public partial class Form12 : Form
    {
        public static SqlConnection conn;
        SqlDataReader rdr;
        SqlDataAdapter adp;
        SqlCommandBuilder cmdbldr;
        DataSet ds, ds1;
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            string Query = "Select * from BillMaster";
            conn = new SqlConnection(@"server=(LocalDB)\MSSQLLocalDB;user Id=sa;password=123;database = microproject");
            SqlCommand cmd = new SqlCommand(Query, conn);
            conn.Open();    
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                cmbSelectBill.Items.Add(rdr[0].ToString());
            }
            else
            {
                MessageBox.Show("First order then view Bill");
            }
            conn.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbSelectBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = $"Select * from BillMaster where BillNumber = '{cmbSelectBill.Text}'";
            adp = new SqlDataAdapter(Query,conn);
            ds = new DataSet(); 
            adp.Fill(ds, "Billtrans");
            dataGridView1.DataSource = ds.Tables[0];
            Query = $"Select * from Billtrans where BillNumber = '{cmbSelectBill.Text}'";
            adp = new SqlDataAdapter(Query, conn);
            ds1 = new DataSet();
            adp.Fill(ds1, "BillMaster");
            dataGridView2.DataSource = ds1.Tables[0];
        }
    }
}
