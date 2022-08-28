using System;
namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            if (input == "")
            {
                return false;
            }

            string alphabetSet = "abcdefghijklmnopqrstuvwxyz";
            char aChar = ' ';
            int count = 0;
            for (int j = 0; j < alphabetSet.Length; j++)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    count = 0;        
                    aChar = input[i];

                    if (char.IsUpper(aChar) || char.IsLower(aChar))
                    {
                        aChar = char.ToLower(input[i]);
                        if (alphabetSet[j] == aChar)
                        {
                            count++;
                            break;
                        }
                    }
                    else
                    {
                        if (char.IsDigit(aChar) || aChar == ' ' || aChar == '_')
                        {
                            continue;
                        }
                        else
                        {
                            return false; 
                        }
                    }
                }
                if (count == 0)
                {
                    return false; 
                }
            }
            return true; 
        }
    }
}
