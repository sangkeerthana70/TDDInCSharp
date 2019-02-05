using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzService
{
    public class FizzBuzzer
    {
        public static string FizzOrBuzz(int input)
        {
            string output = input.ToString();

            if(input % 3 == 0)
            {
                Console.WriteLine("in mod 3");
                Console.WriteLine("number : " + input);
                output = "Fizz";
            }
            if(input % 5 == 0)
            {
                Console.WriteLine("in mod 5");
                Console.WriteLine("number : " + input);
                output = "Buzz";
            }
            if((input % 3 == 0) && (input % 5 == 0))
            {
                Console.WriteLine("in mod 3 and 5");
                Console.WriteLine("number : " + input);
                output = "FizzBuzz";
            }
            
            return output;
            
        }
    }
}
