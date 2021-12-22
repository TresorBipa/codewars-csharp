/*
https://www.codewars.com/kata/58bcdc65f6d3b11fce000045/csharp

7 kyu
Simple Fun #184: LCM from m to n

Task
Your task is to find the smallest number which is evenly divided by all numbers between m and n (both inclusive).

Example
For m = 1, n = 2, the output should be 2.

For m = 2, n = 3, the output should be 6.

For m = 3, n = 2, the output should be 6 too.

For m = 1, n = 10, the output should be 2520.

Input/Output
[input] integer m

1 ≤ m ≤ 25

[input] integer n

1 ≤ n ≤ 25

[output] an integer
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class SimpleFun184LCMFromMToN
    {
        public double LCMm2n(int m, int n)
        {
            int min = Math.Min(m, n), max = Math.Max(m, n);
            return Enumerable.Range(min, max - min + 1).Select(x => (double) x).Aggregate((x, y) => x * y / GCD(x, y));
        }

        double GCD(double x, double y) => y == 0 ? x : GCD(y, x % y);

        // public double LCMm2n(int m, int n)
        // {
        //     var min = Math.Min(m, n);
        //     var max = Math.Max(m, n);
        //     return Enumerable.Range(min, max - min + 1).Aggregate(1L, (r, i) => LCM(r, i));
        // }
        //
        // private static long GCD(long a, long b) => b == 0 ? a : GCD(b, a % b);
        // private static long LCM(long a, long b) => a * b / GCD(a, b);
    }
}