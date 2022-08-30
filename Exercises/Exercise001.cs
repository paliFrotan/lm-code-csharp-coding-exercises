using System;
using System.Collections.Generic;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return word;
            }
            char[] letters = word.ToCharArray();
            letters[0] = char.ToUpper(letters[0]);
            return new string(letters);
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            char[] firstNameLetters = firstName.ToCharArray();
            char[] lastNameLetters = lastName.ToCharArray();
            firstNameLetters[0] = char.ToUpper(firstNameLetters[0]);
            lastNameLetters[0] = char.ToUpper(lastNameLetters[0]);
            return new string(firstNameLetters[0] + "." + lastNameLetters[0]);
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            try
            {
                try
                {
                    double currentRate = (vatRate + 100) / 100;
                    double result = (originalPrice * currentRate);
                    return Math.Round(result, 2);
                }
                catch (Exception ex1) when (originalPrice < 0)
                {
                    string message = "Price cannot be negative. Please enter a valid price.";
                    throw new ArgumentException(message, ex1);
                }
            }
            catch (Exception ex) when (vatRate < 0)
            {
                string message = "VAT cannot be negative. Please enter a valid VAT.";
                throw new ArgumentException(message, ex);
            }
            // checking if commit working

            // NB: Look in Exercise001Tests.cs
            //     There is a test with commented out assertions.
            //     For an extra challenge, uncomment those assertions and make that test pass too.


        }


        public string Reverse(string sentence)
        {
            // Replace the exception statement below with your code!
            //throw new NotImplementedException();

            if (string.IsNullOrEmpty(sentence))
            {
                return sentence;
            }
            char[] textArray = sentence.ToCharArray();
            Array.Reverse(textArray);

            string reversedText = new string(textArray);
            return reversedText;

        }

        public int CountLinuxUsers(List<User> users)
        {
            if ((users != null) && (!(users.Count == 0)))
            { 

                int count = 0;
            
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].Type.Equals("Linux"))
                    {
                        count++;
                    };
                }  
                return count;
            };
            return 0;
        }
    }
}
