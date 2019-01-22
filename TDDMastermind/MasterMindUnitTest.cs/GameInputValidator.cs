using System;
namespace Mastermind.Service
{
    public class GameInputValidator
    {
        public bool IsValid(int[]attempt)
        {
            foreach (var item in attempt)
            {
                int l = item.ToString().Length;
                if (l > 4 || l < 4)
                {
                    throw new System.ArgumentException("Length has to be four digits");
                }

            }

            return true;
        }
        public bool InputOutofBounds(int[]attempt)
        {
                if(attempt.Length > 6 || attempt.Length < 1)
                {
                    throw new ArgumentException("Numbers should be between 1 and 6");
                }
                return true;
        }

        public bool InputNotUnique(int[]attempt)
        {
            //2345, 5461, 2345, 4566, 7798, 7651
            for (var i = 0; i < attempt.Length - 1; i++)
            {
                for(var j = i + 1; j < attempt.Length; j++)
                {
                    Console.WriteLine("attempt[i] " + attempt[i]);
                    Console.WriteLine("attempt[j] " + attempt[j]);
                    if(attempt[i] == attempt[j])
                    {
                        throw new ArgumentException("All numbers must be unique ");
                    }
                }
            }
            return true;
        }
    }
}