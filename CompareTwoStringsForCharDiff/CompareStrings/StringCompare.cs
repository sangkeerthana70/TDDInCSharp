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

        public int[] FindDifferenceBetweenTwoStrings(string a, string b, int len)
        {
            int[] arr = new int[len];
            int difference;
            int totChangeScore = 0;
            for (int i = 0; i < len; i++)
            {               
                if (a[i] == b[i])
                {
                    difference = 0;
                    arr[i] = difference;

                }
                else
                {
                    int castCharOfa = (int)a[i];
                    
                    int castCharOfb = (int)b[i];
                    
                    difference = castCharOfb - castCharOfa;
                    
                    totChangeScore += difference;
                    arr[i] = difference;

                }
            }
            //foreach(int item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            
            Console.WriteLine(string.Join(" ", arr));
            return arr;

        }
        
    }
}
