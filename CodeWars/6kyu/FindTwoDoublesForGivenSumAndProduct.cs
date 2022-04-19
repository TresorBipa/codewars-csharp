/*
https://www.codewars.com/kata/561e5fb89be196932b00003c/csharp

6 kyu
Find two doubles for the given sum and product

Write a method, which takes two doubles, sum and product, and returns two doubles (in a Tuple<double, double>) so x1 + x2 == sum and x1 * x2 == product.

In case there are no two doubles to fulfill the above criteria, return null.

It's allowed to return two doubles which are exactly the same.

Some examples:

Input: 4 (sum), 4 (product), output: 2, 2
Input: 8 (sum), 15 (product), output: 3, 5
Input: 9.05 (sum), 9.75 (product), output: 1.25, 7.8.
Input: -4 (sum), 4 (product), output: -2, -2.
Input: 2 (sum), 7/3 (product), output: null.
*/

using System;

namespace CodeWars._6kyu
{
    public static class FindTwoDoublesForGivenSumAndProduct
    {
        public static Tuple<double, double> FindDoubles(double sum, double product)
        {
            var x = 0.5 * (sum + Math.Sqrt(sum * sum - 4 * product));
            return double.IsNaN(x) ? null : new Tuple<double, double>(x, sum - x);
        }
    }
}