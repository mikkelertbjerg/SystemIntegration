using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTfulService.Models;

namespace RESTfulService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private List<Car> carList = new List<Car>()
        {
            new Car("AQ20381", CarType.A),
            new Car("AQ29173", CarType.B),
            new Car("QA12352", CarType.C),
            new Car("PH20300", CarType.D)
        };

        // GET: api/Cars
        [HttpGet]
        public IEnumerable<Car> Get()
        {
                return carList;
        }

        // GET: api/Cars/5
        [HttpGet("{id}", Name = "Get")]
        public Car Get(string id)
        {
            return carList.Find(x => x.LicensePlate == id) ;
        }

        // POST: api/Cars
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Cars/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
