using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmallestService.Test
{
    public class Tests
    {
        [Test]
        public void ThrowsExceptionIfArrayInputIsEmpty()
        {
            var finder = new Finder();
            var input = new int[0];
            Assert.Throws<System.ArgumentException>(() => finder.FindClosestIntToZero(input));
        }
        //UnitTest2
        //part2Tests
        [Test]
        public void FindClosestIntToZeroIfArrayLengthIsOneAndInputIsOneReturnOne()
        {
            var finder = new Finder();
            var input = new int[1] { 1 };

            var expected = 1;
            var actual = finder.FindClosestIntToZero(input);
            Console.WriteLine("Output: " + actual);
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void FindClosestIntToZeroIfInputIsTwoAndThreeReturnsTwo()
        {
            var finder = new Finder();
            var input = new int[2] { 3, 2 };

            var expected = 2;
            var actual = finder.FindClosestIntToZero(input);
            Console.WriteLine("Output: " + actual);
            Assert.AreEqual(actual, expected);

        }
    }
}
