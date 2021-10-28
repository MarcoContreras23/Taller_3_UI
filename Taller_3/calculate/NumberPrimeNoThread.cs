using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_3.calculate
{
    class NumberPrimeNoThread


    {
        public long number { get; set; }

        public NumberPrimeNoThread(long NewNumber)
        {
            number = NewNumber;
        }

        public static long CalulatePrime(long num)
        {
            int INC = (num % 2 == 1) ? 2 : 1;
            long lim = (long)Math.Sqrt(num);

            for (long i = 2; i <= lim ; i += INC)
            {
                if (num % i == 0 )
                {
                    return i;
                }
            }
            return num;
        }

        public static bool isPrime(long num)
        {
            return (CalulatePrime(num) == num );
            //return (firstDivGreaterThan(num) == num);
        }
    }
}
