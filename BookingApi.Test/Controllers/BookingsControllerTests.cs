using System;
using System.Collections.Generic;
using System.Linq;
using BookingApi.Controllers;
using BookingApi.Models;
using BookingApi.Services;
using Moq;
using Xunit;

namespace BookingApi.Test
{
    public class BookingsControllerTests
    {
        [Fact]
        public void GetBookings()
        {
            var mockService = new Mock<IBookingService>();
            mockService.Setup(m => m.GetAll()).Returns(new List<Booking>());
            
            var controller = new BookingsController(mockService.Object);
            
            var result = controller.Get();

            Assert.Equal(result.ToList().Count, 0);        }
    }
}
