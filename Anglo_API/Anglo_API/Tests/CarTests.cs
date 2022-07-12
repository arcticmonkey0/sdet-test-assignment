using System.Collections.Generic;
using System.Net;
using Anglo_API.Core.Hooks;
using Anglo_API.Messages;
using NUnit.Framework;
using RestSharp;

namespace Anglo_API.Tests
{
    [TestFixture]
    public class CarTests : BaseTest
    {
        [Test]
        public void VerifySaloonCars()
        {
            const string SaloonType = "Saloon";
            List<Car> expected = new List<Car>
            {
                new Car()
                {
                    make = "BMW", model = "3.25i", price = 15000, type = SaloonType, year = "2013", zeroToSixty = 9.5
                },
                new Car()
                {
                    make = "Audi", model = "S4", price = 17500, type = SaloonType, year = "2015", zeroToSixty = 8.3
                },
                new Car()
                {
                    make = "Mercedes", model = "C200", price = 25000, type = SaloonType, year = "2018", zeroToSixty = 8.0
                }

            };
            List<Car> actual = AngloApi.Cars.GetCarByType("Saloon");
            Assert.That(actual, Is.EquivalentTo(expected));
        }
    }
}