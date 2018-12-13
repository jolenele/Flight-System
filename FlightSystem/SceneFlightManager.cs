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
    public partial class SceneFlightManager : Form
    {
        
        public SceneFlightManager()
        {
            InitializeComponent();
        }

        private void SceneCustomerManager_Click(object sender, EventArgs e)
        {
            Globals.sceneCustomer.Tag = this;
            Globals.sceneCustomer.StartPosition = FormStartPosition.Manual;
            Globals.sceneCustomer.Location = this.Location;
            Globals.sceneCustomer.Show();
            Hide();
        }

        private void SceneBookingManager_Click(object sender, EventArgs e)
        {
            Globals.sceneBooking.Tag = this;
            Globals.sceneBooking.StartPosition = FormStartPosition.Manual;
            Globals.sceneBooking.Location = this.Location;
            Globals.sceneBooking.Show();
            Hide();
        }
        //Check input
        public bool isNumeric(TextBox t)
        {
            int a;
            return int.TryParse(t.Text, out a);

        }
        private void btnFlightAdd_Click(object sender, EventArgs e)
        {
            if (!isNumeric(txtFlightNo) || !isNumeric(txtMaxSeat))
            {
                MessageBox.Show("Invalid input");
                txtMaxSeat.Clear();
                txtFlightNo.Clear();
            }
            else
            {
                int flightNo = Convert.ToInt32(txtFlightNo.Text);
                int max = Convert.ToInt32(txtMaxSeat.Text);
                if (Globals.airlineCoordinator.addFlight(flightNo, txtOrigin.Text, txtDestination.Text, max))
                {
                    MessageBox.Show("Add Flight Successfully");
                    Console.WriteLine("Add flight succesfully");
                    txtDestination.Clear();
                    txtFlightNo.Clear();
                    txtMaxSeat.Clear();
                    txtOrigin.Clear();
                }
                else
                {
                    MessageBox.Show("Add Flight failed");
                    Console.WriteLine("Add flight failed");
                }
            }
            rtxtFilghtDelete.Text = Globals.airlineCoordinator.flightList();
            rtxtFlightView.Text = Globals.airlineCoordinator.flightList();
        }
        private void btnFlightDelete_Click(object sender, EventArgs e)
        {
            if (!isNumeric(txtFlightDelete))
            {
                MessageBox.Show("Invalid input");
                txtFlightDelete.Clear();
            }
            else
            {
                int flightId = Convert.ToInt32(txtFlightDelete.Text);
                if (Globals.airlineCoordinator.deleteFlight(flightId))
                {
                    MessageBox.Show("Delete Flight Successfully");
                    Console.WriteLine("Delete flight succesfully");
                    txtFlightDelete.Clear();
                }
                else
                {
                    MessageBox.Show("Delete Flight failed");
                    Console.WriteLine("Delete flight failed");
                }
            }
            rtxtFilghtDelete.Text = Globals.airlineCoordinator.flightList();
            rtxtFlightView.Text = Globals.airlineCoordinator.flightList();
        }
        private void btnFlightCancelAdd_Click(object sender, EventArgs e)
        {
            txtDestination.Clear();
            txtFlightNo.Clear();
            txtMaxSeat.Clear();
            txtOrigin.Clear();
        }

        private void btnFlightCancelDelete_Click(object sender, EventArgs e)
        {
            txtFlightDelete.Clear();
        }

        private void btnFlightHome_Click(object sender, EventArgs e)
        {
            Globals.home.Tag = this;
            Globals.home.StartPosition = FormStartPosition.Manual;
            Globals.home.Location = this.Location;
            Globals.home.Show(this);
            Hide();
        }
        
    }
}
