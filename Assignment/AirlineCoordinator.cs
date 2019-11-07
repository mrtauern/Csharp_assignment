using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class AirlineCoordinator
    {
        FlightManager flManager;

        CustomerManager custManager;





        public AirlineCoordinator(int custIdSeed, int maxCust, int maxFlights)

        {

            flManager = new FlightManager(maxFlights);

            custManager = new CustomerManager(custIdSeed, maxCust);

        }



        public bool addFlight(int flightNo, string origin, string destination, int maxSeats)

        {

            return flManager.addFlight(flightNo, origin, destination, maxSeats);

        }



        public bool addCustomer(string fname, string lname, string phone)

        {

            return custManager.addCustomer(fname, lname, phone);

        }



        public string flightList()

        {

            return flManager.getFlightList();

        }



        public string customerList()

        {

            return custManager.getCustomerList();

        }



        public bool deleteCustomer(int id)

        {

            return custManager.deleteCustomer(id);

        }



        public bool deleteFlight(int fid)

        {

            return flManager.deleteFlight(fid);

        }
    }
}
