/*
https://www.codewars.com/kata/5886cab0a95e17e61600009d/csharp

7 kyu
Simple Fun #21: Number Of Clans

Task
Let's call two integers A and B friends if each integer from the array divisors is either a divisor of both A and B or neither A nor B. 
If two integers are friends, they are said to be in the same clan. How many clans are the integers from 1 to k, inclusive, broken into?

Example
For divisors = [2, 3] and k = 6, the output should be 4

The numbers 1 and 5 are friends and form a clan, 2 and 4 are friends and form a clan, and 3 and 6 do not have friends and each is a clan by itself. 
So the numbers 1 through 6 are broken into 4 clans.

Input/Output
[input] integer array divisors

A non-empty array of positive integers.

Constraints: 2 ≤ divisors.length < 10, 1 ≤ divisors[i] ≤ 10.

[input] integer k

A positive integer.

Constraints: 5 ≤ k ≤ 50.

[output] an integer

*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class SimpleFun21NumberOfClans
    {
        public int NumberOfClans(int[] divisors, int k)
        {
            return Enumerable.Range(1, k)
                .Select(i => divisors.Select((x, inx) => i % x == 0 ? (int) Math.Pow(2, inx) : 0).Sum())
                .GroupBy(i => i)
                .Count();

            // string[] result = new string[k];
            // for (int i = 1; i <= k; i++)
            //     foreach (int m in divisors)
            //         if (i % m == 0)
            //             result[i - 1] += m + "";
            // List<string> uniq = new List<string>();
            // foreach (string str in result)
            //     if (!uniq.Contains(str))
            //         uniq.Add(str);
            // return uniq.Count;
        }
    }
}