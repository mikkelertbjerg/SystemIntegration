using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using CarApp.ServiceReference1;

namespace CarApp
{
    public static class SoapCarHandler
    {
        private static ServiceReference1.IService1 carService;



        static SoapCarHandler()
        {
            carService = new Service1Client("BasicHttpsBinding_IService1");
        }

        public static List<Car> GetCars()
        {
            List<Car> cars = new List<Car>();

            var soapCars = carService.GetCars();

            foreach (var car in soapCars)
            {
                CarType type = (CarType) car.Type;
                cars.Add(new Car(car.LicensePlate, type));
            }

            return cars;
        }

        public static Car GetCar(string licensePlate)
        {
            List<Car> cars = new List<Car>();

            var soapCars = carService.GetCars();

            foreach (var car in soapCars)
            {
                CarType type = (CarType)car.Type;
                cars.Add(new Car(car.LicensePlate, type));
            }


            Car foundCar = cars.Find(x => x.LicensePlate == licensePlate);

            if (foundCar != null)
            {
                return foundCar;
            }
            else
            {
                return new Car("N/A", CarType.F);
            }
        }
    }
}
