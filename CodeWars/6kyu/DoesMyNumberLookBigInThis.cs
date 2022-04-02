/*
https://www.codewars.com/kata/5287e858c6b5a9678200083c/csharp

6 kyu
Does my number look big in this?

A Narcissistic Number is a positive number which is the sum of its own digits, 
each raised to the power of the number of digits in a given base. 
In this Kata, we will restrict ourselves to decimal (base 10).

For example, take 153 (3 digits), which is narcisstic:

    1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153
and 1652 (4 digits), which isn't:

    1^4 + 6^4 + 5^4 + 2^4 = 1 + 1296 + 625 + 16 = 1938
The Challenge:

Your code must return true or false depending upon whether the given number is a Narcissistic number in base 10.

Error checking for text strings or other invalid inputs is not required, only valid positive non-zero integers will be passed into the function.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class DoesMyNumberLookBigInThis
    {
        public static bool Narcissistic(int value)
        {
            return $"{value}".Sum(c => Math.Pow(c - '0', $"{value}".Length)) == value;
            // return $"{value}".Sum(c => (long) Math.Pow(c - '0', $"{value}".Length)) == value;
            // return $"{value}".Sum(c => Math.Pow(c - '0', (int) Math.Log10(value) + 1)) == value;
            // return value.ToString().Sum(c => (long) Math.Pow(c - '0', value.ToString().Length)) == value;
            // return value.ToString().Sum(c => (long) Math.Pow(int.Parse(c.ToString()), value.ToString().Length)) == value;
        }
    }
}