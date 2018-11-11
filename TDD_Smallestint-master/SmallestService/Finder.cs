using System;
using System.Linq;

namespace SmallestService
{
    public class Finder
    {
        public int FindSmallestInt(int[] input)
        {
            int result = int.MaxValue;
            //Console.WriteLine("Result: " + result);

            if (input.Length == 0)
            {
                throw new System.ArgumentException("Array is Empty");
            }
            
            foreach (int num in input)
            {
                if (num < result)
                {
                    result = num;
                }
            }
            return result;            
        }

        public int FindClosestIntToZero(int[] input)
        {
            if (input.Length == 0)
            {
                throw new System.ArgumentException("Array is Empty");
            }
            else
            {
                return input[0];
            }
            
        }
    }
}
