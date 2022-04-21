/*
https://www.codewars.com/kata/54bb6f887e5a80180900046b/csharp

6 kyu
longest_palindrome

Longest Palindrome
Find the length of the longest substring in the given string s that is the same in reverse.

As an example, if the input was “I like racecars that go fast”, the substring (racecar) length would be 7.

If the length of the input string is 0, the return value must be 0.

Example:
"a" -> 1 
"aab" -> 2  
"abcde" -> 1
"zzbaabcd" -> 4
"" -> 0
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CodeWars
{
    public class LongestPalindrome
    {
        public static int GetLongestPalindrome(string str)
        {
            if (string.IsNullOrEmpty(str)) return 0;
            var reverse = string.Concat(str.Reverse());

            return Enumerable.Range(0, str.Length)
                .SelectMany(i => Enumerable.Range(i, str.Length - i + 1).Select(j => str.Substring(i, j - i)))
                .Where(x => reverse.Contains(x)).Max(x => x.Length);



            // if (string.IsNullOrEmpty(str)) return 0;
            // var reverse = string.Concat(str.Reverse());
            //
            // // List<int> result = new List<int>();
            // int max = 0;
            //
            // for (int i = 0; i < str.Length; i++)
            // {
            //     for (int j = str.Length - i; j >= i; j--)
            //     {
            //         var s = reverse.Substring(i, j);
            //         // result.Add(str.Contains(s) ? s.Length : 0);
            //         if (str.Contains(s) &&  max < s.Length) max = s.Length;
            //     }
            // }
            //
            // // return result.Max();
            // return max;
        }
    }
}

