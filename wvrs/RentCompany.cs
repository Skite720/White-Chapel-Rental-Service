using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wvrs
{
    class RentCompany
    {
        private string tranno;
        private string trandt;
        private AgencyCompany comp;
        private Vehicle veh;
        private int daysrented;
        private string returndt;
        private int actualrentdays;
        private string actualreturndt;
        private double rentamount;
        private double vatamount;
        private double totalrent;
        private double damagecost;
        private double totalcost;


        public RentCompany(string tranno, string trandt, AgencyCompany comp, Vehicle veh, int daysrented,
            string returndt = "", int actualrentdays = 0, string actualreturndt = "", double rentamount = 0.0,
            double vatamount = 0.0, double totalrent = 0.0, double damagecost = 0.0, double totalcost = 0.0)
        {
            this.tranno = tranno;
            this.trandt = trandt;
            this.comp = comp;
            this.veh = veh;
            this.daysrented = daysrented;
            DateTime returndat = DateTime.Parse(trandt.ToString()).AddDays(daysrented);
            this.returndt = returndat.ToShortDateString();
            this.actualrentdays = actualrentdays;
            this.actualreturndt = actualreturndt;
            this.rentamount = rentamount;
            this.vatamount = vatamount;
            this.totalrent = totalrent;
            this.damagecost = damagecost;
            this.totalcost = totalcost;
        }

        public void ReturnVehicle(string returndt, double damagecost)
        {
            this.actualreturndt = returndt;
            this.actualrentdays = (DateTime.Parse(this.actualreturndt.ToString()) - DateTime.Parse(trandt.ToString())).Days;
            this.rentamount = this.actualrentdays * this.veh.VehRate;
            this.vatamount = 0.15 * this.rentamount;
            this.totalrent = this.rentamount + this.vatamount;
            this.damagecost = damagecost;
            this.totalcost = this.totalrent + this.damagecost;
        }

        public string TranNo
        {
            get
            {
                return this.tranno;
            }
            set
            {
                this.tranno = value;
            }
        }

        public string TranDt
        {
            get
            {
                return this.trandt;
            }
            set
            {
                this.trandt = value;
            }
        }

        public AgencyCompany Company
        {
            get
            {
                return this.comp;
            }
            set
            {
                this.comp = value;
            }
        }

        public Vehicle Veh
        {
            get
            {
                return this.veh;
            }
            set
            {
                this.veh = value;
            }
        }

        public int DaysRented
        {
            get
            {
                return this.daysrented;
            }
            set
            {
                this.daysrented = value;
            }
        }

        public string ReturnDt
        {
            get
            {
                return this.returndt;
            }
        }

        public string ActualReturnDt
        {
            get
            {
                return this.actualreturndt;
            }
            set
            {
                this.actualreturndt = value;
            }
        }

        public int ActualRentDays
        {
            get
            {
                return this.actualrentdays;
            }
        }

        public double RentAmount
        {
            get
            {
                return this.rentamount;
            }
        }

        public double VatAmount
        {
            get
            {
                return this.vatamount;
            }
        }

        public double TotalRent
        {
            get
            {
                return this.totalrent;
            }
        }

        public double DamageCost
        {
            get
            {
                return this.damagecost;
            }
        }

        public double TotalCost
        {
            get
            {
                return this.totalcost;
            }
        }


        public string RentRecipt()
        {
            string msg;

            msg = "Transaction No. : " + this.tranno + "\t" + "Rent Date : " + this.trandt + "\n";
            msg += "Company ID : " + this.comp.CompanyID + "\t" + "Company Name : " + this.comp.CompanyName + "\n";
            msg += "Vehicle Reg. No. : " + this.veh.VehRegNo + "\t" + "Vehicle Type : " + this.veh.VehType + "\t Vehicle Rate : " + this.veh.VehRate + "\n";
            msg += "No. of Days Rented : " + this.daysrented + "\n" + "Tentative Return Date : " + this.returndt + "\n";

            return msg;

        }

        public string ReturnRecipt()
        {
            string msg;

            msg = "Transaction No. : " + this.tranno + "\t" + "Rent Date : " + this.trandt + "\n";
            msg += "Company ID : " + this.comp.CompanyID + "\t" + "Company Name : " + this.comp.CompanyName + "\n";
            msg += "Vehicle Reg. No. : " + this.veh.VehRegNo + "\t" + "Vehicle Type : " + this.veh.VehType + "\t Vehicle Rate : " + this.veh.VehRate + "\n";
            msg += "No. of Days Rented : " + this.daysrented + "\n" + "Tentative Return Date : " + this.returndt + "\n";
            msg += "\n";
            msg += "Actual Return Date : " + this.actualreturndt + "\t" + "Actual Return Days : " + this.actualrentdays + "\n";
            msg += "Rent Amount " + this.rentamount.ToString("c2") + "\t" + "VAT Amount : " + this.vatamount.ToString("c2") + "\t" + "Total Rent Amount : " + this.totalrent.ToString("c2") + "\n";
            msg += "Damage Cost : " + this.damagecost.ToString("c2") + "\t" + "Total Amount  Payable : " + this.totalcost.ToString("c2") + "\n";

            return msg;

        }

        public string ToCSVString()
        {
            string msg;

            msg = this.tranno + "," + this.trandt + "," + this.comp.CompanyID + "," + this.veh.VehRegNo + "," +
                this.daysrented + "," + this.returndt + "," + this.actualreturndt + "," + this.actualrentdays +
                "," + this.rentamount + "," + this.vatamount + "," + this.totalrent + "," + this.damagecost + "," + this.totalcost;

            return msg;
        }
    }
}
