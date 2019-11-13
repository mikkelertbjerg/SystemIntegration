using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Faraday_BE_gRPC.Helpers;
using Faraday_BE_gRPC.Models;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace Faraday_BE_gRPC
{
    public class BookingService : Booking.BookingBase
    {
        Facade DbFacade = new Facade();


        public override async Task MakeNewBookingGRPC(EmptyRequest request, IServerStreamWriter<LocationRequest> responseStream, ServerCallContext context)
        {
            // lav facade kald her og gør det lig locations istedet
            List<LocationRequest> locationRequests = new List<LocationRequest>();
            List<Location> locations = DbFacade.GetAllLocations();

            foreach (var l in locations)
            {
                LocationRequest a = new LocationRequest()
                {
                    Address = l.Address,
                    City = l.City,
                    Country = l.Country,
                    Id = l.Id,
                    Zipcode = l.Zipcode
                };
                
                locationRequests.Add(a);
            }

            foreach (var location in locationRequests)
            {
                // this sends our CarReply class to the client one at a time, until there are no more
                // essentially making this method of type void, as opposed to the previous method that returns a type.

                await responseStream.WriteAsync(location);
            }
        }

        public override Task<ComfirmReply> CreateCarBookingGRPC(BookingRequest request, ServerCallContext context)
        {
            MomService mom = new MomService();

            CarBooking carBooking = new CarBooking(new Location(request.PickUpadress,request.PickUpcity,request.PickUpzipcode,request.PickUpcountry),
                new Location(request.Dropoffadress,request.Dropoffcity,request.Dropoffzipcode,request.Dropoffcountry),
                new Car(request.Doors,request.Fueltype,request.Type,request.DriversLicense,request.Price,request.Animals,request.CarLocationId,request.Brand,request.Model,request.Color,request.CarAvailablity),
                new Customer(request.Name,request.LastName,request.Gender,request.DriversLicense),
                new DateTime(request.PickupYear,request.PickUpMonth,request.PickUpDay,request.PickUpHour,request.PickUpMinute,00),
                new DateTime(request.DropoffYear,request.DropoffMonth,request.DropoffDay,request.DropoffHour,request.DropoffMinute,00));
            mom.SendOrderMessage(carBooking);

            // kører db face execute here. return om det gik godt eller ej.
            DbFacade.CreateCarBooking(carBooking);
            return base.CreateCarBookingGRPC(request, context);
        }

        public override Task<ComfirmReply> RegisterCustomerGRPC(CustomerRequest request, ServerCallContext context)
        {
             DbFacade.CreateCustomer(new Customer(request.FirstName,request.LastName,request.Gender,request.DriversLicense));
             ComfirmReply c = new ComfirmReply();
             // for now we presume everything goes ok.
             c.Confirm = true;
             return Task.FromResult(c);
        }

        public override async Task ShowAvailableCarsGRPC(LocationRequest request, IServerStreamWriter<CarReply> responseStream, ServerCallContext context)
        {
            // facade kald til alle cars på en given location istedet
            Location l = new Location(request.Id,request.Address,request.City,request.Zipcode,request.Country);
            List<Car> cars = DbFacade.GetAvailableCars(l);
            List<CarReply> carReplies = new List<CarReply>();

            foreach (var car in cars)
            {
                CarReply c = new CarReply()
                {
                    AnimalsAllowed = car.AnimalsAllowed,
                    Brand = car.Brand,
                    CarId = car.Id,
                    Color = car.Color,
                    Doors = car.Doors,
                    FuelType = car.FuelType,
                    LicensePlate = car.LicensePlate,
                    Model = car.Model,
                    Price = car.Price,
                    Type = car.Type
                };
                carReplies.Add(c);
            }
            foreach (var car in carReplies)
            {
                // this sends our CarReply class to the client one at a time, until there are no more
                // essentially making this method of type void, as opposed to the previous method that returns a type.
                await responseStream.WriteAsync(car);
            }
        }
    }
}