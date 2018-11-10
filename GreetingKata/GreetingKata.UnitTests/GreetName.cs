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
            if (name == "")
            {
                return ("Hello, my friend.");
            }

            if (name == name.ToUpper())
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

            List<string> namesList = new List<string>();

            // Handle requirements 7 and 8
            // Create a List
            for (int i = 0; i < strArrLength; i++)
            {
                Console.WriteLine(names[i]);
                // should not split names surrounded by Quotes ""Charlie, Dianne"" but just trim the qoute around it
                if (names[i].Substring(0, 1) == "\"")
                {
                    namesList.Add(names[i].Trim('"'));
                }
                else
                {
                    //AddRange will return an array and we are adding that array to this namesList EG:[Charlie, Dianne]
                    namesList.AddRange(names[i].Split(','));
                }
            }

            //determine total number of uppercase and lowercase words
            foreach (string name in namesList)
            {
                if (name == name.ToUpper())
                {
                    totalUpper++;
                }
                else
                {
                    totalLower++;
                }
            }


            string tname;
            foreach (string name in namesList)
            {
                tname = name.Trim(
                    );
                // determine if it is uppercase word; increment appropriate word counter
                if (tname == tname.ToUpper())
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
                        output1 += ", " + tname;
                    }
                    else // last word
                    {
                        if (lowerCount == 1) // just one word
                        {
                            output1 += ", " + tname + ".";
                        }
                        else if (lowerCount == 2) // just two words
                        {
                            output1 += " and " + tname + ".";
                        }
                        else // more than two words - Oxford comma required
                        {
                            output1 += ", and " + tname + ".";
                        }
                    }
                }
                else // Handle upper case words
                {
                    if (upperCount < totalUpper) // not the last word
                    {
                        if (upperCount == 1)
                        {
                            output2 += " " + tname;
                        }
                        else
                        {
                            output2 += ", " + tname;
                        }
                    }
                    else // last word
                    {
                        if (upperCount == 1)
                        {
                            output2 += " " + tname + "!";
                        }
                        else if (upperCount == 2) // more than two words - Oxford comma required
                        {
                            output2 += " AND " + tname + "!";
                        }
                        else // more than two words - Oxford comma required
                        {
                            output2 += ", AND " + tname + "!";
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
