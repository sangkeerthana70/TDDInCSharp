using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals.UnitTests
{
    [TestFixture]

    public class TDDApproach
    {

        [Test]
        public void ReturnEmptyCharArr()
        {
            string romanNumeral = "";
            var expected = 0;

            var calculateRomanNumeral = new CalculateRomanNumeral();

            var actualResult = calculateRomanNumeral.FindRomanNumeral(romanNumeral);
            
            Assert.AreEqual(expected, actualResult);

        }

        [Test]
        public void ReturnValue1ForCapital_I()
        {
            string romanNumeral = "I";
            var expected = 1;

            var calculateRomanNumeral = new CalculateRomanNumeral();

            var actualResult = calculateRomanNumeral.FindRomanNumeral(romanNumeral);
            Console.WriteLine(actualResult);
            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void ReturnValue5ForCapital_V()
        {
            string romanNumeral = "V";
            var expected = 5;

            var calculateRomanNumeral = new CalculateRomanNumeral();

            var actualResult = calculateRomanNumeral.FindRomanNumeral(romanNumeral);
            Console.WriteLine(actualResult);
            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void ReturnValue10ForCapital_X()
        {
            string romanNumeral = "X";
            var expected = 10;

            var calculateRomanNumeral = new CalculateRomanNumeral();

            var actualResult = calculateRomanNumeral.FindRomanNumeral(romanNumeral);
            Console.WriteLine(actualResult);
            Assert.AreEqual(expected, actualResult);
        }
        [Test]
        public void ReturnValue50ForCapital_L()
        {
            string romanNumeral = "L";
            var expected = 50;

            var calculateRomanNumeral = new CalculateRomanNumeral();

            var actualResult = calculateRomanNumeral.FindRomanNumeral(romanNumeral);
            Console.WriteLine(actualResult);
            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void ReturnValue100ForCapital_C()
        {
            string romanNumeral = "C";
            var expected = 100;

            var calculateRomanNumeral = new CalculateRomanNumeral();

            var actualResult = calculateRomanNumeral.FindRomanNumeral(romanNumeral);
            Console.WriteLine(actualResult);
            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void ReturnValue500ForCapital_D()
        {
            string romanNumeral = "D";
            var expected = 500;

            var calculateRomanNumeral = new CalculateRomanNumeral();

            var actualResult = calculateRomanNumeral.FindRomanNumeral(romanNumeral);
            Console.WriteLine(actualResult);
            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void ReturnValue1000ForCapital_M()
        {
            string romanNumeral = "M";
            var expected = 1000;

            var calculateRomanNumeral = new CalculateRomanNumeral();

            var actualResult = calculateRomanNumeral.FindRomanNumeral(romanNumeral);
            Console.WriteLine(actualResult);
            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        
        public void ReturnNumericValuesForStrings_MMVI()
        {
            string romanNumeral = "MMVI";
            var expected = 2006;

            var calculateRomanNumeral = new CalculateRomanNumeral();

            var actualResult = calculateRomanNumeral.FindRomanNumeral(romanNumeral);
            Console.WriteLine(actualResult);
            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void ReturnNumericValuesForMultipleStrings_MCMXLIV()
        {

            string romanNumeral = "MCMXLIV";
            var expected = 1944;

            var calculateRomanNumeral = new CalculateRomanNumeral();

            var actualResult = calculateRomanNumeral.FindRomanNumeral(romanNumeral);
            Console.WriteLine(actualResult);
            Assert.AreEqual(expected, actualResult);
        }
    }
}

       