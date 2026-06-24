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
    
    public partial class DeleteUser : Form
    {
        private int index;
        public DeleteUser()
        {
            InitializeComponent();
        }

        public void fillusrname()
        {
            usrnamcmb.Items.Clear();

            if(menumdi.Userlist.Count > 0)
            {
                foreach(user usr in menumdi.Userlist)
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

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            fillusrname();
            usrnamcmb.Focus();
        }

        private void usrnamcmb_Validating(object sender, CancelEventArgs e)
        {
            if(usrnamcmb.Text == "" || usrnamcmb.SelectedIndex < 0)
            {
                errorProvider1.SetError(usrnamcmb, "Select User Name");
                usrnamcmb.Focus();
            }
            else
            {
                errorProvider1.SetError(usrnamcmb, "");
            }
        }

        private void usrnamcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string usr = usrnamcmb.Text;

            foreach(user u in menumdi.Userlist)
            {
                if(u.UserName.Equals(usr))
                {
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

        private void delbtn_Click(object sender, EventArgs e)
        {
            menumdi.Userlist.RemoveAt(index);
            menumdi.saveuserfile();
            fillusrname();
            usrnamcmb.Text = "";
            fnametxt.Text = "";
            lnametxt.Text = "";
            addrstxt.Text = "";
            mobiletxt.Text = "";
            emailtxt.Text = "";
            passwdtxt.Text = "";
            usrnamcmb.Focus();
        }
    }
}
