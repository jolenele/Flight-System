using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem
{
    class Customer
    {
        private int customerId;
        private string firstName;
        private string lastName;
        private string phone;

        public Customer(int id, string fn, string ln, string ph)
        {
            customerId = id;
            firstName = fn;
            lastName = ln;
            phone = ph;
        }

        public int getId()
        {
            return customerId;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public string getLastName()
        {
            return lastName;
        }

        public string getPhone()
        {
            return phone;
        }

        public string toString()
        {
            string s = "Customer ID: " + customerId + "\nFirst Name: " + firstName + "\nLast Name: " + lastName +
                       "\nPhone: " + phone;

            return s;
        }
    }
}
