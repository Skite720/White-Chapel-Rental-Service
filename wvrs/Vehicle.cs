using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wvrs
{
    public enum VehicleType { Car, Bike, MiniBus9, MiniBus15, MiniBus20, VanSmall, VanBig };

    public enum FuelType { Petrol, Diesel, Electric, Hybrid };

    public enum GearType { Automatic, SemiAutomatic, Manual };

    class Vehicle
    {
        private string vehregno;
        private VehicleType vehtype;
        private string enginesize;
        private string vehcolor;
        private string vehmodel;
        private string vehmake;
        private double vehmileage;
        private FuelType vehfueltype;
        private GearType vehgearbox;
        private int vehnodoors;
        private string vehservicehist;
        private string vehsafetyinfo;
        private double vehlength;
        private double vehwidth;
        private double vehheight;
        private int vehrate;

        private bool isrented;
        private bool isreserved;
        public Vehicle(string vehregno, VehicleType vehtype, string enginesize, string vehcolor, string vehmodel, 
            string vehmake, double vehmileage, FuelType vehfueltype, GearType vehgearbox, int vehnodoors, 
            string vehservicehist, string vehsafetyinfo, double vehlength, double vehwidth, double vehheight, bool isrented = false, bool isreserved = false)
        {
            this.vehregno = vehregno;
            this.vehtype = vehtype;
            this.enginesize = enginesize;
            this.vehcolor = vehcolor;
            this.vehmodel = vehmodel;
            this.vehmake = vehmake;
            this.vehmileage = vehmileage;
            this.vehfueltype = vehfueltype;
            this.vehgearbox = vehgearbox;
            this.vehnodoors = vehnodoors;
            this.vehservicehist = vehservicehist;
            this.vehsafetyinfo = vehsafetyinfo;
            this.vehlength = vehlength;
            this.vehwidth = vehwidth;
            this.vehheight = vehheight;
            this.isrented = isrented;
            this.isreserved = isreserved;

            if(this.vehtype == VehicleType.Car && (this.vehgearbox == GearType.Automatic || this.vehgearbox == GearType.SemiAutomatic))
            {
                this.vehrate = 75;
            }
            else if(this.vehtype == VehicleType.Car && this.vehgearbox == GearType.Manual)
            {
                this.vehrate = 50;
            }
            else if(this.vehtype == VehicleType.Bike)
            {
                this.vehrate = 50;
            }
            else if(this.vehtype == VehicleType.MiniBus9 && (this.vehgearbox == GearType.Automatic || this.vehgearbox == GearType.SemiAutomatic))
            {
                this.vehrate = 100;
            }
            else if(this.vehtype == VehicleType.MiniBus9 && this.vehgearbox == GearType.Manual)
            {
                this.vehrate = 75;
            }
            else if(this.vehtype == VehicleType.MiniBus15 && (this.vehgearbox == GearType.Automatic || this.vehgearbox == GearType.SemiAutomatic))
            {
                this.vehrate = 175;
            }
            else if(this.vehtype == VehicleType.MiniBus15 && this.vehgearbox == GearType.Manual)
            {
                this.vehrate = 125;
            }
            else if(this.vehtype == VehicleType.MiniBus20 && (this.vehgearbox == GearType.Automatic || this.vehgearbox == GearType.SemiAutomatic))
            {
                this.vehrate = 250;
            }
            else if(this.vehtype == VehicleType.MiniBus20 && this.vehgearbox == GearType.Manual)
            {
                this.vehrate = 200;
            }
            else if(this.vehtype == VehicleType.VanSmall && (this.vehgearbox == GearType.Automatic || this.vehgearbox == GearType.SemiAutomatic))
            {
                this.vehrate = 100;
            }
            else if(this.vehtype == VehicleType.VanSmall && this.vehgearbox == GearType.Manual)
            {
                this.vehrate = 95;
            }
            else if(this.vehtype == VehicleType.VanBig && (this.vehgearbox == GearType.Automatic || this.vehgearbox == GearType.SemiAutomatic))
            {
                this.vehrate = 175;
            }
            else if(this.vehtype == VehicleType.VanBig && this.vehgearbox == GearType.Manual)
            {
                this.vehrate = 125;
            }
        }

        public string VehRegNo
        {
            get
            {
                return this.vehregno;
            }
            set
            {
                this.vehregno = value;
            }
        }

        public VehicleType VehType
        {
            get
            {
                return this.vehtype;
            }
            set
            {
                this.vehtype = value;
            }
        }

        public string EngineSize
        {
            get
            {
                return this.enginesize;
            }
            set
            {
                this.enginesize = value;
            }
        }

        public string VehColor
        {
            get
            {
                return this.vehcolor;
            }
            set
            {
                this.vehcolor = value;
            }
        }

        public string VehModel
        {
            get
            {
                return this.vehmodel;
            }
            set
            {
                this.vehmodel = value;
            }
        }

        public string VehMake
        {
            get
            {
                return this.vehmake;
            }
            set
            {
                this.vehmake = value;
            }
        }

        public double VehMileage
        {
            get
            {
                return this.vehmileage;
            }
            set
            {
                this.vehmileage = value;
            }
        }

        public FuelType VehFuelType
        {
            get
            {
                return this.vehfueltype;
            }
            set
            {
                this.vehfueltype = value;
            }
        }

        public GearType VehGearBox
        {
            get
            {
                return this.vehgearbox;
            }
            set
            {
                this.vehgearbox = value;
            }
        }

        public int VehNoDoors
        {
            get
            {
                return this.vehnodoors;
            }
            set
            {
                this.vehnodoors = value;
            }
        }

        public string VehServiceHist
        {
            get
            {
                return this.vehservicehist;
            }
            set
            {
                this.vehservicehist = value;
            }
        }

        public string VehSafetyInfo
        {
            get
            {
                return this.vehsafetyinfo;
            }
            set
            {
                this.vehsafetyinfo = value;
            }
        }

        public double VehLength
        {
            get
            {
                return this.vehlength;
            }
            set
            {
                this.vehlength = value;
            }
        }

        public double VehWidth
        {
            get
            {
                return this.vehwidth;
            }
            set
            {
                this.vehwidth = value;
            }
        }

        public double VehHeight
        {
            get
            {
                return this.vehheight;
            }
            set
            {
                this.vehheight = value;
            }
        }

        public int VehRate
        {
            get
            {
                return this.vehrate;
            }
        }

        public bool IsRented
        {
            get
            {
                return this.isrented;
            }
            set
            {
                this.isrented = value;
            }
        }

        public bool IsReserved
        {
            get
            {
                return this.isreserved;
            }
            set
            {
                this.isreserved = value;
            }
        }

        public string ToCSVString()
        {
            string msg;

            msg = this.vehregno + "," + this.vehtype.ToString() + "," + this.enginesize + "," + this.vehcolor +
                "," + this.vehmodel + "," + this.vehmake + "," + this.vehmileage + "," + this.vehfueltype + "," +
                this.vehgearbox.ToString() + "," + this.vehnodoors + "," + this.vehservicehist + "," +
                this.vehsafetyinfo + "," + this.vehlength + "," + this.vehwidth + "," + this.vehheight + "," +
                this.vehrate.ToString() + "," + this.isrented + "," + this.isreserved;

            return msg;

        }
    }
}
