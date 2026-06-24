using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wvrs
{
    class TouristCust
    {
        private string custid;
        private string fullname;
        private string drivinglicence;
        private string birthdate;
        private string address;
        private string mobileno;
        private string email;
        private string emergencyaddress;
        private string emergencymobileno;

        public TouristCust(string custid, string fullname, string drivinglicence, string birthdate, string address, string mobileno, string email, string emergencyaddress, string emergencymobileno)
        {
            this.custid = custid;
            this.fullname = fullname;
            this.drivinglicence = drivinglicence;
            this.birthdate = birthdate;
            this.address = address;
            this.mobileno = mobileno;
            this.email = email;
            this.emergencyaddress = emergencyaddress;
            this.emergencymobileno = emergencymobileno;
        }

        public string CustID
        {
            get
            {
                return this.custid;
            }
            set
            {
                this.custid = value;
            }
        }

        public string FullName
        {
            get
            {
                return this.fullname;
            }
            set
            {
                this.fullname = value;
            }
        }

        public string DrivingLicence
        {
            get
            {
                return this.drivinglicence;
            }
            set
            {
                this.drivinglicence = value;
            }
        }

        public string BirthDate
        {
            get
            {
                return this.birthdate;
            }
            set
            {
                this.birthdate = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }

        public string MobileNo
        {
            get
            {
                return this.mobileno;
            }
            set
            {
                this.mobileno = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public string EmergencyAddress
        {
            get
            {
                return this.emergencyaddress;
            }
            set
            {
                this.emergencyaddress = value;
            }
        }

        public string EmergencyMobileNo
        {
            get
            {
                return this.emergencymobileno;
            }
            set
            {
                this.emergencymobileno = value;
            }
        }

        public string ToCSVString()
        {
            string msg;

            msg = this.custid + "," + this.fullname + "," + this.drivinglicence + "," + this.birthdate + "," +
                this.address + "," + this.mobileno + "," + this.email + "," + this.emergencyaddress + "," + this.emergencymobileno;

            return msg;
        }
    }
}
