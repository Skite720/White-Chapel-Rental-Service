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
    public partial class AllRentedVehList : Form
    {

        private List<Vehicle> rentedlist = new List<Vehicle>();
        public AllRentedVehList()
        {
            InitializeComponent();
        }

        private void AllRentedVehList_Load(object sender, EventArgs e)
        {
            fillrentedlist();
            dataGridView1.DataSource = rentedlist;
        }

        public void fillrentedlist()
        {
            foreach(Vehicle veh in menumdi.Vehiclelist)
            {
                if(veh.IsRented == true || veh.IsReserved == true)
                {
                    rentedlist.Add(veh);
                }
            }
        }


        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
