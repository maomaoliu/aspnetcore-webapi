using System.Collections.Generic;
using BookingApi.Models;
using BookingApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookingApi.Controllers
{
    [Route("api/[controller]")]
    [Route("api")]
    [Route("/")]
    public class BookingsController : Controller
    {
        private IBookingService _bookingService;

        public BookingsController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        // GET api/bookings
        [HttpGet]
        public IEnumerable<Booking> Get()
        {
            return _bookingService.GetAll();
        }

        // GET api/bookings/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_bookingService.Get(id));
        }

        // POST api/bookings
        [HttpPost]
        public IActionResult Post([FromBody]Booking value)
        {
            _bookingService.Add(value);
            return CreatedAtAction("Get", value);
        }

        // PUT api/bookings/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Booking value)
        {
            _bookingService.Update(id, value);
            return NoContent();
        }

        // DELETE api/bookings/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _bookingService.Delete(id);
            return NoContent();
        }
    }
}
