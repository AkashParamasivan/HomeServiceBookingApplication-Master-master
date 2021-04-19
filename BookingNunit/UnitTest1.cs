using NUnit.Framework;
using BookingApi.Controllers;
using BookingApi.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BookingApi.Repository;
using Moq;

namespace BookingNunit
{
    public class Tests
    {

        List<Booking> book = new List<Booking>();
        IQueryable<Booking> billingdata;
        Mock<DbSet<Booking>> mockSet;
        Mock<ServiceBookingContext> billcontextmock;
        BookingsController bookings = new BookingsController();
        [SetUp]
        public void Setup()
        {
            book = new List<Booking>()
            {
                new Booking{Bookingid = 1, CustomerId="ak",ServiceProviderId="123"}
           

            };
            billingdata = book.AsQueryable();
            mockSet = new Mock<DbSet<Booking>>();
            mockSet.As<IQueryable<Booking>>().Setup(m => m.Provider).Returns(billingdata.Provider);
            mockSet.As<IQueryable<Booking>>().Setup(m => m.Expression).Returns(billingdata.Expression);
            mockSet.As<IQueryable<Booking>>().Setup(m => m.ElementType).Returns(billingdata.ElementType);
            mockSet.As<IQueryable<Booking>>().Setup(m => m.GetEnumerator()).Returns(billingdata.GetEnumerator());
            var p = new DbContextOptions<ServiceBookingContext>();
            billcontextmock = new Mock<ServiceBookingContext>(p);
            billcontextmock.Setup(x => x.Bookings).Returns(mockSet.Object);
        }
    
        [Test]
        public void AddBookingDetails()
        {

            var bookingrepo = new BookingRepo(billcontextmock.Object);
            var bookingobj = bookingrepo.PostBooking(new Booking { Bookingid = 1, CustomerId = "ak", ServiceProviderId = "123" });
            Assert.IsNotNull(bookingobj);
        }
    }
}
