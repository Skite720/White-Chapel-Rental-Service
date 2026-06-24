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
    public partial class RentToAgency : Form
    {
        private AgencyCompany compobj;
        private Vehicle vehobj;
        private int compindex;
        private int vehindex;
        public RentToAgency()
        {
            InitializeComponent();
        }

        public void fillCompid()
        {
            compidcmb.Items.Clear();

            if (menumdi.Companylist.Count > 0)
            {
                foreach (AgencyCompany co in menumdi.Companylist)
                {
                    compidcmb.Items.Add(co.CompanyID);
                }
            }
            else
            {
                MessageBox.Show("No Travel Agency/Company Records Exist !!! Add Agency/Company First !!!");
            }

        }

        public void fillRegNo()
        {
            vehregnocmb.Items.Clear();

            if (menumdi.Vehiclelist.Count > 0)
            {
                foreach (Vehicle veh in menumdi.Vehiclelist)
                {
                    if (veh.IsRented == false && veh.IsReserved == false)
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

        private void RentToAgency_Load(object sender, EventArgs e)
        {
            fillCompid();
            fillRegNo();
            trannotxt.Focus();
        }

        private void compidcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compid = compidcmb.Text;

            foreach (AgencyCompany ac in menumdi.Companylist)
            {
                if (ac.CompanyID.Equals(compid))
                {
                    compobj = ac;
                    compindex = menumdi.Companylist.IndexOf(ac);
                    compnamtxt.Text = ac.CompanyName;
                    contnamtxt.Text = ac.ContactName;
                    break;
                }

            }
        }

        private void trannotxt_Validating(object sender, CancelEventArgs e)
        {
            if (trannotxt.Text == "")
            {
                errorProvider1.SetError(trannotxt, "Transaction Number cannot be blank");
                trannotxt.Focus();
            }
            else
            {
                errorProvider1.SetError(trannotxt, "");
            }
        }

        private void compidcmb_Validating(object sender, CancelEventArgs e)
        {
            if(compidcmb.Text == "" || compidcmb.SelectedIndex < 0)
            {
                errorProvider1.SetError(compidcmb, "Select Company ID");
            }
            else
            {
                errorProvider1.SetError(compidcmb, "");
            }
        }

        private void vehregnocmb_Validating(object sender, CancelEventArgs e)
        {
            if (vehregnocmb.Text == "" || vehregnocmb.SelectedIndex < 0)
            {
                errorProvider1.SetError(vehregnocmb, "Select Vehicle Registration No.");
                vehregnocmb.Focus();
            }
            else
            {
                errorProvider1.SetError(vehregnocmb, "");
            }
        }

        private void vehregnocmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string regno = vehregnocmb.Text;

            foreach (Vehicle vh in menumdi.Vehiclelist)
            {
                if (vh.VehRegNo.Equals(regno))
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
            vehobj.IsReserved = true;

            menumdi.Vehiclelist[vehindex] = vehobj;

            string tranno = trannotxt.Text;
            string trandt = trandtpkr.Value.ToShortDateString();
            int dayrent = (int)daysnum.Value;

            RentCompany obj = new RentCompany(tranno, trandt, compobj, vehobj, dayrent);
            menumdi.Rentcomplist.Add(obj);
            menumdi.savevehiclefile();
            menumdi.saverentcompfile();

            MessageBox.Show("Vehicle Reserved to Agency/Company Successfully !!! \n\n" + obj.RentRecipt());

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            trannotxt.Text = "";
            trandtpkr.Text = "";
            compidcmb.Text = "";
            vehregnocmb.Text = "";
            compnamtxt.Text = "";
            vehtyptxt.Text = "";
            contnamtxt.Text = "";
            vehratetxt.Text = "";
            daysnum.Value = daysnum.Minimum;
            trannotxt.Focus();

        }
    }
}
