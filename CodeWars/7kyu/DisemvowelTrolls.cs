/*
https://www.codewars.com/kata/52fba66badcd10859f00097e/csharp

7 kyu
Disemvowel Trolls

Trolls are attacking your comment section!

A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.

Your task is to write a function that takes a string and return a new string with all vowels removed.

For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".

Note: for this kata y isn't considered a vowel.
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CodeWars
{
    public class DisemvowelTrolls
    {
        public static string Disemvowel(string str)
        {
            return Regex.Replace(str, "(?i)[aeiou]", "");
            // return Regex.Replace(str, "[aeiouAEIOU]", "");
            // return Regex.Replace(str,"[aeiou]", "", RegexOptions.IgnoreCase);
            // return string.Concat(str.Where(c => !"aeiouAEIOU".Contains(c)));
        }
    }
}