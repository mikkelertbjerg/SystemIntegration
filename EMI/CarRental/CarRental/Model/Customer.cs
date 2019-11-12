using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Model
{
    class Customer
    {
        private int _customerId;
        private string _name;
        private string _driversLicense;
        

        public Customer(string id, string name, string driversLicense)
        {
            _name = name;
            _driversLicense = driversLicense;
        }

        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }
        public string DriversLicense 
        { 
            get { return _driversLicense; }
            set { _driversLicense = value; }
        }
    }
}
