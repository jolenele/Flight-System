using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightSystem
{
    class Globals
    {
        public static AirlineCoordinator airlineCoordinator = new AirlineCoordinator(1, 1000, 1000);
        public static BookingManager bookingMan = new BookingManager();
        public static SceneFlightManager sceneFlight = new SceneFlightManager();
        public static SceneCustomerManger sceneCustomer = new SceneCustomerManger();
        public static SceneBookingManager sceneBooking = new SceneBookingManager();
        public static Form1 home = new Form1();
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
