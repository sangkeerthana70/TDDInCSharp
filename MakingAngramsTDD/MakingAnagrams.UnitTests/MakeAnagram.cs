using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingAnagrams.UnitTests
{
    class MakeAnagram
    {
        internal int FindLetters(string a, string b)
        {
            //test case2
            if (a.Length == b.Length)
            {
                Console.WriteLine("Length is equal");
            }


           //test case3
           //Compare string a with string b
            int mismatchCount = 0;
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("outer loop: " + a[i]);
                bool match = false;
                for (int j = 0; j < b.Length; j++)
                {
                    Console.WriteLine("Inner loop: " + b[j]);
                    if(a[i] == b[j])
                    {
                        Console.WriteLine("match");
                        match = true;
                        break;
                    }
                } 
                if (!match)
                {
                    Console.WriteLine("no match");
                    mismatchCount++;
                    Console.WriteLine("mismatchCount " + mismatchCount);
                }
            }
            //compare string b with string a
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine("outer loop: " + b[i]);
                bool match = false;
                for (int j = 0; j < a.Length; j++)
                {
                    Console.WriteLine("Inner loop: " + a[j]);
                    if (b[i] == a[j])
                    {
                        Console.WriteLine("match");
                        match = true;
                        break;
                    }
                }
                if (!match)
                {
                    Console.WriteLine("no match");
                    mismatchCount++;
                    Console.WriteLine("mismatchCount " + mismatchCount);
                }
            }
            Console.WriteLine("Mis match Letter Count: " + mismatchCount);
            return mismatchCount;

           
        }

    }
}
