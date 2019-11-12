using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Model
{
    class Booking
    {
        private int _bookingNo;

        public Booking(Location pickupLocation, Location dropoffLocation, Car car, Customer customer, DateTime time)
        {

        }

        public int BookingNo
        {
            get { return _bookingNo; }
        }

    }
}
