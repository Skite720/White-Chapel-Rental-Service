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
    public partial class DeleteVehicle : Form
    {
        private Vehicle delobj;
        private int index;
        public DeleteVehicle()
        {
            InitializeComponent();
        }

        public void fillRegNo()
        {
            vehregnocmb.Items.Clear();

            if (menumdi.Vehiclelist.Count > 0)
            {
                foreach (Vehicle veh in menumdi.Vehiclelist)
                {
                    vehregnocmb.Items.Add(veh.VehRegNo.ToString());
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

        private void DeleteVehicle_Load(object sender, EventArgs e)
        {
            fillRegNo();
        }

        private void vehregnocmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string regno = vehregnocmb.Text;

            foreach (Vehicle veh in menumdi.Vehiclelist)
            {
                if (veh.VehRegNo.Equals(regno))
                {
                    delobj = veh;
                    index = menumdi.Vehiclelist.IndexOf(veh);
                    vehtypcmb.Text = veh.VehType.ToString();
                    engsztxt.Text = veh.EngineSize;
                    colortxt.Text = veh.VehColor;
                    modeltxt.Text = veh.VehModel;
                    maketxt.Text = veh.VehMake;
                    mileagetxt.Text = veh.VehMileage.ToString();
                    fueltypcmb.Text = veh.VehFuelType.ToString();
                    geartypcmb.Text = veh.VehGearBox.ToString();
                    nodoors.Value = Convert.ToInt32(veh.VehNoDoors.ToString());
                    srvhisttxt.Text = veh.VehServiceHist;
                    safinfotxt.Text = veh.VehSafetyInfo;
                    lengthtxt.Text = veh.VehLength.ToString();
                    widthtxt.Text = veh.VehWidth.ToString();
                    heighttxt.Text = veh.VehHeight.ToString();
                    isrentedchk.Checked = veh.IsRented;
                    isreservedchk.Checked = veh.IsReserved;
                    break;
                }
            }
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            menumdi.Vehiclelist.RemoveAt(index);
            menumdi.savevehiclefile();
            fillRegNo();
            vehregnocmb.Text = "";
            vehtypcmb.Text = "";
            engsztxt.Text = "";
            colortxt.Text = "";
            modeltxt.Text = "";
            maketxt.Text = "";
            mileagetxt.Text = "";
            fueltypcmb.Text = "";
            geartypcmb.Text = "";
            nodoors.Value = nodoors.Minimum;
            srvhisttxt.Text = "";
            safinfotxt.Text = "";
            lengthtxt.Text = "";
            widthtxt.Text = "";
            heighttxt.Text = "";
            isrentedchk.Checked = false;
            isreservedchk.Checked = false;

            MessageBox.Show("Vehicle Record Deleted successfully !!!");
        }
    }
}
