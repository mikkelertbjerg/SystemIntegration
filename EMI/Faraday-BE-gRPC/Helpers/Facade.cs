using Faraday_BE_gRPC.Models;
using Faraday_BE_gRPC.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Faraday_BE_gRPC.Helpers
{
    public class Facade
    {
        DatabaseUtilities dbu;
        public Facade()
        {
            dbu = new DatabaseUtilities();
        }

        public List<Car> GetAvailableCars(Location location)
        {
            return dbu.GetAvailableCars(location);
        }

        public List<Location> GetAllLocations()
        {
            return dbu.GetAllLocations();
        }

        public void CreateCarBooking(CarBooking carBooking)
        {
            dbu.CreateCarBooking(carBooking);
        }

        public void CreateCustomer(Customer customer)
        {
            dbu.CreateCustomer(customer);
        }
    }
}
