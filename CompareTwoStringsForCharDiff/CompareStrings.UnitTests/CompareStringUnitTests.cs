using NUnit.Framework;
using System;

namespace CompareStrings.UnitTests
{
    [TestFixture]// Nunit will understand that this class will have all the unit tests
    public class CompareStringUnitTests
    {
        [Test]// identify this method as a Nunit test

        // have descrriptive names for the test method
        public void CompareLengthOfTwoStringsToBeSame()
        {
            //Arrange
            string a = "this";
            string b = "that";

            var expectedResult = 4;
            var compareStrings = new CompareTwoStrings();

            // Assert
            int actualResult = compareStrings.CheckLengthOfTwoStrings(a , b);
            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void CompareStringsReturnsArrayValuesZeroZeroMinusEightAndOne()
        {
            string a = "this";
            string b = "that";
            int length = 4;

            int [] expectedResult = { 0, 0 , - 8, 1 };
            var compareStrings = new CompareTwoStrings();

            // Assert 
            // string.Join() method Concatenates the elements of a specified array or the members of a collection,
            // using the specified separator between each element or member.
            Console.WriteLine("expected result " + string.Join(" ", expectedResult));
            var actualResult = compareStrings.FindDifferenceBetweenTwoStrings(a, b, length);
            
            Console.WriteLine("actual result " + string.Join(" " ,actualResult));
            
            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void CompareStringsReturnsArrayValuesMinusThirteenMinusThreeMinusEightMinusOne()
        {
            string a = "this";
            string b = "bear";
            int length = 4;

            int[] expectedResult = { -18, -3, -8, -1 };
            var compareStrings = new CompareTwoStrings();

            // Assert 
            Console.WriteLine("expected result " + string.Join(" ",expectedResult));
            var actualResult = compareStrings.FindDifferenceBetweenTwoStrings(a, b, length);
            Console.WriteLine("actualResult " + string.Join(" ", actualResult));

                
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void CompareStringsReturnsArrayValuesThirteenThreeEightOne()
        {
            
            string a = "bear";
            string b = "this";
            int length = 4;

            int[] expectedResult = { 18, 3, 8, 1 };
            var compareStrings = new CompareTwoStrings();

            // Assert 
            Console.WriteLine("expected result " + string.Join(" ", expectedResult));
            var actualResult = compareStrings.FindDifferenceBetweenTwoStrings(a, b, length);
            Console.WriteLine("actualResult " + string.Join(" ", actualResult));


            Assert.AreEqual(expectedResult, actualResult);

        }



    }
}
