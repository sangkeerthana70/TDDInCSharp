using System;
namespace LeftRotateArray.UnitTests
{
    public class RotateArray
    {
        public static int GiveNewRotatedArray(int[] inputArr)
        {
            
                return 5;

        }


    

        public static int GiveNewRotatedArray(int[] inputArr, int numToRotate)
        {
            //int[] newArray = new int[] { };

            for(int i = 0; i <= inputArr.Length; i++)
            {
                inputArr[i - 1] = inputArr[i];
                
            }
            //newArray[inputArr.Length]
            var newArray = inputArr[inputArr.Length - 1];
            Console.WriteLine(newArray);
            return newArray;
            
        }
    }
}