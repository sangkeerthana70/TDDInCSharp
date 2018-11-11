using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.UnitTests
{
    [TestFixture]
    public class TDDApproach
    {
        [Test]
        public void EmptyStringShouldReturn0()
        {
            string inputString = "";

            var addString = new AddString();
            var expectedResult = 0;
            var actualResult = addString.Add(inputString);

            Console.WriteLine(actualResult);
            Assert.AreEqual(actualResult, expectedResult);           
        }

        [Test]
        public void StringInputOfOneNumberShouldReturnNumber()
        {
            string inputString = "1";

            var addString = new AddString();
            var expectedResult = 1;
            var actualResult = addString.Add(inputString);

            Console.WriteLine(actualResult);
            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void StringInputOfTwoNumberShouldReturnSumOfTwoNumbers()
        {
            string inputString = "1,2";

            var addString = new AddString();
            var expectedResult = 3;
            var actualResult = addString.Add(inputString);

            Console.WriteLine(actualResult);
            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void StringInputOfManyNumbersShouldReturnSumOfAllNumbers()
        {
            string inputString = "1, 2, 3, 4, 5";

            var addString = new AddString();
            var expectedResult = 15;
            var actualResult = addString.Add(inputString);

            Console.WriteLine(actualResult);
            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void StringInputShouldHandleNewlinesBetweenNumbersInsteadOfCommas()
        {
            string inputString = "1\n2,3";

            var addString = new AddString();
            var expectedResult = 6;
            var actualResult = addString.Add(inputString);

            Console.WriteLine(actualResult);
            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void StringInputShouldSupportDifferentDelimiters()
        {
            string inputString = "//;\n1;2";

            var addString = new AddString();
            var expectedResult = 3;
            var actualResult = addString.Add(inputString);

            Console.WriteLine(actualResult);
            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void StringInputWithNegativeValuesShouldThrowException()
        {
            string inputString = "1, -1, 0";

            var addString = new AddString();
            var expectedResult = "negatives not allowed";
            var actualResult = addString.Add(inputString);

            Console.WriteLine(actualResult);
            Assert.Fail();

        }


    }
}
