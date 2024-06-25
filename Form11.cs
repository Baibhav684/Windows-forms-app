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
    public partial class BillTrans : Form
    {
        static SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader Dr;
        SqlDataAdapter Adp;
        DataRow r;
        SqlCommandBuilder cmdBuld;

        public BillTrans()
        {
            InitializeComponent();
        }
        private void BillTrans_Load(object sender, EventArgs e)
        {
            string sql = @"server=(LocalDB)\MSSQLLocalDB;user Id=sa;password=123;database = microproject";
            conn = new SqlConnection(sql);
            string Query = "select * from Items";
            cmd = new SqlCommand(Query, conn);
            conn.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                cmbItems.Items.Add(Dr[0].ToString());
            }
            conn.Close();
            Query = "select * from Billtrans";
            Adp = new SqlDataAdapter(Query, conn);
            Adp.Fill(GlobalData.DS1, "Billtrans");
            Adp.FillSchema(GlobalData.DS1, SchemaType.Source);
            DGVItems.DataSource = GlobalData.DS1.Tables[0];
        }
        private void cmbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select * from items where ItemName = @p1";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@p1", cmbItems.SelectedItem);
            conn.Open();
            Dr = cmd.ExecuteReader();
            if (Dr.Read())
            {
                txtPrice.Text = Dr[1].ToString();
            }
            conn.Close();
            if (int.TryParse(txtQuantity.Text, out int result))
                result = Convert.ToInt32(txtQuantity.Text);
            else if (txtQuantity.Text.Equals(string.Empty))
            { }
            else MessageBox.Show("Invalid Quantity");
            txtTotal.Text = (result * Convert.ToDouble(txtPrice.Text)).ToString();
        }
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out int result))
                result = Convert.ToInt32(txtQuantity.Text);
            else if(txtQuantity.Text.Equals(string.Empty))
            { }
            else MessageBox.Show("Invalid Quantity");
            txtTotal.Text = (result * Convert.ToDouble(txtPrice.Text)).ToString();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            double sumAmount = 0;
            for(int i = 0; i < GlobalData.DS1.Tables["Billtrans"].Rows.Count;i++)
            {
                sumAmount += Convert.ToDouble(GlobalData.DS1.Tables["Billtrans"].Rows[i]["Totalprice"]);
            }
            GlobalData.sum=sumAmount; 
            GlobalData.BDT = DateTime.Now;
            GlobalData.serviceTax = GlobalData.sum * 0.09;
            GlobalData.VAT = GlobalData.sum * 0.09;
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            r=GlobalData.DS1.Tables[0].NewRow();
            r[0] = BillMaster.Billno;
            r[1] = cmbItems.SelectedItem;
            r[2] = txtPrice.Text;
            r[3] = txtQuantity.Text;
            r[4] = txtTotal.Text;
            GlobalData.DS1.Tables[0].Rows.Add(r);
            GlobalData.DS1.AcceptChanges();
        }
    }
}
