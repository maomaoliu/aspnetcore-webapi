using System.Collections.Generic;
using BookingApi.Models;
using BookingApi.Services;
using BookingApi.Stores;

namespace webapi.Services
{
    public class BookingService : IBookingService
    {
        private static readonly BookingStore _bookingStore = BookingStore.Instance; 
        
        public IEnumerable<Booking> GetAll()
        {
            return _bookingStore.GetAll();
        }

        public void Add(Booking value)
        {
            _bookingStore.Add(value);
        }

        public Booking Get(int id)
        {
            return _bookingStore.Get(id);
        }

        public void Update(int id, Booking value)
        {
            _bookingStore.Update(id, value);
        }

        public void Delete(int id)
        {
            _bookingStore.Delete(id);
        }
    }
}