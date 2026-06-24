using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace wvrs
{
    public partial class menumdi : Form
    {
        private static string userfile = @"..\..\Data\user.csv";
        private static string vehiclefile = @"..\..\Data\vehicle.csv";
        private static string touristcustfile = @"..\..\Data\customer.csv";
        private static string agencyfile = @"..\..\Data\agency.csv";
        private static string rentcustfile = @"..\..\Data\rentcustomer.csv";
        private static string rentcompfile = @"..\..\Data\rentcompany.csv";

        private static List<user> userlist = new List<user>();
        private static List<Vehicle> vehiclelist = new List<Vehicle>();
        private static List<TouristCust> customerlist = new List<TouristCust>();
        private static List<AgencyCompany> companylist = new List<AgencyCompany>();
        private static List<RentCustomer> rentcustlist = new List<RentCustomer>();
        private static List<RentCompany> rentcomplist = new List<RentCompany>();
        public menumdi()
        {
            InitializeComponent();
        }

        internal static List<user> Userlist { get => userlist; set => userlist = value; }
        internal static List<Vehicle> Vehiclelist { get => vehiclelist; set => vehiclelist = value; }
        internal static List<TouristCust> Customerlist { get => customerlist; set => customerlist = value; }
        internal static List<AgencyCompany> Companylist { get => companylist; set => companylist = value; }
        internal static List<RentCustomer> Rentcustlist { get => rentcustlist; set => rentcustlist = value; }
        internal static List<RentCompany> Rentcomplist { get => rentcomplist; set => rentcomplist = value; }

        public static void loaduserfile()
        {
            if (File.Exists(userfile))
            {
                var lines = File.ReadAllLines(userfile).Skip(1);

                foreach (string line in lines)
                {
                    if (line != null)
                    {
                        string[] cols = line.Split(',');

                        string fname = cols[0];
                        string lname = cols[1];
                        string addrs = cols[2];
                        string usrname = cols[3];
                        string passwd = cols[4];
                        string mobile = cols[5];
                        string email = cols[6];

                        user obj = new user(fname, lname, addrs, usrname, passwd, mobile, email);
                        Userlist.Add(obj);
                    }
                }
            }
        }

        public static void saveuserfile()
        {
            StreamWriter sw = new StreamWriter(userfile);

            sw.WriteLine("FirstName" + "," + "LastName" + "," + "Address" + "," + "UserName" + "," + "Password" + "," + "MobileNo" + "," + "EmailAddress");

            foreach (user usr in Userlist)
            {
                sw.WriteLine(usr.ToCSVString());
            }
            sw.Close();
        }


        public static void loadvehiclefile()
        {
            if(File.Exists(vehiclefile))
            {
                var lines = File.ReadAllLines(vehiclefile).Skip(1);

                foreach(string line in lines)
                {
                    if(line !=null)
                    {
                        string []cols = line.Split(',');

                        string vehregno = cols[0];
                        VehicleType vehtype = (VehicleType)Enum.Parse(typeof(VehicleType), cols[1], true);
                        string engsize = cols[2];
                        string vehcolor = cols[3];
                        string vehmodel = cols[4];
                        string vehmake = cols[5];
                        double vehmileage = Convert.ToDouble(cols[6]);
                        FuelType vehfueltype = (FuelType)Enum.Parse(typeof(FuelType), cols[7], true);
                        GearType vehgearbox = (GearType)Enum.Parse(typeof(GearType), cols[8], true);
                        int nodoors = Convert.ToInt32(cols[9]);
                        string srvhist = cols[10];
                        string safinfo = cols[11];
                        double vehlength = Convert.ToDouble(cols[12]);
                        double vehwidth = Convert.ToDouble(cols[13]);
                        double vehheight = Convert.ToDouble(cols[14]);
                        int vehrate = Convert.ToInt32(cols[15]);
                        bool isrented = bool.Parse(cols[16]);
                        bool isrsrvd = bool.Parse(cols[17]);

                        Vehicle obj = new Vehicle(vehregno, vehtype, engsize, vehcolor, vehmodel, vehmake,
                            vehmileage, vehfueltype, vehgearbox, nodoors, srvhist, safinfo,
                            vehlength, vehwidth, vehheight, isrented, isrsrvd);

                        Vehiclelist.Add(obj);
                    }
                }
            }
        }


        public static void savevehiclefile()
        {
            StreamWriter sw = new StreamWriter(vehiclefile);

            sw.WriteLine("VehRegNo" + "," + "VehType" + "," + "EngineSize" + "," + "Color" + ","
                + "Model" + "," + "Make" + "," + "Mileage" + "," + "FuelType" + "," + "GearType" +
                "," + "NoOfDoors" + "," + "ServiceHist" + "," + "SafetyInfo" + "," + "Length" + "," +
                "Width" + "," + "Height" + "," + "VehRate" + "," + "IsRented" + "," + "IsReserved");

            foreach(Vehicle veh in Vehiclelist)
            {
                sw.WriteLine(veh.ToCSVString());
            }
            sw.Close();
        }

        public static void loadcustfile()
        {
            if(File.Exists(touristcustfile))
            {
                var lines = File.ReadAllLines(touristcustfile).Skip(1);

                foreach(string line in lines)
                {
                    if(line != null)
                    {
                        string[] cols = line.Split(',');

                        string custid = cols[0];
                        string fullname = cols[1];
                        string drvlic = cols[2];
                        string dob = cols[3];
                        string address = cols[4];
                        string mobno = cols[5];
                        string email = cols[6];
                        string emeadd = cols[7];
                        string ememobno = cols[8];

                        TouristCust obj = new TouristCust(custid, fullname, drvlic, dob, address, mobno, email, emeadd, ememobno);
                        Customerlist.Add(obj);
                    }
                }
            }

        }


        public static void savecustfile()
        {
            StreamWriter sw = new StreamWriter(touristcustfile);

            sw.WriteLine("CustomerID" + "," + "FullName" + "," + "DrivingLicence" + "," + "DateOfBirth" + ","
                + "Address" + "," + "MobileNo" + "," + "Email" + "," + "EmergencyAddress" + "," + "EmergencyMobileNo");

            foreach(TouristCust cust in Customerlist)
            {
                sw.WriteLine(cust.ToCSVString());
            }
            sw.Close();
        }


        public static void loadcompfile()
        {
            if(File.Exists(agencyfile))
            {
                var lines = File.ReadAllLines(agencyfile).Skip(1);

                foreach(string line in lines)
                {
                    if(line != null)
                    {
                        string[] cols = line.Split(',');

                        string compid = cols[0];
                        string compname = cols[1];
                        string compadd = cols[2];
                        string contname = cols[3];
                        string contadd = cols[4];
                        string contmobno = cols[5];
                        string contemail = cols[6];

                        AgencyCompany obj = new AgencyCompany(compid, compname, compadd, contname, contadd, contmobno, contemail);
                        Companylist.Add(obj);
                    }
                }

            }
        }

        public static void savecompfile()
        {
            StreamWriter sw = new StreamWriter(agencyfile);

            sw.WriteLine("CompanyID" + "," + "CompanyName" + "," + "CompanyAddress" + "," + "ContactName" + ","
                + "ContactAddress" + "," + "ContactMobileNo" + "," + "ContactEmail");

            foreach(AgencyCompany comp in Companylist)
            {
                sw.WriteLine(comp.ToCSVString());
            }

            sw.Close();
        }

        public static void loadrentcustfile()
        {
            if(File.Exists(rentcustfile))
            {
                var lines = File.ReadAllLines(rentcustfile).Skip(1);

                foreach(string line in lines)
                {
                    if(line != null)
                    {

                        string[] cols = line.Split(',');

                        string tranno = cols[0];
                        string trandt = cols[1];
                        string custid = cols[2];

                        TouristCust tcust = null;
                        foreach (TouristCust c in Customerlist)
                        {
                            if (c.CustID.Equals(custid))
                            {
                                tcust = c;
                                break;
                            }
                        }

                        string regno = cols[3];

                        Vehicle custveh = null;
                        foreach(Vehicle v in Vehiclelist)
                        {
                            if(v.VehRegNo.Equals(regno))
                            {
                                custveh = v;
                                break;
                            }
                        }

                        int dayrented = Convert.ToInt32(cols[4]);
                        string returndt = cols[5];
                        string actretdt = cols[6];
                        int actrentday = Convert.ToInt32(cols[7]);
                        double rentamt = Convert.ToDouble(cols[8]);
                        double vatamt = Convert.ToDouble(cols[9]);
                        double totrent = Convert.ToDouble(cols[10]);
                        double damgcost = Convert.ToDouble(cols[11]);
                        double totcost = Convert.ToDouble(cols[12]);

                        RentCustomer obj = new RentCustomer(tranno, trandt, tcust, custveh, dayrented,
                            actrentday, actretdt, rentamt, vatamt, totrent, damgcost, totcost);

                        Rentcustlist.Add(obj);
                    }
                }
            }
        }


        public static void saverentcustfile()
        {
            StreamWriter sw = new StreamWriter(rentcustfile);

            sw.WriteLine("TranNo" + "," + "TranDt" + "," + "CustomerID" + "," + "VehicleRegNo" + "," +
                "DaysRented" + "," + "ReturnDt" + "," + "ActualReturnDt" + "," + "ActualRentDays" + "," +
                "RentAmount" + "," + "VatAmount" + "," + "TotalRent" + "," + "DamageCost" + "," + "TotalCost");

            foreach(RentCustomer rcust in Rentcustlist)
            {
                sw.WriteLine(rcust.ToCSVString());
            }

            sw.Close();
        }

        public static void loadrentcompfile()
        {
            if (File.Exists(rentcompfile))
            {
                var lines = File.ReadAllLines(rentcompfile).Skip(1);

                foreach (string line in lines)
                {
                    if (line != null)
                    {

                        string[] cols = line.Split(',');

                        string tranno = cols[0];
                        string trandt = cols[1];
                        string compid = cols[2];

                        AgencyCompany tcomp = null;
                        foreach (AgencyCompany c in Companylist)
                        {
                            if (c.CompanyID.Equals(compid))
                            {
                                tcomp = c;
                                break;
                            }
                        }

                        string regno = cols[3];

                        Vehicle custveh = null;
                        foreach (Vehicle v in Vehiclelist)
                        {
                            if (v.VehRegNo.Equals(regno))
                            {
                                custveh = v;
                                break;
                            }
                        }

                        int dayrented = Convert.ToInt32(cols[4]);
                        string returndt = cols[5];
                        string actretdt = cols[6];
                        int actrentday = Convert.ToInt32(cols[7]);
                        double rentamt = Convert.ToDouble(cols[8]);
                        double vatamt = Convert.ToDouble(cols[9]);
                        double totrent = Convert.ToDouble(cols[10]);
                        double damgcost = Convert.ToDouble(cols[11]);
                        double totcost = Convert.ToDouble(cols[12]);

                        RentCompany obj = new RentCompany(tranno, trandt, tcomp, custveh, dayrented,
                            returndt, actrentday, actretdt, rentamt, vatamt, totrent, damgcost, totcost);

                        Rentcomplist.Add(obj);
                    }
                }
            }
        }

        public static void saverentcompfile()
        {
            StreamWriter sw = new StreamWriter(rentcompfile);

            sw.WriteLine("TranNo" + "," + "TranDt" + "," + "CompanyID" + "," + "VehicleRegNo" + "," +
                "DaysRented" + "," + "ReturnDt" + "," + "ActualReturnDt" + "ActualRentDays" + "," +
                "RentAmount" + "," + "VatAmount" + "," + "TotalRent" + "," + "DamageCost" + "," + "TotalCost");

            foreach (RentCompany rcomp in Rentcomplist)
            {
                sw.WriteLine(rcomp.ToCSVString());
            }

            sw.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save changes ?", "WVRS", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                saveuserfile();
                savevehiclefile();
                savecustfile();
                savecompfile();
                saverentcompfile();
                saverentcustfile();
                
                Application.Exit();
            }
            
        }

        private void menumdi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {

                if (MessageBox.Show("Do you want to save changes ?", "WVRS", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    saveuserfile();
                    savevehiclefile();
                    savecustfile();
                    savecompfile();
                    saverentcompfile();
                    saverentcustfile();

                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void menumdi_Load(object sender, EventArgs e)
        {
            loaduserfile();
            loadvehiclefile();
            loadcustfile();
            loadcompfile();
            loadrentcustfile();
            loadrentcompfile();

        }

        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVehicle frm = new AddVehicle();
            frm.MdiParent = this;
            frm.Show();

        }

        private void editVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditVehicle frm = new EditVehicle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void deleteVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteVehicle frm = new DeleteVehicle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void viewVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewVehicle frm = new ViewVehicle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void addTouristIndividualCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTouristCust frm = new AddTouristCust();
            frm.MdiParent = this;
            frm.Show();
        }

        private void addTravelAgencyCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAgency frm = new AddAgency();
            frm.MdiParent = this;
            frm.Show();
        }

        private void deleteTouristIndividualCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteTouristCust frm = new DeleteTouristCust();
            frm.MdiParent = this;
            frm.Show();
        }

        private void deleteTravelAgencyCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAgency frm = new DeleteAgency();
            frm.MdiParent = this;
            frm.Show();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser frm = new AddUser();
            frm.MdiParent = this;
            frm.Show();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUser frm = new DeleteUser();
            frm.MdiParent = this;
            frm.Show();
        }

        private void changeUserPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword frm = new ChangePassword();
            frm.MdiParent = this;
            frm.Show();
        }

        private void allVehicleReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllVehList frm = new AllVehList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AllCustList frm = new AllCustList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AllAgencyList frm = new AllAgencyList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rentVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentToCust frm = new RentToCust();
            frm.MdiParent = this;
            frm.Show();
        }

        private void returnVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentToAgency frm = new RentToAgency();
            frm.MdiParent = this;
            frm.Show();
        }

        private void returnVehicleFromTouristCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnFromCust frm = new ReturnFromCust();
            frm.MdiParent = this;
            frm.Show();
        }

        private void returnVehicleFromTravelAgencyCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnFromAgency frm = new ReturnFromAgency();
            frm.MdiParent = this;
            frm.Show();
        }

        private void allRentedVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllRentedVehList frm = new AllRentedVehList();
            frm.MdiParent = this;
            frm.Show();

        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehRentedByCustList frm = new VehRentedByCustList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void vehiclesRentedByTravelAgencyCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehRentedByAgencyList frm = new VehRentedByAgencyList();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
