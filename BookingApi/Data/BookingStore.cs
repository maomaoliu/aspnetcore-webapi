using System;
using System.Collections.Generic;
using System.Linq;
using BookingApi.Models;

namespace BookingApi.Stores
{
    public sealed class BookingStore
    {
        private IList<Booking> _bookings = new List<Booking> { new Booking() { Id = 0, Pnr = "abcdef", Status = "open" } };
        private int idIndex = 1;
 
        private BookingStore()
        {
         
        }
     
        private static readonly Lazy<BookingStore> lazy =
            new Lazy<BookingStore>(() => new BookingStore());
     
        public static BookingStore Instance { get { return lazy.Value; } }
 
 
        public IEnumerable<Booking> GetAll()
        {
            return _bookings;
        }
 
        public Booking Get(int id)
        {
            return _bookings.First(booking => booking.Id == id);
        }
 
        public bool Delete(int id)
        {
            return _bookings.Remove(Get(id));
        }
 
        public void Add(Booking booking)
        {
            booking.Id = idIndex;
            idIndex += 1;
            _bookings.Add(booking);
        }
 
        public void Update(int id, Booking booking)
        {
            var oriBooking = Get(id);
            oriBooking.Pnr = booking.Pnr;
            oriBooking.Status = booking.Status;
        }        
    }
}