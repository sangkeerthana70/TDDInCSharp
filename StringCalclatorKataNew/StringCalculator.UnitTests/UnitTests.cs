﻿using NUnit.Framework;
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

        [Test]
        public void InputShouldAllowNewLineAsDelimiterInsteadOfCommasToReturnSum()
        {
            var input = "1\n2,3";
            var expected = 6;
            var actual = StringCalculator.Add(input);
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void InputShouldSupportDifferentDelimiters()
        {
            var input = "//;\n1;2";
            var expected = 3;
            var actual = StringCalculator.Add(input);
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void InputStringWithNegativeNnumberShouldThrowException()
        {
            var input = "11, -11, 0";
            Assert.Throws<System.ArgumentException>(() => StringCalculator.Add(input));
        }

    }
}
