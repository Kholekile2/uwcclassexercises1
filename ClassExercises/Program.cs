using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace ClassExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {2,4,6,9};
            bool isOddNumber = OddNumbers.CheckOddNumbers(numbers);

            if (isOddNumber)
            {
                Console.WriteLine("The array contains an odd number " + isOddNumber);
            }
            else
            {
                Console.WriteLine("The array does not contains an odd number "  + isOddNumber);
            }

           /* string letters = "Hello World";
           
            string removedVowelsString = Vowels.RemoveallVowels(letters);

            Console.WriteLine(removedVowelsString);




            int[] numbers2 = { -1, 2, 4, 6, 9 };
            string posNeg = PositiveNegative.CheckPositiveNegativeNumbers(numbers2);
            
            Console.WriteLine(posNeg);

            //Console.WriteLine(numbers2[PosNeg]);
            /*  if (PosNeg)
              {
                  Console.WriteLine("Total Positive: " + PosNeg);
              }
              else
              {
                  Console.WriteLine("Total Negative: " + PosNeg);
              }
            */





            /*int[] numbers3 = { };
            double average = AverageNumbers.AverageOfTheNumbers(numbers3);
            Console.WriteLine("The average is " + average);*/



            string sentence = "Learning Prpgramming is cool";
            string longest = LongestWord.FindLongestWord(sentence);
            Console.WriteLine("The longest word is " + longest);
        }
    }
}
