using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals.UnitTests
{
    public class TDDApproach
    {
        
        [Test]
        public void ReturnEmptyCharArr()
        {
            char[] inputArr = new char[0] { };
            var expected = 0;

            var calculateRomanNumeral = new CalculateRomanNumeral();

            var actualResult = calculateRomanNumeral.FindRomanNumeral(inputArr);
            Console.WriteLine("In Test");
            Assert.AreEqual(expected, actualResult);
            
        }

        [Test]
        public void ReturnValue1ForCapitalI()
        {
            char[] inputArr = new char[] { 'I' };
            var expected = 1;

            var calculateRomanNumeral = new CalculateRomanNumeral();

            var actualResult = calculateRomanNumeral.FindRomanNumeral(inputArr);
            Console.WriteLine(actualResult);
            Assert.AreEqual(expected, actualResult);
        }
        [Test]
        public void ReturnValue10ForCapitalX()
        {
            char[] inputArr = new char[] { 'X' };
            var expected = 10;

            var calculateRomanNumeral = new CalculateRomanNumeral();

            var actualResult = calculateRomanNumeral.FindRomanNumeral(inputArr);
            Console.WriteLine(actualResult);
            Assert.AreEqual(expected, actualResult);
        }
        [Test]
        public void ReturnValue50ForCapitalL()
        {
            char[] inputArr = new char[] { 'L' };
            var expected = 50;

            var calculateRomanNumeral = new CalculateRomanNumeral();

            var actualResult = calculateRomanNumeral.FindRomanNumeral(inputArr);
            Console.WriteLine(actualResult);
            Assert.AreEqual(expected, actualResult);
        }
        [Test]
        public void ReturnValue100ForCapitalC()
        {
            char[] inputArr = new char[] { 'C' };
            var expected = 100;

            var calculateRomanNumeral = new CalculateRomanNumeral();

            var actualResult = calculateRomanNumeral.FindRomanNumeral(inputArr);
            Console.WriteLine(actualResult);
            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void ReturnValue500ForCapitalD()
        {
            char[] inputArr = new char[] { 'D' };
            var expected = 500;

            var calculateRomanNumeral = new CalculateRomanNumeral();

            var actualResult = calculateRomanNumeral.FindRomanNumeral(inputArr);
            Console.WriteLine(actualResult);
            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void ReturnValue1000ForCapitalM()
        {
            char[] inputArr = new char[] { 'M' };
            var expected = 1000;

            var calculateRomanNumeral = new CalculateRomanNumeral();

            var actualResult = calculateRomanNumeral.FindRomanNumeral(inputArr);
            Console.WriteLine(actualResult);
            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void ReturnTwoValuesForTwoStrings()
        {
            char[] inputArr = new char[] { 'I', 'I' };
            var expected = 11;

            var calculateRomanNumeral = new CalculateRomanNumeral();

            var actualResult = calculateRomanNumeral.FindRomanNumeral(inputArr);
            Console.WriteLine(actualResult);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
