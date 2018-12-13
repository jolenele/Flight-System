using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightSystem
{
    public partial class Form1 : Form
    {
        //SceneFlightManager sceneFlight = new SceneFlightManager();
        //SceneCustomerManger sceneCustomer = new SceneCustomerManger();
        //SceneBookingManager sceneBooking = new SceneBookingManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void SceneFlightManager_Click(object sender, EventArgs e)
        {
            Globals.sceneFlight.Tag = this;
            Globals.sceneFlight.StartPosition = FormStartPosition.Manual;
            Globals.sceneFlight.Location = this.Location;
            Globals.sceneFlight.Show(this);
            Hide();
        }

        private void SceneCustomerManager_Click(object sender, EventArgs e)
        {
            Globals.sceneCustomer.Tag = this;
            Globals.sceneCustomer.StartPosition = FormStartPosition.Manual;
            Globals.sceneCustomer.Location = this.Location;
            Globals.sceneCustomer.Show(this);
            Hide();
        }

        private void SceneBookingManager_Click(object sender, EventArgs e)
        {
            Globals.sceneBooking.Tag = this;
            Globals.sceneBooking.StartPosition = FormStartPosition.Manual;
            Globals.sceneBooking.Location = this.Location;
            Globals.sceneBooking.Show(this);
            Hide();
        }
    }
}
