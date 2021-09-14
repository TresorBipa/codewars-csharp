/*
https://www.codewars.com/kata/56b22765e1007b79f2000079/csharp

7 kyu
Narcissistic Numbers

A Narcissistic Number is a number of length n in which the sum of its digits to the power of n is equal to the original number. 
If this seems confusing, refer to the example below.

Ex: 153, where n = 3 (number of digits in 153)
13 + 53 + 33 = 153

Write a method is_narcissistic(i) (in Haskell: isNarcissistic :: Integer -> Bool) which returns whether or not i is a Narcissistic Number.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class NarcissisticNumbers
    {
        public static bool IsNarcissistic(long n)
        {
            // return n.ToString().Sum(c => (long) Math.Pow(char.GetNumericValue(c), n.ToString().Length)) == n;
            // return n.ToString().Sum(c => (long) Math.Pow(long.Parse(c.ToString()), n.ToString().Length)) == n;
            return $"{n}".Sum(c => (long) Math.Pow(long.Parse($"{c}"), $"{n}".Length)) == n;
        }
    }
}