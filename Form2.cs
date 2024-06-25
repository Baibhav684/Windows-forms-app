using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WAMicroProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void addItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            form3.MdiParent = this;
        }
        private void editItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            form4.MdiParent = this;
        }
        private void deleteItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            form5.MdiParent = this;
        }
        private void createNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6 .Show();
            form6 .MdiParent = this;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            form7.MdiParent = this;
        }

        private void changePassWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();  
            form8.Show();
            form8.MdiParent = this;
        }

        private void viewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            form9.MdiParent = this;
        }

        private void newBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BillMaster bill = new BillMaster();
            bill.ShowDialog();
            bill.MdiParent = this;
        }

        private void viewBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.ShowDialog();
            form12.MdiParent = this;
        }
    }
}
