using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingKata.UnitTests
{
    internal class GreetName
    {
        public string ReturnGreetName(string name)
        {
            if(name == "")
            {
                return ("Hello, my friend.");
            }

            if(name == name.ToUpper())
            {
                return ("HELLO " + name.ToUpper() + "!");
            }

            return ("Hello" + ", " + name + ".");

        }

        public string ReturnGreetName(string[] names)
        {
            var newString = "Hello, ";
            var strArrLength = names.Length;
            //Console.WriteLine(strArrLength);
            if (strArrLength == 2)
            {
                return  (newString + names[0] + " and " + names[1] + ".");
            }

            
            for (int i = 0; i < strArrLength; i++)
            {               
                if (i == strArrLength - 1)
                {
                    Console.WriteLine("arr len in if statement" + (strArrLength - 1));
                    Console.WriteLine("value of i is :" + names[i]);
                    newString += ("and " + names[i] + ".");
                    break;
                }
                newString += names[i] + ", ";
                Console.WriteLine(newString);
            }
            
            return newString;
            
        }

    }
}
