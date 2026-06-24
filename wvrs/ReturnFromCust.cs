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
    public partial class ReturnFromCust : Form
    {
        private RentCustomer custobj;
        private int index;
        public ReturnFromCust()
        {
            InitializeComponent();
        }

        public void filltranno()
        {
            trannocmb.Items.Clear();

            if(menumdi.Rentcustlist.Count > 0)
            {
                foreach (RentCustomer rc in menumdi.Rentcustlist)
                {
                    trannocmb.Items.Add(rc.TranNo);
                }
            }
            else
            {
                MessageBox.Show("No Rent Record Available !!! Rent a Vehicle first");
            }
        }


        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReturnFromCust_Load(object sender, EventArgs e)
        {
            filltranno();
            trannocmb.Focus();
        }

        private void trannocmb_Validating(object sender, CancelEventArgs e)
        {
            if(trannocmb.Text == "" || trannocmb.SelectedIndex < 0)
            {
                errorProvider1.SetError(trannocmb, "Select Transaction No.");
                trannocmb.Focus();
            }
            else
            {
                errorProvider1.SetError(trannocmb, "");
            }
        }

        private void trannocmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tranno = trannocmb.Text;

            foreach(RentCustomer rc in menumdi.Rentcustlist)
            {
                if(rc.TranNo.Equals(tranno))
                {
                    custobj = rc;
                    index = menumdi.Rentcustlist.IndexOf(rc);
                    trandttxt.Text = rc.TranDt;
                    custidtxt.Text = rc.Cust.CustID;
                    custnamtxt.Text = rc.Cust.FullName;
                    drvlictxt.Text = rc.Cust.DrivingLicence;
                    vehregnotxt.Text = rc.Veh.VehRegNo;
                    vehtyptxt.Text = rc.Veh.VehType.ToString();
                    vehratetxt.Text = rc.Veh.VehRate.ToString();
                    dayrentedtxt.Text = rc.DaysRented.ToString();
                    tretdttxt.Text = rc.ReturnDt;
                    break;
                }
            }
        }

        private void damagechk_CheckedChanged(object sender, EventArgs e)
        {
            if(damagechk.Checked == true)
            {
                lbldmg.Visible = true;
                damgcosttxt.Visible = true;
            }
            else
            {
                lbldmg.Visible = false;
                damgcosttxt.Visible = false;
                damgcosttxt.Text = "";
            }
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            string actretdt = actretdtpkr.Value.ToShortDateString();
            double damgcost;
            if(damagechk.Checked == true)
            {
                damgcost = Convert.ToDouble(damgcosttxt.Text);
            }
            else
            {
                damgcost = 0.0;
            }

            custobj.ReturnVehicle(actretdt, damgcost);
            custobj.Veh.IsRented = false;

            menumdi.Rentcustlist[index] = custobj;
            menumdi.savevehiclefile();
            menumdi.saverentcustfile();

            MessageBox.Show("Vehicle Returned from Customer Successfully !!! \n\n" + custobj.ReturnRecipt());
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            trannocmb.Text = "";
            trandttxt.Text = "";
            custidtxt.Text = "";
            vehregnotxt.Text = "";
            custnamtxt.Text = "";
            vehtyptxt.Text = "";
            drvlictxt.Text = "";
            vehratetxt.Text = "";
            dayrentedtxt.Text = "";
            tretdttxt.Text = "";
            actretdtpkr.Value = DateTime.Now;
            damagechk.Checked = false;
            damgcosttxt.Text = "";
            lbldmg.Visible = false;
            damgcosttxt.Visible = false;
            filltranno();
            trannocmb.Focus();




        }
    }
}
