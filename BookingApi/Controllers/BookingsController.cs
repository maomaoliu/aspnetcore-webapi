using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace BookingApi.Controllers
{
    [Route("api/[controller]")]
    public class BookingsController : Controller
    {
        // GET api/bookings
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/bookings/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/bookings
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/bookings/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/bookings/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
