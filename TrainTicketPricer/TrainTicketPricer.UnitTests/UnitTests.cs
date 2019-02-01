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
        public void TicketPriceForFiveStationsForAdultsOnNonHolidayShouldReturn25()
        {
            var board = 1;
            var destination = 6;
            DateTime date = new DateTime();
            int age = 42;
            var expected = 25;
            var actual = ttp.CalculatePrice(board, destination, age, date);
            Console.WriteLine("actual: " + actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TicketPriceForFiveStationsForAdultsOnHolidayShouldDiscount20PercentOffRegularPrice()
        {
            var board = 1;
            var destination = 6;
            DateTime date = new DateTime(2019, 2, 2);
            int age = 62;
            var expected = 20;
            var actual = ttp.CalculatePrice(board, destination, age, date);
            Console.WriteLine("actual: " + actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TicketPriceForSixStationsForSeniorsOnNonHolidayShouldReturn24()
        {
            var board = 1;
            var destination = 7;
            DateTime date = new DateTime(2019, 1, 31);
            Console.WriteLine(date);
            int age = 70;
            var expected = 24;
            var actual = ttp.CalculatePrice(board, destination, age, date);
            Console.WriteLine("actual: " + actual);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void TicketPriceForSevenStationsForSeniorsOnHolidaysShouldReturn22()
        {
            var board = 1;
            var destination = 8;
            DateTime date = new DateTime(2019, 2, 3);
            Console.WriteLine(date);
            int age = 75;
            var expected = 22;
            var actual = ttp.CalculatePrice(board, destination, age, date);
            Console.WriteLine("actual: " + actual);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void TicketPriceForFourStationForAChildOnNonHolidayShouldReturn12()
        {
            var board = 1;
            var destination = 5;
            DateTime date = new DateTime(2019, 2, 4);
            Console.WriteLine(date);
            int age = 11;
            var expected = 12;
            var actual = ttp.CalculatePrice(board, destination, age, date);
            Console.WriteLine("actual: " + actual);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void TicketPriceForNineStationsForAChildOnAHolidayShouldReturn22()
        {
            var board = 1;
            var destination = 10;
            DateTime date = new DateTime(2019, 2, 9);
            Console.WriteLine(date);
            int age = 13;
            var expected = 22;
            var actual = ttp.CalculatePrice(board, destination, age, date);
            Console.WriteLine("actual: " + actual);
            Assert.AreEqual(expected, actual);

        }
    }
}
