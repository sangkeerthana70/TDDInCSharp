using Mastermind.Service;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        Game game = new Game(new CodeGenerator(), new GameStatus(), new GameInputValidator());
        [Test]
        public void ThrowExceptionIfAttemptLenghtIsMoreThan4()
        {
            game.code = new int[]{1,2,3,4};
            //var input = new int[]{1,2,3,4,5};
            var input = new int[] { 2345, 5461, 7657, 45677, 7798, 7651 };
            Assert.Throws<System.ArgumentException>(() => game.CheckScore(input));
        }

        [Test]
        public void ThrowExceptionIfAttemptLengthIsLessThan4()
        {
            //game.code = new int[] { 1, 2, 3, 4 };
            //var input = new int[] { 1, 2, 3 };
            var input = new int[] { 2345, 5461, 7657, 456, 7798, 7651 };
            Assert.Throws<System.ArgumentException>(() => game.CheckScore(input));
        }
        
        [Test]
        public void ThrowExceptionIfNumberInAttemptArrayIsGreaterThan6()
        {
            game.code = new int[] { 1, 2, 3, 4 };
            //var input = new int[] { 1, 2, 3, 7 };
            var input = new int[] { 2345, 5461, 7657, 4566, 7798, 7651, 8898 };
            Assert.Throws<System.ArgumentException>(() => game.CheckScore(input));
        }
        
        [Test]
        public void ThrowExceptionIfNumberInAttemptArrayIsLessThan1()
        {
            game.code = new int[] { 1, 2, 3, 4 };
            //var input = new int[] { 0 , 2, 3, 4 };
            var input = new int[] { };
            Assert.Throws<System.ArgumentException>(() => game.CheckScore(input));

        }
        [Test]
        public void ThrowExceptionIfAllNumbersInAttemptArrayAreNotUnique()
        {
            game.code = new int[] { 1, 2, 3, 4 };
            //var input = new int[] { 2, 2, 3, 4 };
            var input = new int[] { 2345, 5461, 2345, 4566, 7798, 7651};
            Assert.Throws<System.ArgumentException>(() => game.CheckScore(input));

        }

        [Test]
        public void IfGameIsWon_ReturnGameStatusIsWonTrue()
        {
            game.code = new int[] { 1, 2, 3, 4 };
            var input = new int[] { 1234, 2341, 3412, 3421, 2314, 1324 };//attempt
            game.CheckScore(input);

            System.Console.WriteLine("actual: " + game._gameStatus.GameIsWon);
            Assert.AreEqual(true, game._gameStatus.GameIsWon);

        }

        [Test]
        public void If3NumbersAreCorrect_ReturnGameStatusCorrectNumsIs3()
        {
            game.code = new int[] { 1, 2, 3, 4 };
            var input = new int[] { 5341 };//attempt
            game.CheckScore(input);
            System.Console.WriteLine("actual : " + game._gameStatus.CorrectNumbers);
            //Assert.AreEqual(false, game._gameStatus.GameIsWon);
            Assert.AreEqual(3, game._gameStatus.CorrectNumbers);

        }

        [Test]
        public void If2NumbersAreInCorrectPosition_ReturnGameStatusCorrectPositionsIs2()
        {
            game.code = new int[] { 1, 2, 3, 4 };
            var input = new int[] { 5134 };//attempt
            game.CheckScore(input);
            System.Console.WriteLine("actual : " + game._gameStatus.CorrectPositions);
            //Assert.AreEqual(false, game._gameStatus.GameIsWon);
            Assert.AreEqual(2, game._gameStatus.CorrectPositions);
        }

    }
}

