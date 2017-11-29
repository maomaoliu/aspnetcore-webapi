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
        public IActionResult Get(int id)
        {
            return Ok("value");
        }

        // POST api/bookings
        [HttpPost]
        public IActionResult Post([FromBody]string value)
        {
            return CreatedAtAction("Get", value);
        }

        // PUT api/bookings/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]string value)
        {
            if (id > 2)
            {
                return NotFound();
            }
            return NoContent();
        }

        // DELETE api/bookings/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
