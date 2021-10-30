/*
https://www.codewars.com/kata/5840586b5225616069000001/csharp

7 kyu
Which string is worth more?

You will be given two ASCII strings, a and b. Your task is write a function to determine which one of these strings is "worth" more, and return it.

A string's worth is determined by the sum of its ASCII codepoint indexes. 
So, for example, the string HELLO has a value of 372: H is codepoint 72, E 69, L 76, and O is 79. The sum of these values is 372.

In the event of a tie, you should return the first string, i.e. a.
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CodeWars
{
    public class WhichStringIsWorthMore
    {
        public static string HighestValue(string a, string b)
        {
            return b.Sum(c => c) > a.Sum(c => c) ? b : a;
            // return a.Sum(c => c) >= b.Sum(c => c) ? a : b;

            // int Sum(string s) => s.Sum(c => c);
            // return Sum(a) > Sum(b) ? a : b;
        }
    }
}