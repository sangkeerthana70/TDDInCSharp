using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRotateArray.UnitTests
{
    [TestFixture]
    public class RotateArrayTests
    {
        [Test]
        public void CheckLengthOfArr()
        {
            int[] inputArr = new int[] { 1, 2, 3, 4, 5 };
            int arrLength = 5;
            //int numToRotate = 4;

            var expectedResult = 5;
            //var rotateArray = new RotateArray();
            var actualResult = RotateArray.GiveNewRotatedArray(inputArr);

            Assert.AreEqual(expectedResult, actualResult);
        }

        
        [Test]
        public void RotateArrayBasedOnNumToRotate()
        {
            int[] inputArr = new int[] { 1, 2, 3, 4, 5 };
            int arrLength = 5;
            int numToRotate = 4;

            var expectedResult = new int[] { 2, 3, 4, 5, 1 };
            var actualResult = RotateArray.GiveNewRotatedArray(inputArr, numToRotate);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
