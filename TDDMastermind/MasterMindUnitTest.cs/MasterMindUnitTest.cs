using NUnit.Framework;
using Mastermind.Service;

namespace Tests
{
    public class Tests
    {
        Game game = new Game(new CodeGenerator(), new GameStatus(), new GameInputValidator());
        [Test]
        public void ThrowExceptionIfAttemptLenghtIsMoreThan4()
        {
            game.code = new int[]{1,2,3,4};
            var input = new int[]{1,2,3,4,5};
            Assert.Throws<System.ArgumentException>(() => game.CheckScore(input));
        }

        [Test]
        public void ThrowExceptionIfAttemptLengthIsLessThan4()
        {
            game.code = new int[] { 1, 2, 3, 4 };
            var input = new int[] { 1, 2, 3 };
            Assert.Throws<System.ArgumentException>(() => game.CheckScore(input));
        }
        
        [Test]
        public void ThrowExceptionIfNumberInAttemptArrayIsGreaterThan6()
        {
            game.code = new int[] { 1, 2, 3, 4 };
            var input = new int[] { 1, 2, 3, 7 };
            Assert.Throws<System.ArgumentException>(() => game.CheckScore(input));
        }
        
        [Test]
        public void ThrowExceptionIfNumberInAttemptArrayIsLessThan1()
        {
            game.code = new int[] { 1, 2, 3, 4 };
            var input = new int[] { 0 , 2, 3, 4 };
            Assert.Throws<System.ArgumentException>(() => game.CheckScore(input));

        }
        [Test]
        public void ThrowExceptionIfAllNumbersInAttemptArrayAreNotUnique()
        {
            game.code = new int[] { 1, 2, 3, 4 };
            var input = new int[] { 2, 2, 3, 4 };
            Assert.Throws<System.ArgumentException>(() => game.CheckScore(input));

        }

        [Test]
        public void IfGameIsWon_ReturnGameStatusIsWonTrue()
        {
            
        }

    }
}

