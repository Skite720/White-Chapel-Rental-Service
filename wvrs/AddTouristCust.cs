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
    public partial class AddTouristCust : Form
    {
        public AddTouristCust()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void custidtxt_Validating(object sender, CancelEventArgs e)
        {
            if(custidtxt.Text == "")
            {
                errorProvider1.SetError(custidtxt, "Customer ID cannot be blank");
                custidtxt.Focus();
            }
            else
            {
                errorProvider1.SetError(custidtxt, "");
            }
        }

        private void custidtxt_TextChanged(object sender, EventArgs e)
        {
            string custid = custidtxt.Text;
            bool flag = false;
            
            foreach(TouristCust cust in menumdi.Customerlist)
            {
                if(cust.CustID.Equals(custid))
                {
                    flag = true;
                    break;
                }
            }

            if(flag == true)
            {
                errorProvider1.SetError(custidtxt, "Customer ID already exist !! Enter again !!!! ");
                custidtxt.Focus();
            }
            else
            {
                errorProvider1.SetError(custidtxt, "");
            }
        }

        private void fullnamtxt_Validating(object sender, CancelEventArgs e)
        {
            if(fullnamtxt.Text == "")
            {
                errorProvider1.SetError(fullnamtxt, "Full Name cannot be blank");
                fullnamtxt.Focus();
            }
            else
            {
                errorProvider1.SetError(fullnamtxt, "");
            }
        }

        private void drvlictxt_Validating(object sender, CancelEventArgs e)
        {
            if(drvlictxt.Text == "")
            {
                errorProvider1.SetError(drvlictxt, "Driving Licence cannot be blank");
                drvlictxt.Focus();
            }
            else
            {
                errorProvider1.SetError(drvlictxt, "");
            }
        }

        private void dobdtpkr_Validating(object sender, CancelEventArgs e)
        {
            DateTime dt = DateTime.Now;
            string date = dt.ToShortDateString();

            if(dobdtpkr.Text.CompareTo(date) > 0)
            {
                errorProvider1.SetError(dobdtpkr, "Date of birth should be less than current date");
                dobdtpkr.Focus();
            }
            else
            {
                errorProvider1.SetError(dobdtpkr, "");
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

        private void mobnotxt_Validating(object sender, CancelEventArgs e)
        {
            if(mobnotxt.Text == "")
            {
                errorProvider1.SetError(mobnotxt, "Mobile No. cannot be blank");
                mobnotxt.Focus();
            }
            else
            {
                errorProvider1.SetError(mobnotxt, "");
            }
        }

        private void emailtxt_Validating(object sender, CancelEventArgs e)
        {
            if(emailtxt.Text == "")
            {
                errorProvider1.SetError(emailtxt, "Email address cannot be blank");
                emailtxt.Focus();
            }
            else
            {
                errorProvider1.SetError(emailtxt, "");

            }
        }

        private void emeaddrstxt_Validating(object sender, CancelEventArgs e)
        {
            if(emeaddrstxt.Text == "")
            {
                errorProvider1.SetError(emeaddrstxt, "Emergency Address cannot be blank");
                emeaddrstxt.Focus();
            }
            else
            {
                errorProvider1.SetError(emeaddrstxt, "");
            }
        }

        private void ememobnotxt_Validating(object sender, CancelEventArgs e)
        {
            if(ememobnotxt.Text == "")
            {
                errorProvider1.SetError(ememobnotxt, "Emergency Mobile No. cannot be blank");
                ememobnotxt.Focus();
            }
            else
            {
                errorProvider1.SetError(ememobnotxt, "");
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            string custid = custidtxt.Text;
            string fullnam = fullnamtxt.Text;
            string drvlic = drvlictxt.Text;
            string dob = dobdtpkr.Text;
            string adrs = addrstxt.Text;
            adrs = adrs.Replace(",", "");
            string mobno = mobnotxt.Text;
            string email = emailtxt.Text;
            string emeadrs = emeaddrstxt.Text;
            emeadrs = emeadrs.Replace(",", "");
            string ememob = ememobnotxt.Text;

            TouristCust obj = new TouristCust(custid, fullnam, drvlic, dob, adrs, mobno, email, emeadrs, ememob);

            menumdi.Customerlist.Add(obj);
            menumdi.savecustfile();

            MessageBox.Show("Tourist/Customer Record Save Successfully !!!");

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            custidtxt.Text = "";
            fullnamtxt.Text = "";
            drvlictxt.Text = "";
            dobdtpkr.Text = "";
            addrstxt.Text = "";
            mobnotxt.Text = "";
            emailtxt.Text = "";
            emeaddrstxt.Text = "";
            ememobnotxt.Text = "";
        }

    }
}
