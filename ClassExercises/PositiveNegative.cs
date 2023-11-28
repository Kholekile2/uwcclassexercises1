using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    internal class PositiveNegative
    {
       
        public static string CheckPositiveNegativeNumbers(int[] Number) 
        {
            int positive = 0;
            int negative = 0;

            for (int i = 0; i < Number.Length; i++)
            {
                int n = Number[i]; ;

                if (n < 0)
                {
                    negative =  negative + 1;
                }
                else
                {
                    positive = positive + 1;
                }

                /*   foreach (int n in Number)
                   {
                       if (n < -5)
                       {
                           return true;
                       }
                   }*/
                //int number = Number[i];

                /*if (number > 0)
                {
                    return true;
                }*/
            }


            string returnString = "Total Poisitive: " + positive + " Total Negative: " + negative;



            return returnString; 
        
        }
    }
}
