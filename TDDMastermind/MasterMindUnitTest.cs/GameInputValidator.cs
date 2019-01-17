namespace Mastermind.Service
{
    public class GameInputValidator
    {
        public bool IsValid(int[]attempt)
        {
            if (attempt.Length > 4 || attempt.Length < 4)
            {
                throw new System.ArgumentException("Length has to be four digits");
            }

            return true;
        }
        public bool InputOutofBounds(int[]attempt)
        {
            
            for(var i = 0; i < attempt.Length; i++)
            {
                if(attempt[i] > 6 || attempt[i] < 1)
                {
                    throw new System.ArgumentException("Numbers should be between 1 and 6");
                }

                
            }
            return true;
        }

        public bool InputNotUnique(int[]attempt)
        {
             
            for(var i = 0; i < attempt.Length - 1; i++)
            {
                int j = i + 1;
               if (attempt[i] != attempt[j])
               {
                    j++;
               }
                else
                {
                    throw new System.ArgumentException("All numbers must be unique ");
                }
            }
            return true;
        }
    }
}