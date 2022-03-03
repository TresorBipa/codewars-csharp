/*
https://www.codewars.com/kata/5b73fe9fb3d9776fbf00009e/csharp

8 kyu
Sum of differences in array

Your task is to sum the differences between consecutive pairs in the array in descending order.

For example:

sumOfDifferences([2, 1, 10])
Returns 9

Descending order: [10, 2, 1]

Sum: (10 - 2) + (2 - 1) = 8 + 1 = 9

If the array is empty or the array has only one element the result should be 0 (Nothing in Haskell).
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CodeWars
{
    public static class SumOfDifferencesInArray
    {
        public static int SumOfDifferences(int[] arr)
        {
            return arr.Length > 1 ? arr.Max() - arr.Min() : 0;
        }
    }
}