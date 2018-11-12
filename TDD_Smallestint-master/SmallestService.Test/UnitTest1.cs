using NUnit.Framework;
using SmallestService;
using System;


namespace Tests
{
    public class Tests
    {
        [Test]
        public void ThrowsExceptionIfArrayInputIsEmpty()
        {
            var finder = new Finder();
            var input = new int[0];
            Assert.Throws<System.ArgumentException>(() => finder.FindSmallestInt(input));
        }
        //UnitTest1
        //part1Tests
        [Test]
        public void IfArrayLengthIsOneReturnInt()
        {
            var finder = new Finder();
            var input = new int[1] { 7 };

            var expected = 7;
            var actual = finder.FindSmallestInt(input);
            Console.WriteLine("Actual output: " + actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfArrayLengthIsTwoReturnLowestInt()
        {
            var finder = new Finder();
            var input = new int[2] { 7, 0 };

            var expected = 0;
            var actual = finder.FindSmallestInt(input);
            Console.WriteLine("Output: " + actual);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void IfArrayLengthIsThreeReturnLowestInt()
        {
            var finder = new Finder();
            var input = new int[3] { 7, 2, 4 };

            var expected = 2;
            var actual = finder.FindSmallestInt(input);
            Console.WriteLine("Output: " + actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfArrayLengthIsGreaterThanZeroReturnSmallestInt()
        {
            var finder = new Finder();
            var input = new int[] { 7, 2, 4 , -1, 0};

            var expected = -1;
            var actual = finder.FindSmallestInt(input);
            Console.WriteLine("Output: " + actual);
            Assert.AreEqual(expected, actual);
        }
     
    }
}