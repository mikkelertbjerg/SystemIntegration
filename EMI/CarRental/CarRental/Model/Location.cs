using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Model
{
    class Location
    {
        #region Instance fields
        private string _address;
        private string _zipcode;
        private string _city;
        private string _country;
        #endregion
        #region Constructor
        public Location(string address, string zipcode, string city, string country)
        {
            _address = address;
            _zipcode = zipcode;
            _city = city;
            _country = country;
        }
        #endregion
        #region Properties
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string Zipcode
        {
            get { return _zipcode; }
            set { _zipcode = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
        #endregion

    }
}
