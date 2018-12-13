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
    public partial class SceneCustomerManger : Form
    {

        public SceneCustomerManger()
        {
            InitializeComponent();
        }
        private void SceneBookingManager_Click(object sender, EventArgs e)
        {
            Globals.sceneBooking.Tag = this;
            Globals.sceneBooking.StartPosition = FormStartPosition.Manual;
            Globals.sceneBooking.Location = this.Location;
            Globals.sceneBooking.Show();
            Hide();
        }
        private void SceneFlightManager_Click(object sender, EventArgs e)
        {
            Globals.sceneFlight.Tag = this;
            Globals.sceneFlight.StartPosition = FormStartPosition.Manual;
            Globals.sceneFlight.Location = this.Location;
            Globals.sceneFlight.Show();
            Hide();
        }
        //Check input
        public bool isNumeric(TextBox t)
        {
            int a;
            return int.TryParse(t.Text, out a);

        }
        private void btnCustAdd_Click(object sender, EventArgs e)
        {

            if (Globals.airlineCoordinator.addCustomer(txtFirstName.Text, txtLastName.Text, txtPhone.Text))
            {
                MessageBox.Show("Add customer successfully");
                Console.WriteLine("Add customer successfully");
                txtFirstName.Clear();
                txtLastName.Clear();
                txtPhone.Clear();
            }
            else
            {
                MessageBox.Show("Adding customer failed");
            }
            rtxtCustDelete.Text = Globals.airlineCoordinator.customerList();
            rtxtCustomerView.Text = Globals.airlineCoordinator.customerList();
        }

        private void btnCustDelete_Click(object sender, EventArgs e)
        {
            if (!isNumeric(txtCustDelete))
            {
                MessageBox.Show("Invalid Id");
                txtCustDelete.Clear();
            }
            else
            {
                int customerId = Convert.ToInt32(txtCustDelete.Text);
                if (Globals.airlineCoordinator.deleteCustomer(customerId))
                {
                    MessageBox.Show("Delete customer successfully");
                    Console.WriteLine("Delete customer successfully");
                    txtCustDelete.Clear();
                }
                else
                {
                    MessageBox.Show("Delete failed");
                }
            }
            rtxtCustDelete.Text = Globals.airlineCoordinator.customerList();
            rtxtCustomerView.Text = Globals.airlineCoordinator.customerList();
        }

        private void btnCustCancelAdd_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
        }

        private void btnCustCancelDelete_Click(object sender, EventArgs e)
        {
            txtCustDelete.Clear();
        }

        private void btnCustomerHome_Click(object sender, EventArgs e)
        {
            Globals.home.Tag = this;
            Globals.home.StartPosition = FormStartPosition.Manual;
            Globals.home.Location = this.Location;
            Globals.home.Show(this);
            Hide();
        }
    }   
}
