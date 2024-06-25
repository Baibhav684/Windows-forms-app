namespace WAMicroProject
{
    partial class Form8
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblHques = new System.Windows.Forms.Label();
            this.radioButtonoldPassword = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lbltype = new System.Windows.Forms.Label();
            this.lblHans = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblRetype = new System.Windows.Forms.Label();
            this.txtHans = new System.Windows.Forms.TextBox();
            this.txtNpass = new System.Windows.Forms.TextBox();
            this.txtRetype = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "what is your nickname",
            "what is your pet\'s name",
            "what is your homtown ",
            "what is your first job"});
            this.comboBox1.Location = new System.Drawing.Point(275, 159);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 37);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Visible = false;
            // 
            // lblHques
            // 
            this.lblHques.AutoSize = true;
            this.lblHques.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHques.Location = new System.Drawing.Point(12, 162);
            this.lblHques.Name = "lblHques";
            this.lblHques.Size = new System.Drawing.Size(252, 29);
            this.lblHques.TabIndex = 1;
            this.lblHques.Text = "Select Hint Question";
            this.lblHques.Visible = false;
            // 
            // radioButtonoldPassword
            // 
            this.radioButtonoldPassword.AutoSize = true;
            this.radioButtonoldPassword.Checked = true;
            this.radioButtonoldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonoldPassword.Location = new System.Drawing.Point(70, 107);
            this.radioButtonoldPassword.Name = "radioButtonoldPassword";
            this.radioButtonoldPassword.Size = new System.Drawing.Size(261, 33);
            this.radioButtonoldPassword.TabIndex = 2;
            this.radioButtonoldPassword.TabStop = true;
            this.radioButtonoldPassword.Text = "using old password";
            this.radioButtonoldPassword.UseVisualStyleBackColor = true;
            this.radioButtonoldPassword.CheckedChanged += new System.EventHandler(this.radioButtonoldPassword_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(337, 107);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(258, 33);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "using hint Question";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltype.Location = new System.Drawing.Point(244, 51);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(143, 29);
            this.lbltype.TabIndex = 4;
            this.lbltype.Text = "Select type";
            // 
            // lblHans
            // 
            this.lblHans.AutoSize = true;
            this.lblHans.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHans.Location = new System.Drawing.Point(12, 209);
            this.lblHans.Name = "lblHans";
            this.lblHans.Size = new System.Drawing.Size(239, 29);
            this.lblHans.TabIndex = 5;
            this.lblHans.Text = "Enter old password";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(12, 261);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(257, 29);
            this.lblpassword.TabIndex = 6;
            this.lblpassword.Text = "Enter New Password";
            // 
            // lblRetype
            // 
            this.lblRetype.AutoSize = true;
            this.lblRetype.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetype.Location = new System.Drawing.Point(18, 314);
            this.lblRetype.Name = "lblRetype";
            this.lblRetype.Size = new System.Drawing.Size(215, 29);
            this.lblRetype.TabIndex = 7;
            this.lblRetype.Text = "Retype password";
            // 
            // txtHans
            // 
            this.txtHans.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHans.Location = new System.Drawing.Point(270, 202);
            this.txtHans.Name = "txtHans";
            this.txtHans.Size = new System.Drawing.Size(207, 34);
            this.txtHans.TabIndex = 8;
            // 
            // txtNpass
            // 
            this.txtNpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNpass.Location = new System.Drawing.Point(275, 256);
            this.txtNpass.Name = "txtNpass";
            this.txtNpass.Size = new System.Drawing.Size(207, 34);
            this.txtNpass.TabIndex = 10;
            // 
            // txtRetype
            // 
            this.txtRetype.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetype.Location = new System.Drawing.Point(275, 309);
            this.txtRetype.Name = "txtRetype";
            this.txtRetype.Size = new System.Drawing.Size(207, 34);
            this.txtRetype.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(117, 373);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(130, 40);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(275, 373);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(130, 40);
            this.btnclose.TabIndex = 13;
            this.btnclose.Text = "close";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtRetype);
            this.Controls.Add(this.txtNpass);
            this.Controls.Add(this.txtHans);
            this.Controls.Add(this.lblRetype);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblHans);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButtonoldPassword);
            this.Controls.Add(this.lblHques);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblHques;
        private System.Windows.Forms.RadioButton radioButtonoldPassword;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label lblHans;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblRetype;
        private System.Windows.Forms.TextBox txtHans;
        private System.Windows.Forms.TextBox txtNpass;
        private System.Windows.Forms.TextBox txtRetype;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnclose;
    }
}