/*
https://www.codewars.com/kata/56b58d11e3a3a7cade000792/csharp

7 kyu
Sexy Primes <3

Sexy primes are pairs of two primes that are 6 apart. 
In this kata, your job is to complete the function sexy_prime(x, y) which returns true if x & y are sexy, false otherwise.

Examples:

sexy_prime(5,11)
--> True

sexy_prime(61,67)
--> True

sexy_prime(7,13)
--> True

sexy_prime(5,7)
--> False

sexy_prime(1,7)
--> False
( 1 is not considered prime )

Note: x & y are always positive integers > 0, 
but they are not always in order of precendence...you can be given either (5,11) or (11,5). 
Both are equally valid.
*/

using System;

namespace CodeWars
{
    public class SexyPrimes3
    {
        public static bool SexyPrime(int x, int y)
        {
            for (var i = 3; i < x; i += 2)
            {
                if (x % i == 0) return false;
            }

            return Math.Abs(x - y) == 6;
        }
    }
}