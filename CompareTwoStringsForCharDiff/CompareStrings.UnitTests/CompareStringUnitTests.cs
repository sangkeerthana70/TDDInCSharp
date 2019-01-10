using NUnit.Framework;

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

            //
            int actualResult = compareStrings.CheckLengthOfTwoStrings(a , b);
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
