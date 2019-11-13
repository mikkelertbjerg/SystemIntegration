using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using Faraday_BE_gRPC.Models;
using MySql.Data.MySqlClient;

namespace Faraday_BE_gRPC.Database
{
    public class DatabaseUtilities
    {

        public DatabaseUtilities()
        {

        }

        //Need to change "available" logic, so it check the dates.
        //Also should the current check be true/false or 1/0?
        public List<Car> GetAvailableCars(Location location)
        {
            using IDbConnection connection = new MySqlConnection(DatabaseConnection.GetConnectionString());
            return connection.Query<Car>($"SELECT * FROM Cars WHERE fk_location_Id = {location.Id} AND Available = 1;").ToList();
        }

        public List<Location> GetAllLocations()
        {
            using IDbConnection connection = new MySqlConnection(DatabaseConnection.GetConnectionString());
            return connection.Query<Location>("SELECT * FROM Locations;").ToList();
        }

        public void CreateCarBooking(CarBooking carBooking)
        {
            using IDbConnection connection = new MySqlConnection(DatabaseConnection.GetConnectionString());
            connection.Execute($"INSERT INTO Bookings" +
                               $" (fk_pick_up_location_id, fk_drop_off_location_id, fk_car_id, fk_customer_id, pick_up_time, drop_off_time) " +
                               $"VALUES ('{carBooking.PickUpLocation.Id}', '{carBooking.DropOffLocation.Id}', '{carBooking.Car.Id}', '{carBooking.Customer.Id}', '{carBooking.TimeOfDropOff}', '{carBooking.TimeOfPickUp}');");
        }

        public int CreateCustomer(Customer customer)
        {
            using IDbConnection connection = new MySqlConnection(DatabaseConnection.GetConnectionString());
            var affectedRows = connection.Execute($"INSERT INTO Customers (FirstName, LastName, Gender, DriversLicense) VALUES ('{customer.FirstName}', '{customer.LastName}', '{customer.Gender}', '{customer.DriversLicense}');");
            return affectedRows;
        }

        public void CreateInvoice(CarBooking booking)
        {
            //TBD
        }


    }
}
