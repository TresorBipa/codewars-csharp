/*
https://www.codewars.com/kata/54b45c37041df0caf800020f/csharp

7 kyu
Greatest Common Divisor Bitcount

The objective is to write a method that takes two integer parameters and returns a single integer equal to the number of 1s in the binary representation of the greatest common divisor of the parameters.

Taken from Wikipedia: "In mathematics, the greatest common divisor (gcd) of two or more integers, when at least one of them is not zero, 
is the largest positive integer that divides the numbers without a remainder. For example, the GCD of 8 and 12 is 4."

For example: the greatest common divisor of 300 and 45 is 15. 
The binary representation of 15 is 1111, so the correct output would be 4.

If both parameters are 0, the method should return 0. 
The function must be able to handle negative input.
*/

using System;
using System.Linq;
using System.Numerics;

namespace CodeWars
{
    public class GreatestCommonDivisorBitcount
    {
        public static int GcdBinary(int x, int y)
        {
            return Convert.ToString((int) BigInteger.GreatestCommonDivisor(x, y), 2).Count(c => c == '1');
            //return Convert.ToString((int) BigInteger.GreatestCommonDivisor(x, y), 2).Replace("0", "").Length;
            //return Convert.ToString((int) BigInteger.GreatestCommonDivisor(x, y), 2).Split('1').Length - 1;
        }

        // public static int GcdBinary(int x, int y) => Convert.ToString(gcd(x, y), 2).Count(c => c == '1');
        // private static int gcd(int x, int y) => y == 0 ? Math.Abs(x) : gcd(y, x % y);
    }
}