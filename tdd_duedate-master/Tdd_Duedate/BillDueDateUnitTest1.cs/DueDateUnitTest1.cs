using NUnit.Framework;
using PaymentDateCheck;
using System;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture]
    public class BillShould
    {
        [Test]
        public void IfBussinessDay_ReturnDueDate()
        {
            var input = new DateTime(2018, 8, 6);//monday which is a business day
            var mockHolidayService = new HolidayService();
            var _bill = new Bill(mockHolidayService);
            var output = _bill.CheckDate(input);
            var expected = input;
            Console.WriteLine("Actual return Date : " + output);
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void ifSaturday_ReturnMonday()
        {
            var input = new DateTime(2018, 8, 4);// saturday
            var mockHolidayService = new HolidayService();
            var _bill = new Bill(mockHolidayService);
            var output = _bill.CheckDate(input);
            Console.WriteLine("Actual return Date : " + output + "Monday");
            var expected = new DateTime(2018, 8, 6);// return Monday
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void ifSunday_ReturnMonday()
        {
            var input = new DateTime(2018, 8, 5);// sunday
            var mockHolidayService = new HolidayService();
            var _bill = new Bill(mockHolidayService);
            var output = _bill.CheckDate(input);
            Console.WriteLine("Actual return Date : " + output + " Monday");
            var expected = new DateTime(2018, 8, 6);// return Monday
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void ifHoliday_ReturnNonHoliday()
        {
            var input = new DateTime(2018, 11, 12);// Monday - veterans day
            var mockHolidayService = new HolidayService();
            var _bill = new Bill(mockHolidayService);
            var output = _bill.CheckDate(input);
            Console.WriteLine("Actual return Date : " + output + " Tuesday");
            var expected = new DateTime(2018, 11, 13);//return next bussiness day tuesday
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void ifHoliday_ReturnWeekday()// if friday is holiday return monday which is a weekday
        {
            var input = new DateTime(2018, 11, 23);// input friday
            var mockHolidayService = new HolidayService();
            var _bill = new Bill(mockHolidayService);
            var output = _bill.CheckDate(input);
            Console.WriteLine("Actual return Date : " + output + " Monday");
            var expected = new DateTime(2018, 11, 26);// return monday

            Assert.AreEqual(expected, output);

        }




    }
}
