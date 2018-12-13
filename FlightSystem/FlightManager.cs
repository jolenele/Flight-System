using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem
{
    class FlightManager
    {
        private int maxFlights;
        private int numFlights;
        private Flight[] flightList;

        public FlightManager(int maxFlt)
        {
            maxFlights = maxFlt;
            numFlights = 0;
            flightList = new Flight[maxFlt];
        }

        public bool addFlight(int flNo, string or, string de, int mS)
        {
            if (numFlights >= maxFlights) return false;
            Flight flt = new Flight(flNo, or, de, mS);
            flightList[numFlights] = flt;
            numFlights++;
            return true;
        }

        private int findFlight(int flightNo)
        {
            for (int i = 0; i < numFlights; i++)
            {
                if (flightList[i].getFlightNo() == flightNo)
                    return i;

            }

            return -1;
        }

        public bool flightExist(int flightNo)
        {
            int pos = findFlight(flightNo);
            if (pos == -1) return false;
            return true;
        }
        public Flight getFlight(int flightNo)
        {
            int pos = findFlight(flightNo);
            if (pos == -1) return null;
            return flightList[pos];
        }

        public bool deleteFlight(int flightNo)
        {
            int pos = findFlight(flightNo);
            if (pos == -1) return false;
            flightList[pos] = flightList[numFlights - 1];
            numFlights--;
            return true;
        }

        public string getFlightList()
        {
            string fList = "Flight List: \n";
            for (var i = 0; i < numFlights; i++)
            {
                fList += flightList[i].getFlightNo() + "\t from \t" + flightList[i].getOrigin() + "\t to \t" +
                         flightList[i].getDestinstion() + "\n";

            }
            return fList;
        }
    }
}
