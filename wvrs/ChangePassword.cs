using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wvrs
{
    public partial class ChangePassword : Form
    {
        //private user usrobj;
        private int index;

        public ChangePassword()
        {
            InitializeComponent();
        }

        public void fillusrname()
        {
            usrnamcmb.Items.Clear();

            if (menumdi.Userlist.Count > 0)
            {
                foreach (user usr in menumdi.Userlist)
                {
                    usrnamcmb.Items.Add(usr.UserName);
                }
            }
            else
            {
                MessageBox.Show("No User Account Exists !!! Add New User Account First...");
            }
        }



        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            fillusrname();
            usrnamcmb.Focus();

        }

        private void usrnamcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string usr = usrnamcmb.Text;

            foreach (user u in menumdi.Userlist)
            {
                if (u.UserName.Equals(usr))
                {
                    //usrobj = u;
                    index = menumdi.Userlist.IndexOf(u);
                    fnametxt.Text = u.FirstName;
                    lnametxt.Text = u.LastName;
                    addrstxt.Text = u.Address;
                    mobiletxt.Text = u.Mobileno;
                    emailtxt.Text = u.EmailAddress;
                    passwdtxt.Text = u.Password;
                    break;
                }

            }
        }

        private void updbtn_Click(object sender, EventArgs e)
        {
            menumdi.Userlist[index].Password = passwdtxt.Text;
            menumdi.saveuserfile();

            usrnamcmb.Text = "";
            fnametxt.Text = "";
            lnametxt.Text = "";
            addrstxt.Text = "";
            mobiletxt.Text = "";
            emailtxt.Text = "";
            passwdtxt.Text = "";

            usrnamcmb.Focus();

            MessageBox.Show("Password Changed Successfully !!!");


        }
    }
}
