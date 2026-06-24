namespace wvrs
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passwdtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usrnametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.createbtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.passwdtxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.usrnametxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 118);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // passwdtxt
            // 
            this.passwdtxt.Location = new System.Drawing.Point(78, 73);
            this.passwdtxt.Name = "passwdtxt";
            this.passwdtxt.PasswordChar = '*';
            this.passwdtxt.Size = new System.Drawing.Size(278, 20);
            this.passwdtxt.TabIndex = 3;
            this.passwdtxt.Validating += new System.ComponentModel.CancelEventHandler(this.passwdtxt_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password  :";
            // 
            // usrnametxt
            // 
            this.usrnametxt.Location = new System.Drawing.Point(76, 28);
            this.usrnametxt.Name = "usrnametxt";
            this.usrnametxt.Size = new System.Drawing.Size(278, 20);
            this.usrnametxt.TabIndex = 1;
            this.usrnametxt.Validating += new System.ComponentModel.CancelEventHandler(this.usrnametxt_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Name :";
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(71, 229);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(92, 40);
            this.loginbtn.TabIndex = 2;
            this.loginbtn.Text = "LOGIN";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(235, 229);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(92, 40);
            this.cancelbtn.TabIndex = 3;
            this.cancelbtn.Text = "CANCEL";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(383, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Don\'t have account yet . Create a new account";
            // 
            // createbtn
            // 
            this.createbtn.Location = new System.Drawing.Point(76, 302);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(250, 32);
            this.createbtn.TabIndex = 5;
            this.createbtn.Text = "CREATE NEW ACCOUNT";
            this.createbtn.UseVisualStyleBackColor = true;
            this.createbtn.Click += new System.EventHandler(this.createbtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::wvrs.Properties.Resources.wvrslogo;
            this.pictureBox2.Location = new System.Drawing.Point(283, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.loginbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(398, 349);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.createbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Whitechapel Vehicle Rental Service - LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passwdtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usrnametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

