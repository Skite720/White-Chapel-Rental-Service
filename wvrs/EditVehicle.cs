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
    public partial class EditVehicle : Form
    {
        private Vehicle edtobj;
        private int index;
        public EditVehicle()
        {
            InitializeComponent();
        }

        public void fillRegNo()
        {
            vehregnocmb.Items.Clear();
            
            if(menumdi.Vehiclelist.Count > 0)
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

        private void EditVehicle_Load(object sender, EventArgs e)
        {
            fillRegNo();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void vehtypcmb_Validating(object sender, CancelEventArgs e)
        {
            if (vehtypcmb.Text == "" || vehtypcmb.SelectedIndex < 0)
            {
                errorProvider1.SetError(vehtypcmb, "Select Vehicle Type");
                vehtypcmb.Focus();
            }
            else
            {
                errorProvider1.SetError(vehtypcmb, "");
            }
        }

        private void engsztxt_Validating(object sender, CancelEventArgs e)
        {
            if (engsztxt.Text == "")
            {
                errorProvider1.SetError(engsztxt, "Engine Size cannot be blank");
                engsztxt.Focus();
            }
            else
            {
                errorProvider1.SetError(engsztxt, "");
            }
        }

        private void colortxt_Validating(object sender, CancelEventArgs e)
        {
            if (colortxt.Text == "")
            {
                errorProvider1.SetError(colortxt, "Color cannot be blank");
                colortxt.Focus();
            }
            else
            {
                errorProvider1.SetError(colortxt, "");
            }
        }

        private void modeltxt_Validating(object sender, CancelEventArgs e)
        {
            if (modeltxt.Text == "")
            {
                errorProvider1.SetError(modeltxt, "Model cannot be blank");
                modeltxt.Focus();
            }
            else
            {
                errorProvider1.SetError(modeltxt, "");
            }
        }

        private void maketxt_Validating(object sender, CancelEventArgs e)
        {
            if (maketxt.Text == "")
            {
                errorProvider1.SetError(maketxt, "Make cannot be blank");
                maketxt.Focus();
            }
            else
            {
                errorProvider1.SetError(maketxt, "");
            }
        }

        private void mileagetxt_Validating(object sender, CancelEventArgs e)
        {
            if (mileagetxt.Text == "")
            {
                errorProvider1.SetError(mileagetxt, "Mileage cannot be blank");
                mileagetxt.Focus();
            }
            else if (double.TryParse(mileagetxt.Text, out double mileage) == false)
            {
                errorProvider1.SetError(mileagetxt, "Mileage should be numeric value only");
                mileagetxt.Focus();
            }
            else
            {
                errorProvider1.SetError(mileagetxt, "");
            }
        }

        private void fueltypcmb_Validating(object sender, CancelEventArgs e)
        {
            if (fueltypcmb.Text == "" || fueltypcmb.SelectedIndex < 0)
            {
                errorProvider1.SetError(fueltypcmb, "Select Fuel Type");
                fueltypcmb.Focus();
            }
            else
            {
                errorProvider1.SetError(fueltypcmb, "");
            }
        }

        private void geartypcmb_Validating(object sender, CancelEventArgs e)
        {
            if (geartypcmb.Text == "" || geartypcmb.SelectedIndex < 0)
            {
                errorProvider1.SetError(geartypcmb, "Select Gear Type");
            }
            else
            {
                errorProvider1.SetError(geartypcmb, "");
            }
        }

        private void lengthtxt_Validating(object sender, CancelEventArgs e)
        {
            if (lengthtxt.Text == "")
            {
                errorProvider1.SetError(lengthtxt, "Length of vehicle cannot be blank");
                lengthtxt.Focus();
            }
            else if (double.TryParse(lengthtxt.Text, out double lngth) == false)
            {
                errorProvider1.SetError(lengthtxt, "Length should be numeric value only");
                lengthtxt.Focus();
            }
            else
            {
                errorProvider1.SetError(lengthtxt, "");
            }
        }

        private void widthtxt_Validating(object sender, CancelEventArgs e)
        {
            if (widthtxt.Text == "")
            {
                errorProvider1.SetError(widthtxt, "Width of Vehicle cannot be blank");
                widthtxt.Focus();
            }
            else if (double.TryParse(widthtxt.Text, out double wdth) == false)
            {
                errorProvider1.SetError(widthtxt, "Width should be numeric value only");
                widthtxt.Focus();
            }
            else
            {
                errorProvider1.SetError(widthtxt, "");
            }
        }

        private void heighttxt_Validating(object sender, CancelEventArgs e)
        {
            if (heighttxt.Text == "")
            {
                errorProvider1.SetError(heighttxt, "Height of Vehicle cannot be blank");
                heighttxt.Focus();
            }
            else if (double.TryParse(heighttxt.Text, out double hght) == false)
            {
                errorProvider1.SetError(heighttxt, "Height should be numeric value");
                heighttxt.Focus();
            }
            else
            {
                errorProvider1.SetError(heighttxt, "");
            }
        }

        private void vehregnocmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string regno = vehregnocmb.Text;

            foreach(Vehicle veh in menumdi.Vehiclelist)
            {
                if(veh.VehRegNo.Equals(regno))
                {
                    edtobj = veh;
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

        private void savebtn_Click(object sender, EventArgs e)
        {
            string regno = vehregnocmb.Text;
            VehicleType vehtype = (VehicleType)Enum.Parse(typeof(VehicleType), vehtypcmb.Text, true);
            string engsize = engsztxt.Text;
            string vehcolor = colortxt.Text;
            string vehmod = modeltxt.Text;
            string vehmak = maketxt.Text;
            double vehmilage = Convert.ToDouble(mileagetxt.Text);
            FuelType vehfultyp = (FuelType)Enum.Parse(typeof(FuelType), fueltypcmb.Text, true);
            GearType vehgrbox = (GearType)Enum.Parse(typeof(GearType), geartypcmb.Text, true);
            int nodoor = Convert.ToInt32(nodoors.Value);
            string srvhist = srvhisttxt.Text;
            string safinfo = safinfotxt.Text;
            double length = Convert.ToDouble(lengthtxt.Text);
            double width = Convert.ToDouble(widthtxt.Text);
            double height = Convert.ToDouble(heighttxt.Text);
            bool isrented = isrentedchk.Checked;
            bool isreserved = isreservedchk.Checked;

            edtobj = new Vehicle(regno, vehtype, engsize, vehcolor, vehmod, vehmak, vehmilage, vehfultyp, vehgrbox,
                nodoor, srvhist, safinfo, length, width, height, isrented, isreserved);

            menumdi.Vehiclelist[index] = edtobj;

            menumdi.savevehiclefile();

            MessageBox.Show("Vehicle Record Edited successfully !!!");

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
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
        }
    }
}
