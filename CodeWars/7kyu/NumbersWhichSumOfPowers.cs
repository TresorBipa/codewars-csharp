/*
https://www.codewars.com/kata/560a4962c0cc5c2a16000068/csharp

7 kyu
Numbers Which Sum of Powers of Its Digits Is The Same Number

Not considering number 1, the integer 153 is the first integer having this property: 
the sum of the third-power of each of its digits is equal to 153. 
Take a look: 153 = 1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153

The next number that experiments this particular behaviour is 370 with the same power.

Write the function eq_sum_powdig(), that finds the numbers below a given upper limit hMax that fulfill this property but with different exponents as a power for the digits.

eq_sum_powdig(hMax, exp): ----> sequence of numbers (sorted list) (Number one should not be considered).

Let's see some cases:

eq_sum_powdig(100, 2) ----> []

eq_sum_powdig(1000, 2) ----> []

eq_sum_powdig(200, 3) ----> [153]

eq_sum_powdig(370, 3) ----> [153, 370]
Enjoy it !!
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class NumbersWhichSumOfPowers
    {
        public static long[] EqSumPowDig(long hmax, int exp)
        {
            return Enumerable.Range(2, (int) hmax - 1)
                .Where(i => (int) $"{i}".Sum(c => Math.Pow(long.Parse($"{c}"), exp)) == i)
                .Select(i => (long) i)
                .ToArray();


            // List<long> result = new List<long>();
            // for (long i = 2; i <= hmax; i++)
            // {
            //     if (i == i.ToString().Select(d => Math.Pow((int) char.GetNumericValue(d), exp)).Sum())
            //         result.Add(i);
            // }
            //
            // return result.ToArray();
        }
    }
}