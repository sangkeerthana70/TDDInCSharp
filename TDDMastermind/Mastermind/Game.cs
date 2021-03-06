﻿using System;

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
            //return true;
            // loop through test case IfGameIsWon_ReturnGameStatusIsWonTrue()
            for (var i = 0; i < attempt.Length; i++)
            {
                var result = CalculateScore(code, attempt[i]);

                // returns Correct Numbers and correct positions for the attempt array
                _gameStatus.CorrectNumbers = result[0];
                _gameStatus.CorrectPositions = result[1];
                if ((_gameStatus.CorrectNumbers == 4) && (_gameStatus.CorrectPositions == 4))
                {
                    _gameStatus.GameIsWon = true;
                    break;
                }
                else
                {
                    _gameStatus.GameIsWon = false;
                }
            }
            return _gameStatus.GameIsWon;

        }

        public int[] CalculateScore(int[] gameCode, int input)
        {
            int[] result = new int[2];
            int CorrectNumbers = 0;
            int CorrectPositions = 0;
            //convert the input variable to a string
            string s = input.ToString();

            int currNum;
            for (var i = 0; i < s.Length; i++)
            {
                currNum = Convert.ToInt32(s[i]) - 48;// 48 represents ascii of 0    
                Console.WriteLine("Curr num : " + currNum);
                for (var j = 0; j < gameCode.Length; j++)
                {
                    Console.WriteLine("gameCode[j] : " + gameCode[j]);
                    if (currNum == gameCode[j])
                    {
                        CorrectNumbers += 1;
                        // check position of both numbers
                        if (i == j)
                        {
                            CorrectPositions += 1;
                        }
                        break;
                    }
                }
                result[0] = CorrectNumbers;
                result[1] = CorrectPositions;
            }
            Console.WriteLine(string.Join(" ", CorrectNumbers, CorrectPositions));
            return result;
        }





    }
}