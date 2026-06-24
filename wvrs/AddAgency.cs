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
    public partial class AddAgency : Form
    {
        public AddAgency()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void compidtxt_Validating(object sender, CancelEventArgs e)
        {
            if(compidtxt.Text == "")
            {
                errorProvider1.SetError(compidtxt, "Company ID cannot be blank");
                compidtxt.Focus();
            }
            else
            {
                errorProvider1.SetError(compidtxt, "");
            }
        }

        private void compnamtxt_Validating(object sender, CancelEventArgs e)
        {
            if(compnamtxt.Text == "")
            {
                errorProvider1.SetError(compnamtxt, "Company Name cannot be blank");
                compnamtxt.Focus();
            }
            else
            {
                errorProvider1.SetError(compnamtxt, "");
            }
        }

        private void addrstxt_Validating(object sender, CancelEventArgs e)
        {
            if(addrstxt.Text == "")
            {
                errorProvider1.SetError(addrstxt, "Address cannot be blank");
                addrstxt.Focus();
            }
            else
            {
                errorProvider1.SetError(addrstxt, "");
            }
        }

        private void contnamtxt_Validating(object sender, CancelEventArgs e)
        {
            if(contnamtxt.Text == "")
            {
                errorProvider1.SetError(contnamtxt, "Contact Name cannot be blank");
                contnamtxt.Focus();
            }
            else
            {
                errorProvider1.SetError(contnamtxt, "");
            }
        }

        private void contaddrstxt_Validating(object sender, CancelEventArgs e)
        {
            if(contaddrstxt.Text == "")
            {
                errorProvider1.SetError(contaddrstxt, "Contact Address cannot be blank");
                contaddrstxt.Focus();
            }
            else
            {
                errorProvider1.SetError(contaddrstxt, "");
            }
        }

        private void contmobnotxt_Validating(object sender, CancelEventArgs e)
        {
            if(contmobnotxt.Text == "")
            {
                errorProvider1.SetError(contmobnotxt, "Contact Mobile No. cannot be blank");
                contmobnotxt.Focus();
            }
            else
            {
                errorProvider1.SetError(contmobnotxt, "");
            }
        }

        private void contemailtxt_Validating(object sender, CancelEventArgs e)
        {
            if(contemailtxt.Text == "")
            {
                errorProvider1.SetError(contemailtxt, "Contact Email Address cannot be blank");
                contemailtxt.Focus();
            }
            else
            {
                errorProvider1.SetError(contemailtxt, "");
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            string compid = compidtxt.Text;
            string compnam = compnamtxt.Text;
            string compadd = addrstxt.Text;
            compadd = compadd.Replace(",", "");
            string contnam = contnamtxt.Text;
            string contadd = contaddrstxt.Text;
            contadd = contadd.Replace(",", "");
            string contmob = contmobnotxt.Text;
            string conteml = contemailtxt.Text;

            AgencyCompany obj = new AgencyCompany(compid, compnam, compadd, contnam, contadd, contmob, conteml);

            menumdi.Companylist.Add(obj);
            menumdi.savecompfile();

            MessageBox.Show("Agency/Company Record Saved Successfully !!!");
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            compidtxt.Text = "";
            compnamtxt.Text = "";
            addrstxt.Text = "";
            contnamtxt.Text = "";
            contaddrstxt.Text = "";
            contmobnotxt.Text = "";
            contemailtxt.Text = "";
        }

        private void compidtxt_TextChanged(object sender, EventArgs e)
        {
            string comid = compidtxt.Text;
            bool flag = false;

            foreach (AgencyCompany co in menumdi.Companylist)
            {
                if (co.CompanyID.Equals(comid))
                {
                    flag = true;
                    break;
                }
            }

            if (flag == true)
            {
                errorProvider1.SetError(compidtxt, "Company ID already exist !! Enter again !!!! ");
                compidtxt.Focus();
            }
            else
            {
                errorProvider1.SetError(compidtxt, "");
            }
        }

       
    }
}
