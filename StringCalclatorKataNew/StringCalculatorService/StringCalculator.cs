using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringCalculatorService
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            int sum = 0;
            char delimiter = ',';
            bool negativeNumberFound = false;
            //string negativeValue = "";

            if (numbers == "")
            {
                return sum;
            }
            if(numbers.Length == 1)
            {               
                sum = Convert.ToInt32(numbers);               
            }

            if(numbers.Length > 1)
            {

                // Requirement to support different delimiter
                //if first two element values in string are equal to "//" then take the third value ";" as delimiter
                if (numbers.Substring(0, 2) == "//")
                {
                    //change the delimiter from ',' set above to ';' 
                    delimiter = Convert.ToChar(numbers.Substring(2, 1));
                    Console.WriteLine("Delimiter : " + delimiter);
                    // slice first four chars in "//;\n1;2\n3" to get "2\n3"
                    numbers = numbers.Substring(4);// will give "1;2\n3"
                }
                Console.WriteLine();

                string[] val = numbers.Split(delimiter);// will give [2,3]
                List<string> strList = new List<string>();
                
                for (int i = 0; i < val.Length; i++)
                {
                    // loop through the string[]
                    strList.AddRange(val[i].Split('\n'));// split numbers with \n as delimiter
                    
                }
                //loop through List to add the numbers in string
                /*
                foreach(string num in strList)
                {
                    sum += Int32.Parse(num);
                }*/

                //address negative numbers in the input string
                foreach(string num in strList)
                {
                    if(Int32.Parse(num) < 0)
                    {
                        negativeNumberFound = true;
                    }
                    Console.WriteLine("num: "+ num);
                    sum += Int32.Parse(num);
                }

                if (negativeNumberFound)
                {
                    throw new System.ArgumentException("negatives not allowed");
                }
                
            }
            return sum;           

        }

        
    }
}
