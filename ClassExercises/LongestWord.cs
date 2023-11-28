using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    internal class LongestWord
    {
        public static string FindLongestWord(string input) 
        {
            
            string[] words = input.Split(" ");

            string outPut = words[0];

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                if (word.Length > outPut.Length)
                {
                    outPut = word;
                }
                
            }
            return outPut;

        }
    }
}
