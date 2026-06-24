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
    public partial class DeleteAgency : Form
    {
        private int index;

        public DeleteAgency()
        {
            InitializeComponent();
        }

        public void fillCompid()
        {
            compidcmb.Items.Clear();

            if(menumdi.Companylist.Count > 0)
            {
                foreach(AgencyCompany co in menumdi.Companylist)
                {
                    compidcmb.Items.Add(co.CompanyID);
                }
            }
            else
            {
                MessageBox.Show("No Travel Agency/Company Records Exist !!! Add Agency/Company First !!!");
            }

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteAgency_Load(object sender, EventArgs e)
        {
            fillCompid();
        }

        private void compidcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compid = compidcmb.Text;

            foreach(AgencyCompany co in menumdi.Companylist)
            {
                if(co.CompanyID.Equals(compid))
                {
                    index = menumdi.Companylist.IndexOf(co);
                    compnamtxt.Text = co.CompanyName;
                    addrstxt.Text = co.CompanyAddress;
                    contnamtxt.Text = co.ContactName;
                    contaddrstxt.Text = co.ContactAddress;
                    contmobnotxt.Text = co.ContactMobileNo;
                    contemailtxt.Text = co.ContactEmail;
                    break;
                }
            }
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            menumdi.Companylist.RemoveAt(index);
            menumdi.savecompfile();
            fillCompid();
            compidcmb.Text = "";
            compnamtxt.Text = "";
            addrstxt.Text = "";
            contnamtxt.Text = "";
            contaddrstxt.Text = "";
            contmobnotxt.Text = "";
            contemailtxt.Text = "";
            compidcmb.Focus();
            MessageBox.Show("Travel Agency/Company Record Deleted Successfully !!!");
        }

        private void compidcmb_Validating(object sender, CancelEventArgs e)
        {
            if(compidcmb.Text == "" || compidcmb.SelectedIndex < 0)
            {
                errorProvider1.SetError(compidcmb, "Select Company ID");
                compidcmb.Focus();
            }
            else
            {
                errorProvider1.SetError(compidcmb, "");
            }
        }
    }
}
