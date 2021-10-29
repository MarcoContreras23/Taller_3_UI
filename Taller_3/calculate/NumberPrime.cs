using System;

namespace Taller_3
///
/// <summary>
/// @author: Marco Contreras
/// </summary>
{
    /// <summary>
    /// Class in charge of calculating whether the number is prime or not
    /// </summary>
    public class NumberPrime
    {
        public long number { get; set; }
        public static bool flag {get; set;} = true;
        private static readonly object lockObj = new object();


        public NumberPrime(long NewNumber)
        {
            number = NewNumber;
        }
        public static long firstDivGreaterThan(long num)
        {
            lock (lockObj) {
                int INC = (num % 2 == 1) ? 2 : 1;
                long lim = (long)Math.Sqrt(num);
                int ini = (num % 2 == 0) ? 3 : 2;

                for (long i = ini; i < lim / 2; i += INC)
                {
                    if (num % i == 0 || !flag)
                    {
                        flag = false;
                        return i;
                    }
                }
            }

            return num;
        }

        public static long firstDivMiddle(long num)
        {
            lock (lockObj) {
                int INC = (num % 2 == 1) ? 2 : 1;
                long lim = (long)Math.Sqrt(num);
                long ini = (lim / 2) < 2 ? 2 : lim / 2;

                for (long j = ini; j <= lim; j += INC)
                {
                    if (num % j == 0 || !flag)
                    {
                        flag = false;
                        return j;
                    }
                }
            }

            return num;
        }


        public static bool isPrime(long num)
        {

            return (firstDivGreaterThan(num) == num && firstDivMiddle(num) == num);
            //return (firstDivGreaterThan(num) == num);
        }

        public static void reset() {
            flag = true;
        }

    }
}
