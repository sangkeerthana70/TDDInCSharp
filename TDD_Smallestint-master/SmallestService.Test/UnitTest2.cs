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
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindClosestIntToZeroIfInputIsTwoAndThreeReturnsTwo()
        {
            var finder = new Finder();
            var input = new int[2] { 3, 2 };

            var expected = 2;
            var actual = finder.FindClosestIntToZero(input);
            Console.WriteLine("Output: " + actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfInputLengthIsThreeReturnsClosestToZero()
        {
            var finder = new Finder();
            var input = new int[3] { 0, 2, 1 };

            var expected = 0;
            var actual = finder.FindClosestIntToZero(input);
            Console.WriteLine("Output: " + actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfInputContainsNegativeNumberReturnClosestToZero()
        {
            var finder = new Finder();
            var input = new int[3] { 3, -5, -1 };

            var expected = -1;
            var actual = finder.FindClosestIntToZero(input);
            Console.WriteLine("Output: " + actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfInputContainsNegativeNumberAndPostiveNumberBothAreSameClosestToZeroReturnNegativeNumber()
        {
            var finder = new Finder();
            var input = new int[3] { 5, 7, -5 };

            var expected = -5;
            var actual = finder.FindClosestIntToZero(input);
            Console.WriteLine("Output: " + actual);
            Assert.AreEqual(expected, actual);

        }
    }
}
