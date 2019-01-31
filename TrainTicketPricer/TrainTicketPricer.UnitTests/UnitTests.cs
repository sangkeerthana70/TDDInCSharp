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
            var board = 5;
            var destination = 1;
            DateTime date = new DateTime();
            int age = 0;
            
            Assert.Throws<System.ArgumentException>(() => ttp.CalculatePrice(board, destination, age, date));
        }

        [Test]
        public void TicketPriceShouldReturnFiveForFiveStationsForAdultOnNonHoliday()
        {
            var board = 1;
            var destination = 6;
            DateTime date = new DateTime();
            int age = 42;
            var expected = 5;
            var actual = ttp.CalculatePrice(board, destination, age, date);
            Assert.AreEqual(expected, actual);
        }
    }
}
