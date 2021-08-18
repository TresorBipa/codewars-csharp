/*
https://www.codewars.com/kata/584466950d3bedb9b300001f/csharp

7 kyu
How many times does it contain?

Your task is to return how many times a string contains a given character.

The function takes a string(inputS) as a parameter and a char(charS) which is the character that you will have to find and count.

For example, if you get an input string "Hello world" and the character to find is "o", return 2.
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class HowManyTimesDoesItContain
    {
        public static int stringCounter(string inputS, string charS)
        {
            // return Regex.Replace(inputS, @"[^" + charS + "]", "").Length;
            // return Regex.Matches(inputS, Regex.Escape(charS)).Count;
            // return inputS.Count(x => Convert.ToString(x) == charS);
            // return Regex.Replace(inputS, $"[^{charS}]", "").Length;
            // return new Regex($"[{charS}]").Matches(inputS).Count();
            // return inputS.Count(c => charS.Equals(c.ToString()));
            // return inputS.Count(q => q == char.Parse(charS));
            // return inputS.Count(c => c.ToString() == charS);
            // return inputS.Split(charS[0]).Length - 1;
            // return inputS.Count(x => x == charS[0]);
            return inputS.Count(charS.Contains);
        }
    }
}