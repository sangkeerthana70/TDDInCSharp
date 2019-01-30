using NUnit.Framework;
using System;
using TrainTicketPricerServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicketPricer.UnitTests
{
    [TestFixture]
    public class UnitTests
    {
        TicketPricer ttp = new TicketPricer(new PassengerType(), new HolidayChecker());

        [Test]
        public void TestShouldThrowExceptionIfNumberOfStopsIsANegativeValue()
        {
            //throw new NotImplementedException("Test to be Implemented");
            var sStop = 5;
            var dStop = 1;
            var expected = "Number of stops cannot be negative";
            //var actual = ttp.CheckNumberOfStops(sStop, dStop);
            //Console.WriteLine("actual: " + actual);
            Assert.Throws<System.ArgumentException>(() => ttp.CheckNumberOfStops(sStop, dStop));
        }
    }
}
