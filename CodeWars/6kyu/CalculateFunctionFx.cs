/*
https://www.codewars.com/kata/54784a99b5339e1eaf000807/csharp

6 kyu
Calculate the function f(x) for a simple linear sequence (Medium)

This is a follow-up from my previous Kata which can be found here: http://www.codewars.com/kata/5476f4ca03810c0fc0000098

This time, for any given linear sequence, calculate the function [f(x)] and return it as a function in Javascript or Lambda/Block in Ruby.

For example:

GetFunction(new[] { 0, 1, 2, 3, 4 })(5) => 5
GetFunction(new[] { 0, 3, 6, 9, 12 })(10) => 30
GetFunction(new[] { 1, 4, 7, 10, 13 })(20) => 61
Assumptions for this kata are:

The sequence argument will always contain 5 values equal to f(0) - f(4).
The function will always be in the format "nx +/- m", 'x +/- m', 'nx', 'x' or 'm'
If a non-linear sequence simply return 'Non-linear sequence' for javascript, ruby, and python. For C#, throw an ArgumentException.
*/

using System;
using System.Linq;

namespace CodeWars._6kyu
{
    public static class CalculateFunctionFx
    {
        public static Func<int, int> GetFunction(int[] sequence)
        {
            if ((sequence[0] + sequence[4]) / 2 * 5 != sequence.Sum()) throw new ArgumentException();
            return x => sequence[0] + x * (sequence[1] - sequence[0]);
        }
    }
}