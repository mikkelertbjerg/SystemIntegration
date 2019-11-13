using System;
using System.Collections.Generic;
using System.Text;

namespace Faraday_BE_gRPC.Models
{
    public class Car
    {

        public Car()
        {

        }

        public Car(int id, int doors, string fuelType, string type, string licensePlate, float price, bool animalsAllowed, int locationId, string brand, string model, string color, bool availability)
        {
            Id = id;
            Doors = doors;
            FuelType = fuelType;
            Type = type;
            LicensePlate = licensePlate;
            Price = price;
            AnimalsAllowed = animalsAllowed;
            Color = color;
            Brand = brand;
            Model = model;
            Availability = availability;
            LocationId = locationId;
        }
        public Car(int doors, string fuelType, string type, string licensePlate, float price, bool animalsAllowed, int locationId, string brand, string model, string color, bool availability)
        {
            Doors = doors;
            FuelType = fuelType;
            Type = type;
            LicensePlate = licensePlate;
            Price = price;
            AnimalsAllowed = animalsAllowed;
            Color = color;
            Brand = brand;
            Model = model;
            Availability = availability;
            LocationId = locationId;
        }


        public int Id { get; set; }
        public int Doors { get; set; }
        public string FuelType { get; set; }
        public string Type { get; set; }
        public string LicensePlate { get; set; }
        public float Price { get; set; }
        public int LocationId { get; set; }
        public bool AnimalsAllowed { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public bool Availability { get; set; }

    }
}
