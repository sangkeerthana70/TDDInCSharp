using NUnit.Framework;
using StringCalculatorService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorUnitTests
{
    [TestFixture]
    public class UnitTests
    {
        //Assert.IsInstanceOf()
        [Test]
        public void InputOfEmptyStringShouldReturnZero()
        {
            var input = "";
            var expected = 0;
            var actual = StringCalculator.Add(input);
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);


        }
        [Test]
        public void InputOneNumberShouldReturnTheNumber()
        {
            var input = "5";
            var expected = 5;
            var actual = StringCalculator.Add(input);
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void InputTwoNumbersShouldReturnTheSumOfTwoNumbers()
        {
            var input = "1,2";
            var expected = 3;
            var actual = StringCalculator.Add(input);
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void InputOfMoreNumbersShouldReturnTheSumOfAllNumbers()
        {
            var input = "1,2,3,4,5";
            var expected = 15;
            var actual = StringCalculator.Add(input);
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);

        }
    }
}
