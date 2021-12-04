/*
https://www.codewars.com/kata/5884615cbd573356ab000050/csharp

7 kyu
Simple Fun #12: Count Sum of Two Representions

Task
Given integers n, l and r, find the number of ways to represent n as a sum of two integers A and B such that l ≤ A ≤ B ≤ r.

Example
For n = 6, l = 2 and r = 4, the output should be 2

There are just two ways to write 6 as A + B, where 2 ≤ A ≤ B ≤ 4:

6 = 2 + 4 and 6 = 3 + 3

Input/Output
[input] integer n

A positive integer.

Constraints: 5 ≤ n ≤ 106.

[input] integer l

A positive integer.

Constraints: 1 ≤ l ≤ r.

[input] integer r

A positive integer.

Constraints: l ≤ r ≤ 106

[output] an integer
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class SimpleFun12CountSumOfTwo
    {
        public int CountSumOfTwoRepresentations(int n, int l, int r)
        {
            return Enumerable.Range(l, Math.Max(n / 2 - l + 1, 1)).Count(x => l <= n - x && n - x <= r);

            // if (n < 2 * l || n > 2 * r) return 0;
            // if (n.CompareTo(l + r) < 0)
            //     r = n - l;
            // else
            //     l = n - r;
            //
            // return (r - l) / 2 + 1;
        }
    }
}