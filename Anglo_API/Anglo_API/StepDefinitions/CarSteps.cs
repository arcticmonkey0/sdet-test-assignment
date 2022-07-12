using Anglo_API.Core.Hooks;
using Anglo_API.Messages;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Anglo_API.StepDefinitions
{
    [Binding]
    public class CarSteps : TestBase
    {
        public CarSteps(ScenarioContext scenarioContext) : base(scenarioContext)
        {
        }

        [When("I get a list of cars by (Saloon|Suv|Hatchback) type")]
        public void GetCarsByType(string carType)
        {
            List<Car> cars = AngloApi.Cars.GetCarByType(carType);
            Context.Set(cars, "RetrievedCars");
        }

        [Then("I verify the received cars list is the same as following")]
        public void VerifySaloonCars(Table table)
        {
            List<Car> expected = table.CreateSet<Car>().ToList();
            var actual = Context.Get<List<Car>>("RetrievedCars");
            Assert.That(actual, Is.EquivalentTo(expected));
        }
    }
}