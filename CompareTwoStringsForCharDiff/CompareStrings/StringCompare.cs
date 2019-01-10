using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareStrings
{
    public class CompareTwoStrings
    {
        public int CheckLengthOfTwoStrings(string a, string b)
        {
            int strLength = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if (a.Length == b.Length)
                {
                    strLength = a.Length;
                }
                else
                {
                    throw new System.ArgumentException("Array length is not equal");
                }

            }
            return strLength;
        }
        
    }
}
