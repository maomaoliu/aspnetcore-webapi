using System.Collections.Generic;
using BookingApi.Models;

namespace BookingApi.Services
{
    public interface IBookingService
    {
        IEnumerable<Booking> GetAll();
        void Add(Booking value);
        Booking Get(int id);
        void Update(int id, Booking value);
        void Delete(int id);
    }
}