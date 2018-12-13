using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem
{
    class Flight
    {
        private int flightNumber;
        private string origin;
        private string destination;
        private int massSeats;
        private int numPassengers;
        private Customer[] ctmList;

        public Flight(int flNo, string or, string det, int mSeats)
        {
            flightNumber = flNo;
            origin = or;
            destination = det;
            massSeats = mSeats;
            numPassengers = 0;
            ctmList = new Customer[mSeats];
        }

        public int getFlightNo()
        {
            return flightNumber;
        }

        public string getOrigin()
        {
            return origin;
        }

        public string getDestinstion()
        {
            return destination;
        }

        public int getMassSeats()
        {
            return massSeats;
        }

        public bool addPassenger(Customer cust)
        {
            if (numPassengers >= massSeats) return false;
            //Customer cust = new Customer(id, fn, ln, ph);
            ctmList[numPassengers] = cust;
            numPassengers++;
            return true;
        }

        public int findPassenger(int custId)
        {
            for (int i = 0; i < numPassengers; i++)
            {
                if (custId == ctmList[i].getId())
                    return i;
            }

            return -1;
        }

        public bool removePassenger(int custId)
        {
            int pos = findPassenger(custId);
            if (pos == -1) return false;
            ctmList[pos] = ctmList[numPassengers - 1];
            numPassengers--;
            return true;
        }

        public string getPassengerList()
        {
            string pList = "Flight Number" + "\tOrigin" + "\tDestination" + "\tMass Seats";
            pList = getFlightNo() + "\t" + getOrigin() +
                      "\t" + getDestinstion() + "\t" + getMassSeats();

            for (var i = 0; i < massSeats; i++)
            {
                pList += (ctmList[i].getId() + "\t" + ctmList[i].getFirstName() +
                           "\t" + ctmList[i].getLastName() + "\t" + ctmList[i].getPhone());
            }

            return pList;

        }
        public string toString()
        {
            string s = "Flight Number: " + flightNumber;
            s = s + "\nOrigin: " + origin;
            s = s + "\nDestination:" + destination;
            s = s + "\nNumber of Passengers:" + numPassengers;
            s = s + "\nAvailable seats:" + (massSeats - numPassengers);
            s = s + getPassengerList();
            return s;
        }
    }
}
