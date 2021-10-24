using System;

namespace Taller_3

/*
*@author: Marco Contreras
*/

{


    /*
    *Class in charge of calculating whether the number is prime or not
    */
    /// <summary>
    /// 
    /// </summary>
    public class NumberPrime
    {
        public long number { get; set; }
        

        public NumberPrime(long NewNumber)
        {
            number = NewNumber;
        }

       

        public static long firstDivGreaterThan(long num)
        {
            int INC = (num % 2 == 1) ? 2 : 1;
            long lim = (long)Math.Sqrt(num);

            for (long i = 2; i <= lim/2; i += INC)
            {
                if (num % i == 0)
                {
                    return i;
                }
            }
            return num;
        }

        public static long firstDivMiddle(long num)
        {
            int INC = (num % 2 == 1) ? 2 : 1;
            long lim = (long)Math.Sqrt(num);

            for (long j = (lim /2)+2; j <= num; j += INC)
            {
                if (num % j == 0)
                {
                    return j;
                }
            }
            return num;
        }


        public static bool isPrime(long num)
        {

            return (firstDivGreaterThan(num) == num  && firstDivMiddle(num) == num);
            //return (firstDivGreaterThan(num) == num);
        }


       



    }
}
