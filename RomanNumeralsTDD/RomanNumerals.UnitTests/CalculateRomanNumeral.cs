using System;

namespace RomanNumerals.UnitTests
{
    internal class CalculateRomanNumeral
    {
        
        public int FindRomanNumeral(string romanNumeral)
        {
            //int result = 0;
            int tempResult = 0;
            int result = 0;
            int currVal = 0;
            int nextVal = 0;
            
            for (int i = 0; i < romanNumeral.Length; i++)
            {
                Console.WriteLine("loop " + i);
                // get curr letter's numeric value
                currVal = RomanToNumeric(romanNumeral[i]);
                // if it is the last to one value just return currVal
                if (i == romanNumeral.Length - 1)
                {
                    result += currVal;
                }
                else
                {
                    //get next letter's numeric value
                    nextVal = RomanToNumeric(romanNumeral[i + 1]);
                    
                    if (currVal < nextVal)
                    {
                        
                        result += (nextVal - currVal);
                        Console.WriteLine("res from if " + result);


                        i++;
                    }
                    else
                    {
                        result += currVal;
                        Console.WriteLine("Res from else " + result);
                    }
                }
            }
            
            return result;            
        }

        private int RomanToNumeric(char r)
        {
            var num = 0;
            switch (r)
            {
                case 'I':
                    num = 1;              
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
                default:
                    num = 0;
                    break;
                
            }
            return num;
        }
    }
}