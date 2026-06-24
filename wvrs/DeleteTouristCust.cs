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
    public partial class DeleteTouristCust : Form
    {
        private int index;
        public void fillCustid()
        {
            custidcmb.Items.Clear();

            if(menumdi.Customerlist.Count > 0)
            {
                foreach(TouristCust cust in menumdi.Customerlist)
                {
                    custidcmb.Items.Add(cust.CustID);
                }
            }
            else
            {
                MessageBox.Show("No Tourist/Customer Record Exists !! Add Customer Record First !!!");
            }
        }


        public DeleteTouristCust()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteTouristCust_Load(object sender, EventArgs e)
        {
            fillCustid();
        }

        private void custidcmb_Validating(object sender, CancelEventArgs e)
        {
            if(custidcmb.Text == "" || custidcmb.SelectedIndex < 0)
            {
                errorProvider1.SetError(custidcmb, "Select Customer ID ");
            }
            else
            {
                errorProvider1.SetError(custidcmb, "");
            }
        }

        private void custidcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string custid = custidcmb.Text;

            foreach(TouristCust cust in menumdi.Customerlist)
            {
                if(cust.CustID.Equals(custid))
                {
                    index = menumdi.Customerlist.IndexOf(cust);

                    fullnamtxt.Text = cust.FullName;
                    drvlictxt.Text = cust.DrivingLicence;
                    dobtxt.Text = cust.BirthDate;
                    addrstxt.Text = cust.Address;
                    mobnotxt.Text = cust.MobileNo;
                    emailtxt.Text = cust.Email;
                    emeaddrstxt.Text = cust.EmergencyAddress;
                    ememobnotxt.Text = cust.EmergencyMobileNo;
                    break;
                }
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            menumdi.Customerlist.RemoveAt(index);
            menumdi.savecustfile();
            fillCustid();
            custidcmb.Text = "";
            fullnamtxt.Text = "";
            drvlictxt.Text = "";
            dobtxt.Text = "";
            addrstxt.Text = "";
            mobnotxt.Text = "";
            emailtxt.Text = "";
            emeaddrstxt.Text = "";
            ememobnotxt.Text = "";

            MessageBox.Show("Tourist/Customer Record Deleted Successfully");
        }
    }
}
