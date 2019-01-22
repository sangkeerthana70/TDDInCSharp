using System;

namespace Mastermind.Service
{
    public class Game
    {
        private readonly ICodeGenerator _codeGenerator;
        //private readonly GameStatus _gameStatus;
        public GameStatus _gameStatus { get; set; }
        public readonly GameInputValidator _validator;
        public int[] code;


        public Game(ICodeGenerator generator, GameStatus gameStatus, GameInputValidator validator)
        {
            _codeGenerator = generator;
            code = _codeGenerator.Generate();
            _gameStatus = gameStatus;
            _validator = validator;
        }

        //public bool getGameIsWon()
        //{
        //    return _gameStatus.GameIsWon;
        //}

        //public int getCorrectNumbers()
        //{
        //    return _gameStatus.CorrectNumbers;
        //}

        //public int getCorrectPositions()
        //{
        //    return _gameStatus.CorrectPositions;
        //}


        public bool CheckScore(int[] attempt)
        {
            //return _validator.IsValid(attempt) && _validator.InputOutofBounds(attempt) && _validator.InputNotUnique(attempt);          
            if (!(_validator.IsValid(attempt)))
            {
                return false;
            }
            if (!(_validator.InputOutofBounds(attempt)))
            {
                return false;
            }
            if (!(_validator.InputNotUnique(attempt)))
            {
                return false;
            }
            return true;

        }
        

        

    }
}