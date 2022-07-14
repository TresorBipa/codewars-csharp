/*
https://www.codewars.com/kata/542c0f198e077084c0000c2e/csharp

7 kyu
Count the divisors of a number

Count the number of divisors of a non-negative integer n.

Random tests go up to n = 500000.

Examples
Kata.Divisors(4)  -> 3 -- 1, 2, 4
Kata.Divisors(5)  -> 2 -- 1, 5
Kata.Divisors(12) -> 6 -- 1, 2, 3, 4, 6, 12
Kata.Divisors(30) -> 8 -- 1, 2, 3, 5, 6, 10, 15, 30
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class CountDivisorsOfNumber
    {
        public static int Divisors(int n)
        {
            return Enumerable.Range(1, n).Count(i => n % i == 0);


            // var div = 0;
            // for (var i = 1; i <= n; i++)
            //     if (n % i == 0)
            //         div++;
            //
            // return div;
        }
    }
}