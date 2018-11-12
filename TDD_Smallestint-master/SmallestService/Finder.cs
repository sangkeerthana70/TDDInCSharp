using System;
using System.Linq;

namespace SmallestService
{
    public class Finder
    {
        // FindSmallestInt method to tackle UnitTest1.cs test cases
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

        // FindClosestIntToZero to tackle UnitTest2.cs
        public int FindClosestIntToZero(int[] input)
        {
            var result = int.MaxValue;
            if (input.Length == 0)
            {
                throw new System.ArgumentException("Array is Empty");
            }

            foreach (int num in input)
            {
                //Math.Abs method Returns the absolute value of a specified number.
                if (Math.Abs(num) < Math.Abs(result))
                {
                    result = num;
                }

                if ((Math.Abs(num) == Math.Abs(result)) && (num < result))
                {
                    result = num;
                }

            }
            Console.WriteLine("Result: " + result);
            return result;
           
            
        }
    }
}
