/*
https://www.codewars.com/kata/55d410c492e6ed767000004f/csharp

7 kyu
The old switcheroo

Write a function

Vowel2Index(string s)
that takes in a string and replaces all the vowels [a,e,i,o,u] with their respective positions within that string.

E.g:
Kata.Vowel2Index("this is my string") == "th3s 6s my str15ng"
Kata.Vowel2Index("Codewars is the best site in the world") == "C2d4w6rs 10s th15 b18st s23t25 27n th32 w35rld"
Your function should be case insensitive to the vowels.
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CodeWars
{
    public class OldSwitcheroo
    {
        public static string Vowel2Index(string str)
        {
            return Regex.Replace(str, "[aeiou]", m => $"{m.Index + 1}");
            // return string.Concat(str.Select((c, i) => "aeiou".Contains(c) ? $"{i + 1}" : $"{c}"));
        }
    }
}