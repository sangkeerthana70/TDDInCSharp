using System;


namespace Mastermind.Service
{
    public class CodeGenerator : ICodeGenerator
    {
        public int[] Generate()
        {

            //int[] randomCode = new int[4];
            //Random random = new Random();
            //for (var i = 0; i < 4; i++)
            //{
            //    randomCode[i] = random.Next(1, 7);
            //}

            return new int[] { 1, 2, 3, 4 };
        }
    }
}