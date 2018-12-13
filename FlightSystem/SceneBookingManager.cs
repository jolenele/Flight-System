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
    public partial class SceneBookingManager : Form
    {
        public SceneBookingManager()
        {
            InitializeComponent();
            rtxtCustView.Text = Globals.airlineCoordinator.customerList();
            rtxtFlightView.Text = Globals.airlineCoordinator.flightList();
        }

        private void SceneFlightManager_Click(object sender, EventArgs e)
        {
            Globals.sceneFlight.Tag = this;
            Globals.sceneFlight.StartPosition = FormStartPosition.Manual;
            Globals.sceneFlight.Location = this.Location;
            Globals.sceneFlight.Show();
            Hide();
        }

        private void SceneCustomerManager_Click(object sender, EventArgs e)
        {
            Globals.sceneCustomer.Tag = this;
            Globals.sceneCustomer.StartPosition = FormStartPosition.Manual;
            Globals.sceneCustomer.Location = this.Location;
            Globals.sceneCustomer.Show();
            Hide();
        }
        //Check input
        public bool isNumeric(TextBox t)
        {
            int a;
            return int.TryParse(t.Text, out a);

        }
        private void btnBookAdd_Click(object sender, EventArgs e)
        {   
            if (!isNumeric(txtCustNo) || !isNumeric(txtFlightNo)){
                MessageBox.Show("Invalid values");
                txtCustNo.Clear();
                txtFlightNo.Clear();
            }
            else {
                int flId = Convert.ToInt32(txtFlightNo.Text);
                int custId = Convert.ToInt32(txtCustNo.Text);
                if (Globals.bookingMan.addBooking(Globals.airlineCoordinator.getFlightManager(), Globals.airlineCoordinator.getCustomerManager(), flId, custId, txtDate.Text))
                {
                    MessageBox.Show("Add Booking successfully");
                    Console.WriteLine("Add booking succesfully");
                    txtDate.Clear();
                    txtCustNo.Clear();
                    txtFlightNo.Clear();
                }
                else
                {
                    MessageBox.Show("Add Booking failed");
                    Console.WriteLine("Add booking failed");
                }
            }
            rtxtBookView.Text = Globals.bookingMan.viewBooking();
        }
        private void btnBookCancelAdd_Click(object sender, EventArgs e)
        {
            txtDate.Clear();
            txtCustNo.Clear();
            txtFlightNo.Clear();
        }

        private void btnBookingHome_Click(object sender, EventArgs e)
        {
            Globals.home.Tag = this;
            Globals.home.StartPosition = FormStartPosition.Manual;
            Globals.home.Location = this.Location;
            Globals.home.Show(this);
            Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            rtxtCustView.Text = Globals.airlineCoordinator.customerList();
            rtxtFlightView.Text = Globals.airlineCoordinator.flightList();
            rtxtBookView.Text = Globals.bookingMan.viewBooking();
        }
    }
}
