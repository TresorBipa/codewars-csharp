/*
https://www.codewars.com/kata/5966847f4025872c7d00015b/csharp

6 kyu
String average

You are given a string of numbers between 0-9.
Find the average of these numbers and return it as a floored whole number (ie: no decimal places) written out as a string. 

Eg:
"zero nine five two" -> "four"

If the string is empty or includes a number greater than 9, return "n/a"
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class StringAverage
    {
        public static string AverageString(string str)
        {
            string[] n = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"};
            var arr = str.Split();
            return arr.Any(s => !n.Contains(s)) ? "n/a" : n[(int) arr.Select(x => Array.IndexOf(n, x)).Average()];
        }
    }
}