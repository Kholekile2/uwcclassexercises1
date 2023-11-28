using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    internal class Vowels
    {
        private static bool IsAVowel(char letter)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            for (int index = 0; index < vowels.Length; index++)
            {
                if (vowels[index] == letter)
                {
                    return true;

                }
            }
            return false;
        }
        public static string RemoveallVowels(string letters) 
        {
            string returnString = " ";
            for (int index = 0; index < letters.Length; index++)
            {
                char letter = letters[index];
                bool vowel = IsAVowel(letter);

                if (!vowel)
                {
                    returnString += letter;
                }
            }
            return returnString;
        }

        
    }
}
