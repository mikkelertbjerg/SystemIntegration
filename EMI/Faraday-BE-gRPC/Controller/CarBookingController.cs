using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Faraday_BE_gRPC.Helpers;
using Faraday_BE_gRPC.Models;
using Grpc.Core;

namespace Faraday_BE_gRPC.Controller
{
    public class CarBookingController : ICarBooking
    {
        Facade facade;
        public CarBookingController()
        {
            facade = new Facade();
        }

        public void CancelCarBooking(int carBookingId)
        {
            throw new NotImplementedException();
        }

        public List<Car> ShowAvailableCars(Location location)
        {
            return facade.GetAvailableCars(location);
        }

        public void CreateCarBooking(CarBooking carBooking)
        {
            facade.CreateCarBooking(carBooking);
        }

        public List<CarBooking> GetCarBookings(string driversLicense)
        {
            throw new NotImplementedException();
        }

        public List<Models.Location> StartNewCarBooking()
        {
            return facade.GetAllLocations();
        }

        public void RegisterCar(Car car)
        {
            throw new NotImplementedException();
        }

        public void RegisterCustomer(Customer customer)
        {
            facade.CreateCustomer(customer);
        }

        public List<Car> RegisterPickup(Location location, DateTime time)
        {
            throw new NotImplementedException();
        }
    }
}