/*
https://www.codewars.com/kata/54521e9ec8e60bc4de000d6c/csharp

5 kyu
Maximum subarray sum

The maximum sum subarray problem consists in finding the maximum sum of a contiguous subsequence in an array or list of integers:

maxSequence [-2, 1, -3, 4, -1, 2, 1, -5, 4]
-- should be 6: [4, -1, 2, 1]
Easy case is when the list is made up of only positive numbers and the maximum sum is the sum of the whole array. 
If the list is made up of only negative numbers, return 0 instead.

Empty list is considered to have zero greatest sum. Note that the empty list or array is also a valid sublist/subarray.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class MaximumSubarraySum
    {
        public static int MaxSequence(int[] arr)
        {
            return arr.Aggregate((0, 0), (t, c) => (Math.Max(0, t.Item1 + c), Math.Max(t.Item2, t.Item1 + c))).Item2;


            // int sum = 0;
            // return arr.Aggregate(0, (max, v) => Math.Max(sum = Math.Max(sum + v, 0), max));

            // return Enumerable.Range(0, arr.Length).Select((x, i) =>
            //     Enumerable.Range(i, arr.Length).Select((e, j) => arr?.Skip(i).SkipLast(j).Sum()).Max()).Max() ?? 0;

            // int currentMax = 0, totalMax = 0;
            // return arr.Select(a => currentMax = Math.Max(0, currentMax + a)).Prepend(totalMax).Max();


            // int currentMax = 0, totalMax = 0;
            // foreach (var a in arr)
            // {
            //     currentMax = Math.Max(0, currentMax + a);
            //     totalMax = Math.Max(totalMax, currentMax);
            // }
            //
            // return totalMax;


            // int max = 0;
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     for (int j = i; j < arr.Length; j++)
            //     {
            //         var sum = arr.Skip(i).Take(arr.Length - j).Sum();
            //         if (sum > max) max = sum;
            //     }
            // }
        }
    }
}