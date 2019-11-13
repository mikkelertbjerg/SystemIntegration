using System;
using System.Collections.Generic;
using System.Text;

namespace Faraday_BE_gRPC.Models
{
    public class Customer
    {

        public Customer(int id, string firstName, string  lastName, string gender, string driversLicense)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            DriversLicense = driversLicense;
        }

        public Customer( string firstName, string lastName, string gender, string driversLicense)
        {
            
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            DriversLicense = driversLicense;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string DriversLicense { get; set; }
    }
}
