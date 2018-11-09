using System;

namespace RomanNumerals.UnitTests
{
    internal class CalculateRomanNumeral
    {
        
        public int FindRomanNumeral(char[] inputArr)
        {
            //int result = 0;
            int tempResult = 0;
            string result = "";

            for (int i = 0; i < inputArr.Length; i++)
            {
                tempResult = RomanToNumeric(inputArr[i]);
                result += tempResult.ToString();
                
                
            }
            
            try
            {
                Console.WriteLine("In try block");
                Console.WriteLine("final conversion: " + Int32.Parse(result));
                return Int32.Parse(result);
            }
            catch(Exception e)
            {
                Console.WriteLine("In exception block");
                return 0;
            }
            
            
        }

        private int RomanToNumeric(char r)
        {
            var num = 0;
            switch (r)
            {
                case 'I':
                    num = 1;
                    Console.WriteLine("Current val of i: " + 1);
                    break;
                case 'V':
                    num = 5;
                    break;
                case 'X':
                    num = 10;
                    break;
                case 'L':
                    num = 50;
                    break;
                case 'C':
                    num = 100;
                    break;
                case 'D':
                    num = 500;
                    break;
                case 'M':
                    num = 1000;
                    break;
                
            }
            return num;
        }
    }
}