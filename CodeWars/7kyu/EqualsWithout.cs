/*
https://www.codewars.com/kata/5932d5c160ee35745d0000d6/csharp

7 kyu
Equals without "=="

Your task is to write a function bool equals(int a, int b) what returns same result as a == b, but you must not use == operator.
To check that, the test case will search = character in your solution. So don't use it even in comments.
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CodeWars
{
    // Best Solution
    // public static class Kata
    // {
    // }

    public static class EqualsWithout
    {
        public static bool Equals(int a, int b)
        {
            return a.Equals(b);
            // return !(Math.Abs(a - b) > 0);
            // return !Convert.ToBoolean(a - b);
            // return !Convert.ToBoolean(a ^ b);
        }
    }
}