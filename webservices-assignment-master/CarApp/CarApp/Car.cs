using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    public enum CarType
    {
        A, B, C, D, E, F
    }
    public class Car
    {
        public Car(string licensePlate, CarType type)
        {
            LicensePlate = licensePlate;
            Type = type;
        }

        public string LicensePlate { get; set; }
        public CarType Type { get; set; }
    }
}
