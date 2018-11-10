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
                return ("HELLO " + name + "!");
            }

            return ("Hello" + ", " + name + ".");

        }

        public string ReturnGreetName(string[] names)
        {
            var output1 = "Hello";
            var output2 = " AND HELLO";
            var strArrLength = names.Length;
            var lowerCount = 0;
            var upperCount = 0;
            var upperWord = false;
            var totalUpper = 0;
            var totalLower = 0;
            
            //determine total number of uppercase and lowercase words
            for (int i = 0; i < strArrLength; i++)
            {
                if (names[i] == names[i].ToUpper())
                {
                    totalUpper++;
                }
                else
                {
                    totalLower++;
                }
            }

            for (int i = 0; i < strArrLength; i++)
            {   

                // determine if it is uppercase word; increment appropriate word counter
                if (names[i] == names[i].ToUpper())
                {
                    upperWord = true;
                    upperCount++;
                }
                else
                {
                    upperWord = false;
                    lowerCount++;
                }
                
                if (!upperWord) // Handle lower case words
                {
                    if (lowerCount < totalLower) // not the last word
                    {
                        output1 += ", " + names[i];
                    }
                    else // last word
                    {
                        if (lowerCount == 1) // just one word
                        {
                            output1 += ", " + names[i] + ".";
                        }
                        else if (lowerCount == 2) // just two words
                        {
                            output1 += " and " + names[i] + ".";
                        }
                        else // more than two words - Oxford comma required
                        {
                            output1 += ", and " + names[i] + ".";
                        }
                    }
                }
                else // Handle upper case words
                {
                    if (upperCount < totalUpper) // not the last word
                    {
                        if (upperCount == 1)
                        {
                            output2 += " " + names[i];
                        }
                        else
                        {
                            output2 += ", " + names[i];
                        }
                    }
                    else // last word
                    {
                        if (upperCount == 1)
                        {
                            output2 += " " + names[i] + "!";
                        }
                        else if (upperCount == 2) // more than two words - Oxford comma required
                        {
                            output2 += " AND " + names[i] + "!";
                        }
                        else // more than two words - Oxford comma required
                        {
                            output2 += ", AND " + names[i] + "!";
                        }
                    }
                }
            }

            if (upperCount == 0)
            {
                return output1;
            }
            else
            {
                return output1 + output2;
            }
                     
        }
    }
}
