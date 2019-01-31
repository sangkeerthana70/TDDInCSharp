using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorService
{
    public class StringCalculator
    {
        

        

        public static int Add(string numbers)
        {
            int sum = 0;
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

                //stringnum = "10,20,30,40";
                string[] val = numbers.Split(',');
                
                for (int i = 0; i < val.Length; i++)
                {
                    sum += int.Parse(val[i]);


                    //sum = Convert.ToInt32(numbers);
                    Console.WriteLine(sum);

                }

            }
            return sum;


        }
    }
}
