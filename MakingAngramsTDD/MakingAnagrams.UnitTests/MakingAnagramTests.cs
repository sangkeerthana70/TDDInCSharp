using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingAnagrams.UnitTests
{
    class MakingAnagramTests
    {
        [Test]
        public void ReturnsAnInteger()
        {
            string a = "";
            string b = "";
            var makeAnagram = new MakeAnagram();
            var expectedResult = 0;

            int actualResult = makeAnagram.FindLetters(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void CheckIfBothStringHaveSameLength()
        {
            string a = "cde";
            string b = "dcf";
            var makeAnagram = new MakeAnagram();
            var expectedResult = true;

            int actualResult = makeAnagram.FindLetters(a, b);
            bool boolValue = actualResult != 0;
            Assert.AreEqual(expectedResult, !boolValue);
        }

        [Test]
        public void ReturnFourforThisInput()
        {

            string a = "cde";
            string b = "abc";
            var makeAnagram = new MakeAnagram();
            var expectedResult = 4;

            int actualResult = makeAnagram.FindLetters(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }



    }
}
