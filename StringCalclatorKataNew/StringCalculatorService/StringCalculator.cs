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
                Console.WriteLine();
                string[] val = numbers.Split(delimiter);
                List<string> strList = new List<string>();
                
                for (int i = 0; i < val.Length; i++)
                {
                    strList.AddRange(val[i].Split('\n'));
                    //sum += int.Parse(val[i]);
                    ////sum = Convert.ToInt32(numbers);
                    //Console.WriteLine("SUM: " + sum);
                }
                foreach(string num in strList)
                {
                    sum += Int32.Parse(num);
                }
            }

            //if((numbers.Length > 1) || (numbers.Contains('\n')) || (numbers.Contains(',')))
            //{
            //    Console.WriteLine("In Regex");
            //    //string[] newVal = numbers.Split('\n', ',');
            //    string delimiter = @",\n";
            //    foreach (Match m in Regex.Matches(numbers, delimiter))
            //    {
            //        Console.WriteLine("m.Groups[1].Value: " + m.Groups[1].Value);
            //    }
            //}


            return sum;


        }
    }
}
