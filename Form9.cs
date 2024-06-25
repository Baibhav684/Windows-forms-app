﻿using System;
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
    public partial class Form9 : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmd;
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            string Constr = @"server=(LocalDB)\MSSQLLocalDB;user Id=sa;password=123;database = microproject";
            conn = new SqlConnection(Constr);
            string Query = "select * from users";
            ds = new DataSet();
            da = new SqlDataAdapter(Query, conn);
            da.Fill(ds, "users");
            da.FillSchema(ds, SchemaType.Source, "users");
            cmd = new SqlCommandBuilder(da);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
