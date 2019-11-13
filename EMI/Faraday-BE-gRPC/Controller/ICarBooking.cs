using Faraday_BE_gRPC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faraday_BE_gRPC.Controller
{
    interface ICarBooking
{
        ///<summary>
        ///Contract C01
        ///Operation: MakeNewBooking()
        ///Cross References: Create Booking
        ///Preconditions:
        /// - none
        ///Postconditions:	
        ///- A booking instance b is created
        ///- Attributes of b were initialized
        ///- A list of places is returned
        ///</summary>
        ///<returns>Returns a list of places</returns>
        public List<Models.Location> StartNewCarBooking();


        ///<summary>
        /// Contract C02
        /// Operation: RegisterPickup(p: Place, t: DateTime)
        /// Cross References: Create Booking
        /// Preconditions: 
        ///	- A booking is underway
        /// Postconditions:
        ///	- A time and place has been selected
        /// - time and place is associated with b
        /// - A list of available cars is returned
        ///</summary>
        ///<returns>Returns a list of available cars, in the specific time window</returns>
        ///<param name="place">Name of the place where the pickup is supposed to happen</param>
        ///<param name="time">The time of which the pickup is supposed to happen</param>
        public List<Car> RegisterPickup(Location location, DateTime time);

        ///<summary>
        /// Contract C03
        /// Operation: RegisterCar(car: Car)
        /// Cross References: Create Booking
        /// Preconditions: 
        /// - A booking is underway
        /// - Time and place has been selected
        /// - Time and place has been associated with b
        /// Postconditions:	- car is associated with b
        ///</summary>
        ///<returns>Nothing</returns>
        ///<param name="car"></param>
        public void RegisterCar(Car car);

        ///<summary>
        /// Contract C04
        /// Operation: RegisterCustomer(cust: Customer)
        /// Cross References: Create Booking
        /// Preconditions: 
        /// - A booking is underway
        /// Postconditions:
        /// - Customer cust is registered
        /// - cust is associated with b
        ///</summary>
        ///<returns>Nothing</returns>
        ///<param name="customer"></param>
        public void RegisterCustomer(Customer customer);

        /// <summary>
        /// Contract C05
        /// Operation: CreateBooking(b: Booking)
        /// Cross References: Create Booking
        /// Preconditions: 
        /// - A booking is underway
        /// - C02
        /// - C03
        /// - C04
        /// Postconditions:
        /// - A summary of the booking is returned
        /// - b is persisted in the database
        /// </summary>
        /// <returns>Nothing</returns>
        /// <param name="booking">The booking object that is initialzed</param>
        public void CreateCarBooking(CarBooking carBooking);

        /// <summary>
        /// Contract C06
        /// Operation: getBookings(driversLicense: string)
        /// Cross References: Cancel Booking
        /// Preconditions:
        /// - Atleast one Booking b is associated with driversLicense
        /// Postconditions:
        /// - none
        /// </summary>
        /// <param name="driversLicense">The drivers license to identify the customers booking(s).</param>
        /// <returns>Returns a list of bookings associated with the driversLicense.</returns>
        public List<CarBooking> GetCarBookings(string driversLicense);

        /// <summary>
        /// Contract C07
        /// Operation: cancelBooking(bookingId: int)
        /// Cross References: Cancel Booking
        /// Preconditions:
        /// - C06
        /// - A booking has been slected
        /// Postconditions:
        /// - The selected booking has been marked as canceled
        /// - A summary of the action is returned
        /// </summary>
        /// <returns>Nothing</returns>
        /// <param name="bookingId">The unique Id for a booking</param>
        public void CancelCarBooking(int carBookingId);

        /// <summary>
        /// Operation: ShowAvailableCars(string place, DateTime time)
        /// Cross References: Show available cars
        /// Preconditions:
        /// - atleast one car exsists in the system
        /// Postconditions: None
        /// </summary>
        /// <returns>Returns a list of available cars.</returns>
        public List<Car> ShowAvailableCars(Location location);

    }
}
