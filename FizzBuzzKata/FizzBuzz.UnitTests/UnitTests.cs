using FizzBuzzService;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.UnitTests
{
    [TestFixture]
    public class UnitTests
    {
        FizzBuzzer fizzBuzzer = new FizzBuzzer();
        [Test]
        public void IfInputIsNotDivisibleBy3ReturnTheNumber()
        {
            var input = 8;
            var expected = "8";
            var actual = FizzBuzzer.FizzOrBuzz(input);
            Console.WriteLine("actual: " + actual);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void IfInputIsDivisibleBy3ReturnFizz()
        {
            var input = 9;
            var expected = "Fizz";
            var actual = FizzBuzzer.FizzOrBuzz(input);
            Console.WriteLine("actual: " + actual);
            Assert.AreEqual(expected, actual);

        }
    }
}
