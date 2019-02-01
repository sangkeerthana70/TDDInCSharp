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
                    // slice first four chars in "//;\n1;2\n3"
                    numbers = numbers.Substring(4);
                }
                Console.WriteLine();
                string[] val = numbers.Split(delimiter);
                List<string> strList = new List<string>();
                
                for (int i = 0; i < val.Length; i++)
                {
                    strList.AddRange(val[i].Split('\n'));
                    //sum += int.Parse(val[i]);
                    //Console.WriteLine("SUM: " + sum);
                }
                foreach(string num in strList)
                {
                    sum += Int32.Parse(num);
                }
            }
            return sum;           

        }

        
    }
}
