using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wvrs
{
    class user
    {
        private string firstname;
        private string lastname;
        private string address;
        private string username;
        private string password;
        private string mobileno;
        private string email;

        public user(string firstname, string lastname, string address, string username, string password, string mobileno, string email)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.username = username;
            this.password = password;
            this.mobileno = mobileno;
            this.email = email;
        }

        public string FirstName
        {
            get
            {
                return this.firstname;
            }
            set
            {
                this.firstname = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastname;
            }
            set
            {
                this.lastname = value;
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

        public string UserName
        {
            get
            {
                return this.username;
            }
            set
            {
                this.username = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }

        public string Mobileno
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

        public string EmailAddress
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

        public string ToCSVString()
        {
            return this.firstname + "," + this.lastname + "," + this.address + "," + this.username + "," + this.password + "," + this.mobileno + "," + this.email;
        }

        public override string ToString()
        {
            string msg;

            msg  = "First Name : " + this.firstname + "\t" + "Last Name : " + this.lastname + "\n";
            msg += "Address    : " + this.address + "\n";
            msg += "User Name  : " + this.username + "\t" + "Password  : " + this.password + "\n";
            msg += "Mobile No. : " + this.mobileno + "\t" + "Email     : " + this.email + "\n";
            return msg;
        }
    }
}
