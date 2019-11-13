using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Faraday_BE_gRPC.Database;
using Faraday_BE_gRPC.Helpers;
using Faraday_BE_gRPC.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Faraday_BE_gRPC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();
            Console.WriteLine("What is this?");
            Facade  fac = new Facade();

            List<Location> listOfLocations = fac.GetAllLocations();
            List<Car> listOfAvailableCars = fac.GetAvailableCars(listOfLocations[0]);
            Customer customer = new Customer("Johnny", "Jensen", "Male", "DK-1345784987");

            Console.WriteLine("List of Locations:");
            foreach (var location in listOfLocations)
            {
                Console.WriteLine($"{location.Address}, {location.City}, {location.Zipcode}, {location.Country}");
            }
            Console.WriteLine();
            Console.WriteLine($"List of Available Cars at {listOfLocations[0].Address},{listOfLocations[0].City},{listOfLocations[0].Zipcode},{listOfLocations[0].Country}");
            foreach (var car in listOfAvailableCars)
            {
                Console.WriteLine($"{car.Brand} {car.Model}, {car.Color}, {car.Doors} doors");
            }



            Console.ReadLine();
        }

        // Additional configuration is required to successfully run gRPC on macOS.
        // For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
