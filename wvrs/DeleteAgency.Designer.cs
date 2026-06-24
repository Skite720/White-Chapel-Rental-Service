namespace wvrs
{
    partial class DeleteAgency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteAgency));
            this.closebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contmobnotxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.contemailtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.contaddrstxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.contnamtxt = new System.Windows.Forms.TextBox();
            this.delbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.compidcmb = new System.Windows.Forms.ComboBox();
            this.addrstxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.compnamtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(483, 342);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(93, 52);
            this.closebtn.TabIndex = 17;
            this.closebtn.Text = "CLOSE";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "DELETE TRAVEL AGENCY/COMPANY ";
            // 
            // contmobnotxt
            // 
            this.contmobnotxt.Enabled = false;
            this.contmobnotxt.Location = new System.Drawing.Point(133, 187);
            this.contmobnotxt.Name = "contmobnotxt";
            this.contmobnotxt.Size = new System.Drawing.Size(260, 20);
            this.contmobnotxt.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Contact Mobile No.";
            // 
            // contemailtxt
            // 
            this.contemailtxt.Enabled = false;
            this.contemailtxt.Location = new System.Drawing.Point(556, 187);
            this.contemailtxt.Name = "contemailtxt";
            this.contemailtxt.Size = new System.Drawing.Size(281, 20);
            this.contemailtxt.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(424, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Contact Email Address";
            // 
            // contaddrstxt
            // 
            this.contaddrstxt.Enabled = false;
            this.contaddrstxt.Location = new System.Drawing.Point(533, 131);
            this.contaddrstxt.Name = "contaddrstxt";
            this.contaddrstxt.Size = new System.Drawing.Size(304, 20);
            this.contaddrstxt.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(424, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Contact Address";
            // 
            // contnamtxt
            // 
            this.contnamtxt.Enabled = false;
            this.contnamtxt.Location = new System.Drawing.Point(133, 131);
            this.contnamtxt.Name = "contnamtxt";
            this.contnamtxt.Size = new System.Drawing.Size(260, 20);
            this.contnamtxt.TabIndex = 4;
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(305, 342);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(93, 52);
            this.delbtn.TabIndex = 15;
            this.delbtn.Text = "DELETE";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Contact Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.compidcmb);
            this.groupBox1.Controls.Add(this.contmobnotxt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.contemailtxt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.contaddrstxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.contnamtxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.addrstxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.compnamtxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 240);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // compidcmb
            // 
            this.compidcmb.FormattingEnabled = true;
            this.compidcmb.Location = new System.Drawing.Point(133, 29);
            this.compidcmb.Name = "compidcmb";
            this.compidcmb.Size = new System.Drawing.Size(133, 21);
            this.compidcmb.TabIndex = 17;
            this.compidcmb.SelectedIndexChanged += new System.EventHandler(this.compidcmb_SelectedIndexChanged);
            this.compidcmb.Validating += new System.ComponentModel.CancelEventHandler(this.compidcmb_Validating);
            // 
            // addrstxt
            // 
            this.addrstxt.Enabled = false;
            this.addrstxt.Location = new System.Drawing.Point(133, 76);
            this.addrstxt.Name = "addrstxt";
            this.addrstxt.Size = new System.Drawing.Size(704, 20);
            this.addrstxt.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Address";
            // 
            // compnamtxt
            // 
            this.compnamtxt.Enabled = false;
            this.compnamtxt.Location = new System.Drawing.Point(427, 29);
            this.compnamtxt.Name = "compnamtxt";
            this.compnamtxt.Size = new System.Drawing.Size(410, 20);
            this.compnamtxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Company Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Company ID ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DeleteAgency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(881, 416);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteAgency";
            this.Text = "Whitechapel Vehicle Rental Service - DELETE AGENCY/COMPANY";
            this.Load += new System.EventHandler(this.DeleteAgency_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contmobnotxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox contemailtxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox contaddrstxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox contnamtxt;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox compidcmb;
        private System.Windows.Forms.TextBox addrstxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox compnamtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}