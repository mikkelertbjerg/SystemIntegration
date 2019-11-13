using System;
using System.Collections.Generic;
using System.Text;

namespace Faraday_BE_gRPC.Models
{
    public class Location
    {

        public Location()
        {

        }

        public Location(int id, string address, string city, string zipcode, string country)
        {
            Id = id;
            Address = address;
            Zipcode = zipcode;
            City = city;
            Country = country;
        }
        public Location( string address, string city, string zipcode, string country)
        {
           
            Address = address;
            Zipcode = zipcode;
            City = city;
            Country = country;
        }
        public int Id { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

    }
}
