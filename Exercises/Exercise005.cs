using System;
namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            bool inAlphabetSet = false;
            if (!string.IsNullOrEmpty(input))
            {
                string alphabetSet = "abcdefghijklmnopqrstuvwxyz";
            
                for (int j = 0; j < alphabetSet.Length; j++)
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        inAlphabetSet = false;        
                        char checkCharInSet = input[i];

                        if (char.IsUpper(checkCharInSet) || char.IsLower(checkCharInSet))
                        {
                            checkCharInSet = char.ToLower(input[i]);
                            if (alphabetSet[j] == checkCharInSet)
                            {
                                inAlphabetSet = true;
                                break;
                            }
                        }
                        else
                        {
                            if (!(char.IsDigit(checkCharInSet) || checkCharInSet == ' ' || checkCharInSet == '_'))
                            {
                                break;
                            }
                        }
                    }
                    if (!inAlphabetSet)
                    {
                        return inAlphabetSet; 
                    }
                }
            };
            return inAlphabetSet; 
        }
    }
}
