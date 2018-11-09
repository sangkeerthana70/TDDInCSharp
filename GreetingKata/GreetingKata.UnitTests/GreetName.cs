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
            var newString = "";
            var strArrLength = names.Length;
            Console.WriteLine(strArrLength);
            for (int i = 0; i < strArrLength; i++)
            {
                if (strArrLength == 2)
                {
                    newString = ("Hello, " + names[i]);
                    i++;
                }
                newString += (" and " + names[i] + ".");
               
            }
            return newString;
            
        }

    }
}
