﻿using NUnit.Framework;
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
    }
}
