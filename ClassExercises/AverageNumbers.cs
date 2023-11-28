using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    internal class AverageNumbers
    {
        public static double AverageOfTheNumbers(int[] inputNumbers)
        {
            string input = Console.ReadLine();

            string[] numberString = input.Split(' ');

            if (numberString.Length != 5 )
            {
                return 0;
            }

            int[] number = Array.ConvertAll(numberString, s => int.Parse(s));

            int sum = 0;

            foreach (int i in number)
            {
                sum += i;
                
            }
            
            
            double sum2 = (double)sum/number.Length;
            
            
            return sum2;
            
        }
    }
}
