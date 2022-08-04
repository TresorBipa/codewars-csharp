/*
https://www.codewars.com/kata/57fafd0ed80daac48800019f/csharp

7 kyu
Exclamation marks series #8: Move all exclamation marks to the end of the sentence

Description:
Move all exclamation marks to the end of the sentence

Examples
remove("Hi!") === "Hi!"
remove("Hi! Hi!") === "Hi Hi!!"
remove("Hi! Hi! Hi!") === "Hi Hi Hi!!!"
remove("Hi! !Hi Hi!") === "Hi Hi Hi!!!"
remove("Hi! Hi!! Hi!") === "Hi Hi Hi!!!!"
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CodeWars
{
    public class ExclamationMarksSeries8
    {
        public static string Remove(string s)
        {
            // return string.Concat(s.OrderBy(c => c == '!'));
            // return new string(s.OrderBy(c => c == '!').ToArray());
            return s.Replace("!", "") + new string('!', s.Count(x => x == '!'));
        }
    }
}