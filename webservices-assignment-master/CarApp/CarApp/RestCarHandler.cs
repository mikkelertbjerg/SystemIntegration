using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    public static class RestCarHandler
    {

        public static List<Car> GetCars()
        {
            var url = "https://carservicecphbusiness2019.azurewebsites.net/api/Cars";
            var webrequest = (HttpWebRequest)System.Net.WebRequest.Create(url);
            List<Car> cars = new List<Car>();

            using (var response = webrequest.GetResponse())
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                var result = reader.ReadToEnd();
                cars = JsonConvert.DeserializeObject<List<Car>>(result);
            };

            return cars;
        }

        public static Car GetCar(string licensePlate)
        {

            var url = "https://carservicecphbusiness2019.azurewebsites.net/api/Cars";
            var webrequest = (HttpWebRequest)System.Net.WebRequest.Create(url);
            List<Car> cars = new List<Car>();

            using (var response = webrequest.GetResponse())
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                var result = reader.ReadToEnd();
                cars = JsonConvert.DeserializeObject<List<Car>>(result);
            };

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
