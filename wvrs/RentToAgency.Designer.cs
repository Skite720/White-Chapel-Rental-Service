namespace wvrs
{
    partial class RentToAgency
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentToAgency));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.clearbtn = new System.Windows.Forms.Button();
            this.rentbtn = new System.Windows.Forms.Button();
            this.daysnum = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.vehratetxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.vehtyptxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.contnamtxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.compnamtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.vehregnocmb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.compidcmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trandtpkr = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.trannotxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.closebtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysnum)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(391, 318);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(98, 58);
            this.clearbtn.TabIndex = 8;
            this.clearbtn.Text = "CLEAR";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // rentbtn
            // 
            this.rentbtn.Location = new System.Drawing.Point(236, 318);
            this.rentbtn.Name = "rentbtn";
            this.rentbtn.Size = new System.Drawing.Size(98, 58);
            this.rentbtn.TabIndex = 7;
            this.rentbtn.Text = "RENT";
            this.rentbtn.UseVisualStyleBackColor = true;
            this.rentbtn.Click += new System.EventHandler(this.rentbtn_Click);
            // 
            // daysnum
            // 
            this.daysnum.Location = new System.Drawing.Point(465, 212);
            this.daysnum.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.daysnum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.daysnum.Name = "daysnum";
            this.daysnum.Size = new System.Drawing.Size(58, 20);
            this.daysnum.TabIndex = 17;
            this.daysnum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(333, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Days Rented";
            // 
            // vehratetxt
            // 
            this.vehratetxt.Enabled = false;
            this.vehratetxt.Location = new System.Drawing.Point(594, 168);
            this.vehratetxt.Name = "vehratetxt";
            this.vehratetxt.Size = new System.Drawing.Size(179, 20);
            this.vehratetxt.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(452, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Vehicle Rate";
            // 
            // vehtyptxt
            // 
            this.vehtyptxt.Enabled = false;
            this.vehtyptxt.Location = new System.Drawing.Point(594, 121);
            this.vehtyptxt.Name = "vehtyptxt";
            this.vehtyptxt.Size = new System.Drawing.Size(179, 20);
            this.vehtyptxt.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Vehicle Type";
            // 
            // contnamtxt
            // 
            this.contnamtxt.Enabled = false;
            this.contnamtxt.Location = new System.Drawing.Point(220, 171);
            this.contnamtxt.Name = "contnamtxt";
            this.contnamtxt.Size = new System.Drawing.Size(179, 20);
            this.contnamtxt.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Contact Name";
            // 
            // compnamtxt
            // 
            this.compnamtxt.Enabled = false;
            this.compnamtxt.Location = new System.Drawing.Point(220, 121);
            this.compnamtxt.Name = "compnamtxt";
            this.compnamtxt.Size = new System.Drawing.Size(179, 20);
            this.compnamtxt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Company Name";
            // 
            // vehregnocmb
            // 
            this.vehregnocmb.FormattingEnabled = true;
            this.vehregnocmb.Location = new System.Drawing.Point(594, 70);
            this.vehregnocmb.Name = "vehregnocmb";
            this.vehregnocmb.Size = new System.Drawing.Size(179, 21);
            this.vehregnocmb.TabIndex = 7;
            this.vehregnocmb.SelectedIndexChanged += new System.EventHandler(this.vehregnocmb_SelectedIndexChanged);
            this.vehregnocmb.Validating += new System.ComponentModel.CancelEventHandler(this.vehregnocmb_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Vehicle Registration No.";
            // 
            // compidcmb
            // 
            this.compidcmb.FormattingEnabled = true;
            this.compidcmb.Location = new System.Drawing.Point(220, 70);
            this.compidcmb.Name = "compidcmb";
            this.compidcmb.Size = new System.Drawing.Size(179, 21);
            this.compidcmb.TabIndex = 5;
            this.compidcmb.SelectedIndexChanged += new System.EventHandler(this.compidcmb_SelectedIndexChanged);
            this.compidcmb.Validating += new System.ComponentModel.CancelEventHandler(this.compidcmb_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Company ID";
            // 
            // trandtpkr
            // 
            this.trandtpkr.CustomFormat = "dd/MM/yyyy";
            this.trandtpkr.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.trandtpkr.Location = new System.Drawing.Point(594, 23);
            this.trandtpkr.Name = "trandtpkr";
            this.trandtpkr.Size = new System.Drawing.Size(179, 20);
            this.trandtpkr.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Transaction Date";
            // 
            // trannotxt
            // 
            this.trannotxt.Location = new System.Drawing.Point(220, 23);
            this.trannotxt.Name = "trannotxt";
            this.trannotxt.Size = new System.Drawing.Size(179, 20);
            this.trannotxt.TabIndex = 1;
            this.trannotxt.Validating += new System.ComponentModel.CancelEventHandler(this.trannotxt_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Transaction No.";
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(546, 318);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(98, 58);
            this.closebtn.TabIndex = 9;
            this.closebtn.Text = "CLOSE";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.daysnum);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.vehratetxt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.vehtyptxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.contnamtxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.compnamtxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.vehregnocmb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.compidcmb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.trandtpkr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.trannotxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 251);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(645, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "RESERVE VEHICLE TO TRAVEL AGENCY/COMPANY";
            // 
            // RentToAgency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(881, 387);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.rentbtn);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RentToAgency";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Whitechapel Vehicle Rental Service - RENT TO AGENCY/COMPANY";
            this.Load += new System.EventHandler(this.RentToAgency_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysnum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button rentbtn;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown daysnum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox vehratetxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox vehtyptxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox contnamtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox compnamtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox vehregnocmb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox compidcmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker trandtpkr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox trannotxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}