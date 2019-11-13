using System;
using System.Collections.Generic;
using System.Text;

namespace Faraday_BE_gRPC.Models
{
    public class CarBooking
    {
        public CarBooking(int id, Location pickUpLocation, Location dropOffLocation, Car car, Customer customer, DateTime timeOfPickUp, DateTime timeOfDropOff)
        {
            Id = id;
            PickUpLocation = pickUpLocation;
            DropOffLocation = dropOffLocation;
            Car = car;
            Customer = customer;
            TimeOfPickUp = timeOfPickUp;
            TimeOfDropOff = timeOfDropOff;
        }
public CarBooking(Location pickUpLocation, Location dropOffLocation, Car car, Customer customer, DateTime timeOfPickUp, DateTime timeOfDropOff)
        {
            PickUpLocation = pickUpLocation;
            DropOffLocation = dropOffLocation;
            Car = car;
            Customer = customer;
            TimeOfPickUp = timeOfPickUp;
            TimeOfDropOff = timeOfDropOff;
        }

        public int Id { get; set; }
        public Location PickUpLocation { get; set; }
        public Location DropOffLocation { get; set; }
        public Car Car { get; set; }
        public Customer Customer { get; set; }
        public DateTime TimeOfPickUp { get; set; }
        public DateTime TimeOfDropOff { get; set; }

        public override string ToString()
        {
            return $"{Customer.FirstName} {Customer.LastName} {Customer.DriversLicense} {Customer.Gender} {Car.Color} {Car.Brand} {Car.Model} {Car.Doors} {Car.FuelType} {Car.Type} {Car.Price} {Car.AnimalsAllowed} {PickUpLocation} {DropOffLocation}";
        }
    }
}
