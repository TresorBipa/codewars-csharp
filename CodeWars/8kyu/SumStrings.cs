/*
https://www.codewars.com/kata/5966e33c4e686b508700002d/csharp

8 kyu
Sum The Strings

Create a function that takes 2 nonnegative integers in form of a string as an input, and outputs the sum (also as a string):

Example: (Input1, Input2 -->Output)

"4",  "5" --> "9"
"34", "5" --> "39"
Notes:

If either input is an empty string, consider it as zero.

Inputs and the expected output will never exceed the signed 32-bit integer limit (2^31 - 1)
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CodeWars
{
    public static class SumStrings
    {
        public static string StringsSum(string s1, string s2)
        {
            return $"{(s1 == "" ? 0 : int.Parse(s1)) + (s2 == "" ? 0 : int.Parse(s2))}";
            // return ((s1 == "" ? 0 : int.Parse(s1)) + (s2 == "" ? 0 : int.Parse(s2))).ToString();
            // return (int.Parse(s1 == "" ? "0" : s1) + int.Parse(s2 == "" ? "0" : s2)).ToString();
            // return (Convert.ToInt32(s1 == "" ? "0" : s1) + Convert.ToInt32(s2 == "" ? "0" : s2)).ToString();

            // int num1 = s1 == "" ? 0 : int.Parse(s1);
            // int num2 = s2 == "" ? 0 : int.Parse(s2);
            // return (num1 + num2).ToString();
        }
    }
}