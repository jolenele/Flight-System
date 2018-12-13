using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem
{
    class AirlineCoordinator
    {
        private FlightManager flightMan;
        private CustomerManager customerMan;
        private BookingManager bookingMan;

        public AirlineCoordinator(int cSeed, int maxCust, int maxFl)
        {
            flightMan = new FlightManager(maxFl);
            customerMan = new CustomerManager(cSeed, maxCust);
            bookingMan = new BookingManager();

        }

        public FlightManager getFlightManager()
        {
            return flightMan;

        }

        public CustomerManager getCustomerManager()
        {
            return customerMan;
        }



        public bool addFlight(int flNo, string orig, string dest, int mSeats)
        {
            return flightMan.addFlight(flNo, orig, dest, mSeats);

        }

        public bool addCustomer(string cfName, string lName, string phone)
        {
            return customerMan.addCustomer(cfName, lName, phone);

        }
        public string flightList()
        {
            return flightMan.getFlightList();
        }

        public string customerList()
        {
            return customerMan.getCustomerList();
        }


        public bool deleteCustomer(int cid)
        {
            return customerMan.deleteCustomer(cid);
        }

        public bool deleteFlight(int flightNo)
        {
            return flightMan.deleteFlight(flightNo);
        }
    }
}
