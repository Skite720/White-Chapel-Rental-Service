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
    public partial class createuser : Form
    {
        private string userfile = @"..\..\Data\user.csv";

        private List<user> userslist = new List<user>();


        public createuser()
        {
            InitializeComponent();
        }

        public void loadfile()
        {
            if(File.Exists(userfile))
            {
                var lines = File.ReadAllLines(userfile).Skip(1);

                foreach(string line in lines)
                {
                    if(line != null)
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

        public void savefile()
        {
            StreamWriter sw = new StreamWriter(userfile);

            sw.WriteLine("FirstName" + "," + "LastName" + "," + "Address" + "," + "UserName" + "," + "Password" + "," + "MobileNo" + "," + "EmailAddress");
            
            foreach(user usr in userslist)
            {
                sw.WriteLine(usr.ToCSVString());
            }
            sw.Close();
        }

        private bool validateFName()
        {
            bool status = true;
            if(fnametxt.Text == "")
            {
                errorProvider1.SetError(fnametxt, "First Name cannot be blank");
                status = false;
            }
            else
            {
                errorProvider1.SetError(fnametxt, "");
                status = true;
            }

            return status;
        }

        private void fnametxt_Validating(object sender, CancelEventArgs e)
        {
            validateFName();
        }

        private bool validateLName()
        {
            bool status = true;
            if (lnametxt.Text == "")
            {
                errorProvider1.SetError(lnametxt, "Last Name cannot be blank");
                status = false;
            }
            else
            {
                errorProvider1.SetError(lnametxt, "");
                status = true;
            }

            return status;
        }

        private void lnametxt_Validating(object sender, CancelEventArgs e)
        {
            validateLName();
        }

        private bool validateAddress()
        {
            bool status = true;
            if (addrstxt.Text == "")
            {
                errorProvider1.SetError(addrstxt, "Address cannot be blank");
                status = false;
            }
            else
            {
                errorProvider1.SetError(addrstxt, "");
                status = true;
            }

            return status;
        }

        private void addrstxt_Validating(object sender, CancelEventArgs e)
        {
            validateAddress();
        }

        private bool validateMobileNo()
        {
            bool status = true;
            if (mobiletxt.Text == "")
            {
                errorProvider1.SetError(mobiletxt, "Mobile No. cannot be blank");
                status = false;
            }
            else
            {
                errorProvider1.SetError(mobiletxt, "");
                status = true;
            }

            return status;
        }

        private void mobiletxt_Validating(object sender, CancelEventArgs e)
        {
            validateMobileNo();
        }

        private bool validateEmail()
        {
            bool status = true;
            if (emailtxt.Text == "")
            {
                errorProvider1.SetError(emailtxt, "Mobile No. cannot be blank");
                status = false;
            }
            else
            {
                errorProvider1.SetError(emailtxt, "");
                status = true;
            }

            return status;
        }

        private void emailtxt_Validating(object sender, CancelEventArgs e)
        {
            validateEmail();
        }

        private bool validateUserName()
        {
            bool status = true;
            if (usernametxt.Text == "")
            {
                errorProvider1.SetError(usernametxt, "User Name cannot be blank");
                status = false;
            }
            else
            {
                errorProvider1.SetError(usernametxt, "");
                status = true;
            }

            return status;
        }

        private void usernametxt_Validating(object sender, CancelEventArgs e)
        {
            validateUserName();
        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {
            bool found = false;
            foreach(user usr in userslist)
            {
                if(usr.UserName.Equals(usernametxt.Text))
                {
                    found = true;
                    break;
                }
            }

            if(found == true)
            {
                MessageBox.Show("User Name exists !!! Enter again....");
                usernametxt.SelectAll();
                usernametxt.Focus();
            }
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

        private void createuser_Load(object sender, EventArgs e)
        {
            loadfile();
            //fnametxt.Focus();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            bool validfname = validateFName();
            bool validlname = validateLName();
            bool validaddrs = validateAddress();
            bool validmobno = validateMobileNo();
            bool validemail = validateEmail();
            bool validusrnam = validateUserName();
            bool validpasswd = validatePassword();

            if(validfname && validlname && validaddrs && validmobno && validemail && validusrnam && validpasswd)
            {
                string fstname = fnametxt.Text;
                string lstname = lnametxt.Text;
                string addrs = addrstxt.Text;
                addrs = addrs.Replace(",", "");
                string usrname = usernametxt.Text;
                string passwd = passwdtxt.Text;
                string mobno = mobiletxt.Text;
                string email = emailtxt.Text;

                user obj = new user(fstname, lstname, addrs, usrname, passwd, mobno, email);
                userslist.Add(obj);

                savefile();

                MessageBox.Show("User Account Created Successfully !!!");
            }
            else
            {
                MessageBox.Show("Please enter valid data !!!");
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            fnametxt.Text = "";
            lnametxt.Text = "";
            addrstxt.Text = "";
            mobiletxt.Text = "";
            emailtxt.Text = "";
            usernametxt.Text = "";
            passwdtxt.Text = "";
            fnametxt.Focus();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();

        }
    }
}
