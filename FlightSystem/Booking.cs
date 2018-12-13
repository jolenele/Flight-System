using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem
{
    class Booking
    {
        private string date;
        private int flightId;
        private int customerId;

        public Booking(string date, int fId, int cusId)
        {
            this.date = date;
            flightId = fId;
            customerId = cusId;
        }


        public string getDate()
        {
            return date;
        }

        public int getflightId()
        {
            return flightId;
        }

        public int getCustomerId()
        {
            return customerId;
        }

        public string toString()
        {
            return "Flight: " + getflightId() +
                   "\t\tCustomer: " + getCustomerId() + "\tDate: " + getDate();
        }
    }
}
