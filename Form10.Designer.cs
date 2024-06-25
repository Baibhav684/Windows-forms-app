namespace WAMicroProject
{
    partial class BillMaster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBillno = new System.Windows.Forms.Label();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.LblBilAmt = new System.Windows.Forms.Label();
            this.lblserviceTax = new System.Windows.Forms.Label();
            this.LblVAT = new System.Windows.Forms.Label();
            this.LblDiscount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtBillNO = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.txtST = new System.Windows.Forms.TextBox();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtTOtal = new System.Windows.Forms.TextBox();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBillno
            // 
            this.lblBillno.AutoSize = true;
            this.lblBillno.Location = new System.Drawing.Point(22, 44);
            this.lblBillno.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBillno.Name = "lblBillno";
            this.lblBillno.Size = new System.Drawing.Size(215, 29);
            this.lblBillno.TabIndex = 0;
            this.lblBillno.Text = "Enter Bill number";
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.Location = new System.Drawing.Point(119, 109);
            this.lblBillDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(112, 29);
            this.lblBillDate.TabIndex = 1;
            this.lblBillDate.Text = "Bill Date";
            // 
            // LblBilAmt
            // 
            this.LblBilAmt.AutoSize = true;
            this.LblBilAmt.Location = new System.Drawing.Point(86, 171);
            this.LblBilAmt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblBilAmt.Name = "LblBilAmt";
            this.LblBilAmt.Size = new System.Drawing.Size(145, 29);
            this.LblBilAmt.TabIndex = 2;
            this.LblBilAmt.Text = "Bill Amount";
            // 
            // lblserviceTax
            // 
            this.lblserviceTax.AutoSize = true;
            this.lblserviceTax.Location = new System.Drawing.Point(80, 223);
            this.lblserviceTax.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblserviceTax.Name = "lblserviceTax";
            this.lblserviceTax.Size = new System.Drawing.Size(151, 29);
            this.lblserviceTax.TabIndex = 3;
            this.lblserviceTax.Text = "Service Tax";
            // 
            // LblVAT
            // 
            this.LblVAT.AutoSize = true;
            this.LblVAT.Location = new System.Drawing.Point(140, 280);
            this.LblVAT.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblVAT.Name = "LblVAT";
            this.LblVAT.Size = new System.Drawing.Size(62, 29);
            this.LblVAT.TabIndex = 4;
            this.LblVAT.Text = "VAT";
            // 
            // LblDiscount
            // 
            this.LblDiscount.AutoSize = true;
            this.LblDiscount.Location = new System.Drawing.Point(54, 336);
            this.LblDiscount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblDiscount.Name = "LblDiscount";
            this.LblDiscount.Size = new System.Drawing.Size(183, 29);
            this.LblDiscount.TabIndex = 5;
            this.LblDiscount.Text = "Enter Discount";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(113, 401);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(118, 29);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total Bill";
            // 
            // txtBillNO
            // 
            this.txtBillNO.Location = new System.Drawing.Point(246, 41);
            this.txtBillNO.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtBillNO.Name = "txtBillNO";
            this.txtBillNO.Size = new System.Drawing.Size(261, 34);
            this.txtBillNO.TabIndex = 7;
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(246, 104);
            this.txtDate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(261, 34);
            this.txtDate.TabIndex = 8;
            // 
            // txtAmt
            // 
            this.txtAmt.Enabled = false;
            this.txtAmt.Location = new System.Drawing.Point(246, 166);
            this.txtAmt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(261, 34);
            this.txtAmt.TabIndex = 9;
            // 
            // txtST
            // 
            this.txtST.Enabled = false;
            this.txtST.Location = new System.Drawing.Point(246, 220);
            this.txtST.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtST.Name = "txtST";
            this.txtST.Size = new System.Drawing.Size(261, 34);
            this.txtST.TabIndex = 10;
            // 
            // txtVAT
            // 
            this.txtVAT.Enabled = false;
            this.txtVAT.Location = new System.Drawing.Point(246, 275);
            this.txtVAT.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(261, 34);
            this.txtVAT.TabIndex = 11;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(246, 333);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(261, 34);
            this.txtDiscount.TabIndex = 12;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // txtTOtal
            // 
            this.txtTOtal.Location = new System.Drawing.Point(246, 398);
            this.txtTOtal.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTOtal.Name = "txtTOtal";
            this.txtTOtal.Size = new System.Drawing.Size(261, 34);
            this.txtTOtal.TabIndex = 13;
            // 
            // btnAddBill
            // 
            this.btnAddBill.Location = new System.Drawing.Point(516, 37);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(169, 43);
            this.btnAddBill.TabIndex = 14;
            this.btnAddBill.Text = "Add Bill";
            this.btnAddBill.UseVisualStyleBackColor = true;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(402, 460);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 48);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(232, 460);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(146, 48);
            this.btnclear.TabIndex = 16;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(59, 460);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 48);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BillMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 534);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddBill);
            this.Controls.Add(this.txtTOtal);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.txtST);
            this.Controls.Add(this.txtAmt);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtBillNO);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.LblDiscount);
            this.Controls.Add(this.LblVAT);
            this.Controls.Add(this.lblserviceTax);
            this.Controls.Add(this.LblBilAmt);
            this.Controls.Add(this.lblBillDate);
            this.Controls.Add(this.lblBillno);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "BillMaster";
            this.Text = "Bill Master";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBillno;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.Label LblBilAmt;
        private System.Windows.Forms.Label lblserviceTax;
        private System.Windows.Forms.Label LblVAT;
        private System.Windows.Forms.Label LblDiscount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtBillNO;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtAmt;
        private System.Windows.Forms.TextBox txtST;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtTOtal;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnSave;
    }
}