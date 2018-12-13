using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem
{
    class CustomerManager
    {
        private static int currentCustNo;
        private int maxCustomers;
        private int numCustomers;
        private Customer[] custList;

        public CustomerManager(int seed, int maxCust)
        {
            maxCustomers = maxCust;
            currentCustNo = seed;
            numCustomers = 0;
            custList = new Customer[maxCust];
        }
        public bool addCustomer(string fn, string ln, string ph)
        {
            if (numCustomers >= maxCustomers) return false;
            Customer a = new Customer(currentCustNo, fn, ln, ph);
            currentCustNo++;
            custList[numCustomers] = a;
            numCustomers++;
            return true;
        }

        private int findCustomer(int cid)
        {
            for (int i = 0; i < numCustomers; i++)
            {
                if (cid == custList[i].getId())
                    return i;
            }

            return -1;
        }

        public bool customerExist(int cid)
        {
            int pos = findCustomer(cid);
            if (pos == -1) return false;
            return true;
        }
        public Customer getCustomer(int cid)
        {
            int pos = findCustomer(cid);
            if (pos == -1)
            {
                return null;
            }

            return custList[pos];
        }

        public bool deleteCustomer(int cid)
        {
            int pos = findCustomer(cid);
            if (pos == -1) return false;
            custList[pos] = custList[numCustomers - 1];
            numCustomers--;
            return true;
        }

        public string getCustomerList()
        {
            string cList = "ID" + "\tFirst Name" + "\tLast Name" + "\tPhone" + "\n";
            for (var i = 0; i < numCustomers; i++)
            {
                cList += (custList[i].getId() + "\t" + custList[i].getFirstName() +
                          "\t\t" + custList[i].getLastName() + "\t\t" + custList[i].getPhone() + "\n");

            }
            return cList;
        }
    }
}
