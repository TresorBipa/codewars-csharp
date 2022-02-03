/*
https://www.codewars.com/kata/55e0a2af50adf50699000126/csharp

6 kyu
Pure odd digits primes

Primes that have only odd digits are pure odd digits primes, obvious but necessary definition. 
Examples of pure odd digit primes are: 11, 13, 17, 19, 31... If a prime has only one even digit does not belong to pure odd digits prime, 
no matter the amount of odd digits that may have.

Create a function, only_oddDigPrimes(), that receive any positive integer n, and output a list like the one below:

[number pure odd digit primes below n, largest pure odd digit prime smaller than n, smallest pure odd digit prime higher than n]

Let's see some cases:

only_oddDigPrimes(20) ----> [7, 19, 31]
///7, beacause we have seven pure odd digit primes below 20 and are 3, 5, 7, 11, 13, 17, 19
19, because is the nearest prime of this type to 20
31, is the first pure odd digit that we encounter after 20///

only_oddDigPrimes(40) ----> [9, 37, 53]
In the case that n, the given value, is a pure odd prime, should be counted with the found primes and search for the immediately below and the immediately after.

Happy coding!!
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars._6kyu
{
    public static class PureOddDigitsPrimes
    {
        private static bool isOddPrime(long p)
        {
            var s = p.ToString();
            if (p < 2 || s.Contains("0") || s.Contains("2") || s.Contains("4") || s.Contains("6") ||
                s.Contains("8")) return false;

            for (long i = 2; i <= (int) Math.Sqrt(p); i++)
            {
                if (p % i == 0) return false;
            }

            return true;
        }

        public static long[] OnlyOddDigPrimes(long n)
        {
            var result = new List<long>();

            for (long i = 3; i <= n; i += 2)
            {
                if (isOddPrime(i)) result.Add(i);
            }

            while (true)
            {
                if (isOddPrime(++n)) break;
            }

            return new[] {result.Count, result.Max(), n};
        }
    }
}


