/*
https://www.codewars.com/kata/563b1f55a5f2079dc100008a/csharp

7 kyu
Number Pairs

In this Kata the aim is to compare each pair of integers from 2 arrays, and return a new array of large numbers.

Note: Both arrays have the same dimensions.

Example:

arr1 = new int[] { 13, 64, 15, 17, 88 };
arr2 = new int[] { 23, 14, 53, 17, 80 };

Kata.getLargerNumbers(arr1, arr2); // Returns {23, 64, 53, 17, 88}
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class NumberPairs
    {
        public static int[] getLargerNumbers(int[] a, int[] b)
        {
            //return Enumerable.Range(0, a.Length).Select(i => Math.Max(a[i], b[i])).ToArray();
            //return a.Select((t, i) => t >= b[i] ? t : b[i]).ToArray();
            //return a.Select((n, i) => Math.Max(n, b[i])).ToArray();
            //return a.Select((x, i) => Math.Max(x, b[i])).ToArray();
            //return a.Zip(b, (x, y) => x > y ? x : y).ToArray();
            return a.Zip(b, Math.Max).ToArray();
        }
    }
}