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
    public partial class ReturnFromAgency : Form
    {
        private RentCompany compobj;
        private int index;

        public ReturnFromAgency()
        {
            InitializeComponent();
        }

        public void filltranno()
        {
            trannocmb.Items.Clear();

            if (menumdi.Rentcomplist.Count > 0)
            {
                foreach (RentCompany rc in menumdi.Rentcomplist)
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

        private void ReturnFromAgency_Load(object sender, EventArgs e)
        {
            filltranno();
            trannocmb.Focus();
        }

        private void trannocmb_Validating(object sender, CancelEventArgs e)
        {
            if (trannocmb.Text == "" || trannocmb.SelectedIndex < 0)
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

            foreach (RentCompany rc in menumdi.Rentcomplist)
            {
                if (rc.TranNo.Equals(tranno))
                {
                    compobj = rc;
                    index = menumdi.Rentcomplist.IndexOf(rc);
                    trandttxt.Text = rc.TranDt;
                    compidtxt.Text = rc.Company.CompanyID;
                    compnamtxt.Text = rc.Company.CompanyName;
                    contnamtxt.Text = rc.Company.ContactName;
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
            if (damagechk.Checked == true)
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
            if (damagechk.Checked == true)
            {
                damgcost = Convert.ToDouble(damgcosttxt.Text);
            }
            else
            {
                damgcost = 0.0;
            }

            compobj.ReturnVehicle(actretdt, damgcost);
            compobj.Veh.IsReserved = false;

            menumdi.Rentcomplist[index] = compobj;
            menumdi.savevehiclefile();
            menumdi.saverentcompfile();

            MessageBox.Show("Vehicle Returned from Agency Successfully !!! \n\n" + compobj.ReturnRecipt());
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            trannocmb.Text = "";
            trandttxt.Text = "";
            compidtxt.Text = "";
            vehregnotxt.Text = "";
            compnamtxt.Text = "";
            vehtyptxt.Text = "";
            contnamtxt.Text = "";
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
