using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace wvrs
{
    public partial class Form1 : Form
    {
        private string userfile = @"..\..\Data\user.csv";

        private List<user> userslist = new List<user>();

        int count = 3;
        public void loadfile()
        {
            if (File.Exists(userfile))
            {
                var lines = File.ReadAllLines(userfile).Skip(1);

                foreach (string line in lines)
                {
                    if (line != null)
                    {
                        string[] cols = line.Split(',');

                        string fname = cols[0];
                        string lname = cols[1];
                        string addrs = cols[2];
                        string usrname = cols[3];
                        string passwd = cols[4];
                        string mobile = cols[5];
                        string email = cols[6];

                        user obj = new user(fname, lname, addrs, usrname, passwd, mobile, email);
                        userslist.Add(obj);
                    }
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            createuser frm = new createuser();
            this.Hide();
            frm.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadfile();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string usrname = usrnametxt.Text;
            string passwd = passwdtxt.Text;

            bool found = false;

            foreach(user usr in userslist)
            {
                if(usr.UserName.Equals(usrname) && usr.Password.Equals(passwd))
                {
                    found = true;
                    break;
                }
            }

            if (found == false)
            {
                if (count <= 1)
                {
                    Application.Exit();
                }
                else
                {
                    count--;
                    MessageBox.Show("Access Denied !!! You have " + count + " more tries.  \n Try Again !!!");
                    usrnametxt.SelectAll();
                    usrnametxt.Focus();
                }
            }
            else
            {
                menumdi frm = new menumdi();
                this.Hide();
                frm.Show();
            }
        }

        private bool validateUserName()
        {
            bool status = true;
            if (usrnametxt.Text == "")
            {
                errorProvider1.SetError(usrnametxt, "User Name cannot be blank");
                status = false;
            }
            else
            {
                errorProvider1.SetError(usrnametxt, "");
                status = true;
            }

            return status;
        }

        private void usrnametxt_Validating(object sender, CancelEventArgs e)
        {
            validateUserName();
        }

        private bool validatePassword()
        {
            bool status = true;
            if (passwdtxt.Text == "")
            {
                errorProvider1.SetError(passwdtxt, "Password cannot be blank");
                status = false;
            }
            else
            {
                errorProvider1.SetError(passwdtxt, "");
                status = true;
            }

            return status;
        }

        private void passwdtxt_Validating(object sender, CancelEventArgs e)
        {
            validatePassword();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
