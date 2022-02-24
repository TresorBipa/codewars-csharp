/*
https://www.codewars.com/kata/58a664bb586e986c940001d5/csharp

6 kyu
Simple Fun #135: Missing Alphabets

Task
Given string s, which contains only letters from a to z in lowercase.

A set of alphabet is given by abcdefghijklmnopqrstuvwxyz.

2 sets of alphabets mean 2 or more alphabets.

Your task is to find the missing letter(s). You may need to output them by the order a-z. 
It is possible that there is more than one missing letter from more than one set of alphabet.

If the string contains all of the letters in the alphabet, return an empty string ""

Example
For s='abcdefghijklmnopqrstuvwxy'

The result should be 'z'

For s='aabbccddeeffgghhiijjkkllmmnnooppqqrrssttuuvvwwxxyy'

The result should be 'zz'

For s='abbccddeeffgghhiijjkkllmmnnooppqqrrssttuuvvwwxxy'

The result should be 'ayzz'

For s='codewars'

The result should be 'bfghijklmnpqtuvxyz'

Input/Output
[input] string s
Given string(s) contains one or more set of alphabets in lowercase.

[output] a string
Find the letters contained in each alphabet but not in the string(s). 
Output them by the order a-z. 
If missing alphabet is repeated, please repeat them like "bbccdd", not "bcdbcd"
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class SimpleFun135MissingAlphabets
    {
        public string MissingAlphabets(string s)
        {
            var arr = "abcdefghijklmnopqrstuvwxyz".Select(x => s.Count(c => c == x)).ToArray();
            var max = arr.Max();
            return string.Concat(arr.SelectMany((x, i) => new string((char)(97 + i), max - x)));

            // var max = s.GroupBy(c => c).Max(g => g.Count());
            // return string.Concat("abcdefghijklmnopqrstuvwxyz".Select(x => new string(x, max - s.Count(c => c == x))));

            // string set = "abcdefghijklmnopqrstuvwxyz";
            // int max = s.GroupBy(c => c).Max(gr => gr.Count());
            // return string.Concat(set.Select(c => new string(c, max - s.Count(c2 => c2 == c)))); 
        }
    }
}