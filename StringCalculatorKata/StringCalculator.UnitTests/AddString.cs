using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.UnitTests
{
    class AddString
    {
        public int Add(string numbers)
        {
            int sum = 0;
            char delimiter = ',';

            bool negativeValues = false;
            string negativeNumber = "";
            if (numbers == "")
            {
                return 0;
            }

            if (numbers.Length == 1)
            {
                return Int32.Parse(numbers);
            }
            // Requirement to support different delimiter
            //if first two element values in string are equal to "//" and take the third value ";" as delimiter
            if (numbers.Substring(0, 2) == "//")
            {
                delimiter = Convert.ToChar(numbers.Substring(2, 1));
                Console.WriteLine("Delimiter : " + delimiter);
                // slice first four chars in "//;\n1;2\n3"
                numbers = numbers.Substring(4);
            }

            // split numbers string and add to a list
            var strArr = numbers.Split(delimiter);
            List<string> strList = new List<string>();
			[1,2\n3]

            for (int i = 0; i < strArr.Length; i++)
            {
                //Console.WriteLine("After slicing 4 chars: " + strArr[i]);
                
                // split again with newline as delimiter that again returns an array
                strList.AddRange(strArr[i].Split('\n'));

                
            }

			// strList = [-1,2,3]
            foreach(string num in strList)
            {
                if (Int32.Parse(num) < 0)
                {
                    negativeValues = true;
                    negativeNumber = negativeNumber + num;
                    Console.WriteLine("Negative value " + negativeNumber);
                }
                Console.WriteLine("num = " + num);
                sum += Int32.Parse(num.Trim());// eliminate spaces after commas in strList
                Console.WriteLine("Sum = " + sum);
            }
            if (negativeValues)
            {
                throw new System.ArgumentException("negatives not allowed");
            }

            return sum;
        }
    }
}
