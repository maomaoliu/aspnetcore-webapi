using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using BookingApi.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using Xunit;

namespace BookingApi.IntegrationTests
{
    public class RetrieveBookingsTests
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;

        public RetrieveBookingsTests()
        {
            _server = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        [Fact]
        public void ShouldGetBookingList()
        {
            var response = _client.GetAsync("/api/bookings");
            Assert.Equal(response.Result.StatusCode, HttpStatusCode.OK);
            var bookings = JsonConvert.DeserializeObject<List<Booking>>(response.Result.Content.ReadAsStringAsync().Result);
            var booking = bookings[0];
            Assert.Equal(booking.Id, 0);
            Assert.Equal(booking.Pnr, "abcdef");
        }
    }
}
