﻿/*
https://www.codewars.com/kata/554b4ac871d6813a03000035/csharp

7 kyu
Highest and Lowest

In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.

Example:

Kata.HighAndLow("1 2 3 4 5");  // return "5 1"
Kata.HighAndLow("1 2 -3 4 5"); // return "5 -3"
Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"
Notes:

All numbers are valid Int32, no need to validate them.
There will always be at least one number in the input string.
Output string must be two numbers separated by a single space, and highest number is first.
*/

using System.Linq;

namespace CodeWars._7kyu
{
    public class HighestAndLowest
    {
        public static string HighAndLow(string numbers)
        {
            // String[] substrings = numbers.Split();
            // int[] nums = substrings.Select(int.Parse).ToArray();
            // return nums.Max() + " " + nums.Min();

            var n = numbers.Split().Select(int.Parse); //.ToArray();
            return $"{n.Max()} {n.Min()}";
        }
    }
}