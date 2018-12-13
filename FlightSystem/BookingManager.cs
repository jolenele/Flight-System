using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem
{
    class BookingManager
    {
        //private List<Booking> bookingList = new List<Booking>();
        private Dictionary<string, Booking> bookingList = new Dictionary<string, Booking>();
        //private static int currentBookNo;
        private int numBooking;
        private Flight bookingFlight;
        private Customer bookingCustomer;

        public BookingManager()
        {
            numBooking = 0;
        }

        public string generateCode()
        {
            char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWYZ0123456789".ToCharArray();
            Random random = new Random();
            string code = "";
            for (int i = 0; i < 6; i++)
            {
                code += chars[random.Next(6)].ToString();
            }
            return code;
        }


        public bool addBooking(FlightManager flightMan, CustomerManager customerMan, int flId, int cusId, string date)
        {

            bookingFlight = flightMan.getFlight(flId);
            bookingCustomer = customerMan.getCustomer(cusId);
            bookingFlight.addPassenger(bookingCustomer);
            if (flightMan.flightExist(flId) == false
                && customerMan.customerExist(cusId) == false
                && numBooking >= bookingFlight.getMassSeats()) return false;

            Booking b = new Booking(date, flId, cusId);
            string hashNumb;
            do
            {
                hashNumb = generateCode();

            } while (bookingList.ContainsKey(hashNumb));

            bookingList[hashNumb] = b;
            numBooking++;
            return true;

        }


        public string viewBooking()
        {
            string s = "";

            foreach (var b in bookingList)
            {
                s += "Ref #: \t" + b.Key + "\t\t" + b.Value.toString() + "\n";
            }
            return s;
        }
    }
}
