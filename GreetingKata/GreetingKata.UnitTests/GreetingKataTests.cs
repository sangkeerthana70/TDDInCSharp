using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingKata.UnitTests
{
    public class GreetingkataTests
    {
        [Test]
        public void GreetNameShouldReturnHelloBob()
        {
            string name = "";
            var greetName = new GreetName();

            var expectedResult = greetName.ReturnGreetName("Bob");
            var actualResult = "Hello, Bob.";
            Console.WriteLine(expectedResult);
            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void GreetNameShouldHandleNull()
        {
            string name = "";
            var greetName = new GreetName();

            var expectedResult = greetName.ReturnGreetName("");
            var actualResult = "Hello, my friend.";
            Console.WriteLine(expectedResult);
            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void GreetNameShouldHandleUppercaseString()
        {
            string name = "JERRY";
            var greetName = new GreetName();

            var expectedResult = greetName.ReturnGreetName("JERRY");
            var actualResult = "HELLO JERRY!";
            Console.WriteLine(expectedResult);
            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void GreetNameShouldHandleTwoNamesOfInput()
        {
            string[] names = new string[] { "Jill", "Jane" };
            var greetName = new GreetName();

            var expectedResult = greetName.ReturnGreetName(names);
            var actualResult = "Hello, Jill and Jane.";
            Console.WriteLine(expectedResult);
            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void GreetNameShouldHandleMoreThanTwoNamesOfInput()
        {
            string[] names = new string[] { "Amy", "BRIAN", "Charlotte" };
            var greetName = new GreetName();

            var expectedResult = greetName.ReturnGreetName(names);
            var actualResult = "Hello, Amy, Brian, and Charlotte.";
            Console.WriteLine(expectedResult);
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
