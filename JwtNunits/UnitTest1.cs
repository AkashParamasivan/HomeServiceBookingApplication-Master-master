using NUnit.Framework;
using ServiceBookingJwt.Controllers;

namespace JwtNunits
{
    public class Tests
    {
        //Arange
        AuthenticationController authentication = new AuthenticationController();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Act
            //Assert
            Assert.Pass();
        }
    }
}