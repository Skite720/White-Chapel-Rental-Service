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
    public partial class RentToCust : Form
    {
        private TouristCust custobj;
        private Vehicle vehobj;
        private int custindex;
        private int vehindex;
        public RentToCust()
        {
            InitializeComponent();
        }

        public void fillCustid()
        {
            custidcmb.Items.Clear();

            if (menumdi.Customerlist.Count > 0)
            {
                foreach (TouristCust cust in menumdi.Customerlist)
                {
                    custidcmb.Items.Add(cust.CustID);
                }
            }
            else
            {
                MessageBox.Show("No Tourist/Customer Record Exists !! Add Customer Record First !!!");
            }
        }

        public void fillRegNo()
        {
            vehregnocmb.Items.Clear();

            if (menumdi.Vehiclelist.Count > 0)
            {
                foreach (Vehicle veh in menumdi.Vehiclelist)
                {
                    if(veh.IsRented == false && veh.IsReserved == false)
                    {
                        vehregnocmb.Items.Add(veh.VehRegNo.ToString());
                    }
                   
                }
            }
            else
            {
                MessageBox.Show("No Vehicles Records Exist !!! Add Vehicle Record !!!");
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RentToCust_Load(object sender, EventArgs e)
        {
            fillCustid();
            fillRegNo();
            trannotxt.Focus();
        }

        private void trannotxt_Validating(object sender, CancelEventArgs e)
        {
            if(trannotxt.Text == "")
            {
                errorProvider1.SetError(trannotxt, "Transaction Number cannot be blank");
                trannotxt.Focus();
            }
            else
            {
                errorProvider1.SetError(trannotxt, "");
            }
        }

        private void custidcmb_Validating(object sender, CancelEventArgs e)
        {
            if(custidcmb.Text == "" || custidcmb.SelectedIndex < 0)
            {
                errorProvider1.SetError(custidcmb, "Select Customer ID");
                custidcmb.Focus();
            }
            else
            {
                errorProvider1.SetError(custidcmb, "");
            }
        }

        private void vehregnocmb_Validating(object sender, CancelEventArgs e)
        {
            if(vehregnocmb.Text == "" || vehregnocmb.SelectedIndex < 0)
            {
                errorProvider1.SetError(vehregnocmb, "Select Vehicle Registration No.");
                vehregnocmb.Focus();
            }
            else
            {
                errorProvider1.SetError(vehregnocmb, "");
            }
        }

        private void custidcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string custid = custidcmb.Text;

            foreach(TouristCust tc in menumdi.Customerlist)
            {
                if(tc.CustID.Equals(custid))
                {
                    custobj = tc;
                    custindex = menumdi.Customerlist.IndexOf(tc);
                    custnamtxt.Text = tc.FullName;
                    drvlictxt.Text = tc.DrivingLicence;
                    break;
                }

            }
        }

        private void vehregnocmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string regno = vehregnocmb.Text;

            foreach(Vehicle vh in menumdi.Vehiclelist)
            {
                if(vh.VehRegNo.Equals(regno))
                {
                    vehobj = vh;
                    vehindex = menumdi.Vehiclelist.IndexOf(vh);
                    vehtyptxt.Text = vh.VehType.ToString();
                    vehratetxt.Text = vh.VehRate.ToString();
                    break;
                }           
            }
        }

        private void rentbtn_Click(object sender, EventArgs e)
        {
            vehobj.IsRented = true;

            menumdi.Vehiclelist[vehindex] = vehobj;

            string tranno = trannotxt.Text;
            string trandt = trandtpkr.Value.ToShortDateString();
            int dayrent = (int) daysnum.Value;

            RentCustomer obj = new RentCustomer(tranno, trandt, custobj, vehobj, dayrent);
            menumdi.Rentcustlist.Add(obj);
            menumdi.savevehiclefile();
            menumdi.saverentcustfile();

            MessageBox.Show("Vehicle Rented to Customer Successfully !!! \n\n" + obj.RentRecipt());



        }

    

        private void clearbtn_Click(object sender, EventArgs e)
        {
            trannotxt.Text = "";
            trandtpkr.Text = "";
            custidcmb.Text = "";
            vehregnocmb.Text = "";
            custnamtxt.Text = "";
            vehtyptxt.Text = "";
            drvlictxt.Text = "";
            vehratetxt.Text = "";
            daysnum.Value = daysnum.Minimum;
            trannotxt.Focus();

        }
    }
}
