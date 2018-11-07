using NUnit.Framework;
using System;

namespace ThirtyDaysOfTDD.UnitTests
{

    [TestFixture]

    public class StringUtilsTest
    {
        [Test]
        public void ShouldBeAbleToCountNumberOfLettersInSimpleSentence()
        {
            var sentenceToScan = "TDD is awesome!";
            var characterToScanFor = "e";
            var expectedResult = 2;

            var stringUtilsTest = new StringUtilsTest();

            int result = FindNumberOfOccurances(sentenceToScan, characterToScanFor);
        }
    }
}
