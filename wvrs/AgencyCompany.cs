using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wvrs
{
    class AgencyCompany
    {
        private string companyid;
        private string companyname;
        private string companyaddress;
        private string contactname;
        private string contactaddress;
        private string contactmobileno;
        private string contactemail;

        public AgencyCompany(string companyid, string companyname, string companyaddress, string contactname, string contactaddress, string contactmobileno, string contactemail)
        {
            this.companyid = companyid;
            this.companyname = companyname;
            this.companyaddress = companyaddress;
            this.contactname = contactname;
            this.contactaddress = contactaddress;
            this.contactmobileno = contactmobileno;
            this.contactemail = contactemail;
        }


        public string CompanyID
        {
            get
            {
                return this.companyid;
            }
            set
            {
                this.companyid = value;
            }
        }

        public string CompanyName
        {
            get
            {
                return this.companyname;
            }
            set
            {
                this.companyname = value;
            }
        }

        public string CompanyAddress
        {
            get
            {
                return this.companyaddress;
            }
            set
            {
                this.companyaddress = value;
            }
        }

        public string ContactName
        {
            get
            {
                return this.contactname;
            }
            set
            {
                this.contactname = value;
            }
        }

        public string ContactAddress
        {
            get
            {
                return this.contactaddress;
            }
            set
            {
                this.contactaddress = value;
            }
        }

        public string ContactMobileNo
        {
            get
            {
                return this.contactmobileno;
            }
            set
            {
                this.contactmobileno = value;
            }
        }

        public string ContactEmail
        {
            get
            {
                return this.contactemail;
            }
            set
            {
                this.contactemail = value;
            }
        }

        public string ToCSVString()
        {
            string msg;

            msg = this.companyid + "," + this.companyname + "," + this.companyaddress + "," + this.contactname +
                "," + this.contactaddress + "," + this.contactmobileno + "," + this.contactemail;

            return msg;
        }
    }
}
