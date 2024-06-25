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
    public partial class BillMaster : Form
    {
        SqlConnection conn;
        DataSet DS;
        DataRow Dr;
        SqlDataAdapter Adp;
        SqlCommandBuilder CmdBuldr;
        SqlCommand cmd;
        public static string Billno;
        
        public BillMaster()
        {
            InitializeComponent();
        }
        private void btnAddBill_Click(object sender, EventArgs e)
        {
            BillTrans bill = new BillTrans();
            Billno = txtBillNO.Text;    
            bill.ShowDialog();
            txtDate.Text = GlobalData.BDT.ToString();
            txtAmt.Text = GlobalData.sum.ToString();
            txtST.Text = GlobalData.serviceTax.ToString();
            txtVAT.Text = GlobalData.VAT.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = @"server=(LocalDB)\MSSQLLocalDB;user Id=sa;password=123;database = microproject";
            conn = new SqlConnection(sql);
            string Query = $"insert into BillMaster values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
            cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@p1", BillMaster.Billno);
            cmd.Parameters.AddWithValue("@p2", txtDate.Text);
            cmd.Parameters.AddWithValue("@p3", txtAmt.Text);
            cmd.Parameters.AddWithValue("@p4", txtST.Text);
            cmd.Parameters.AddWithValue("@p5", txtVAT.Text);
            cmd.Parameters.AddWithValue("@p6", txtDiscount.Text);
            cmd.Parameters.AddWithValue("@p7", txtTOtal.Text);
            cmd.Parameters.AddWithValue("@p8", GlobalData.Username);
            conn.Open();
            int x = cmd.ExecuteNonQuery();
            for (int i = 0; i < GlobalData.DS1.Tables[0].Rows.Count;i++)
            {
                Dr = GlobalData.DS1.Tables[0].NewRow();
                Dr = GlobalData.DS1.Tables[0].Rows[i];
                Query = "insert into Billtrans values (@p1,@p2,@p3,@p4,@p5)";
                cmd = new SqlCommand(Query, conn);
                cmd.Parameters.AddWithValue("@p1", Dr[0]);
                cmd.Parameters.AddWithValue("@p2", Dr[1]);
                cmd.Parameters.AddWithValue("@p3", Dr[2]);
                cmd.Parameters.AddWithValue("@p4", Dr[3]);
                cmd.Parameters.AddWithValue("@p5", Dr[4]);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Saved to server");
            conn.Close();
        }
        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            GlobalData.Disco = Convert.ToDouble(txtDiscount.Text);
            GlobalData.TotalBill = (GlobalData.sum + GlobalData.VAT + GlobalData.serviceTax) - GlobalData.Disco;
            txtTOtal.Text = GlobalData.TotalBill.ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Clear();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
