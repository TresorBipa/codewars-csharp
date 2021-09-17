/*
https://www.codewars.com/kata/564e7fc20f0b53eb02000106/csharp

7 kyu
Count consonants

Write a function consonantCount, consonant_count or ConsonantCount that takes a string of English-language text and returns the number of consonants in the string.
Consonants are all letters used to write English excluding the vowels a, e, i, o, u.
*/

using System.Text.RegularExpressions;

namespace CodeWars
{
    public class CountConsonants
    {
        public static int ConsonantCount(string str)
        {
            return Regex.Matches(str, "(?i)[b-df-hj-np-tv-z]").Count;
            // return Regex.Matches(str.ToLower(), "[b-df-hj-np-tv-z]").Count;
        }
    }
}