/*
https://www.codewars.com/kata/545cedaa9943f7fe7b000048/csharp

6 kyu
Detect Pangram

A pangram is a sentence that contains every single letter of the alphabet at least once. 
For example, the sentence "The quick brown fox jumps over the lazy dog" is a pangram, 
because it uses the letters A-Z at least once (case is irrelevant).

Given a string, detect whether or not it is a pangram. Return True if it is, False if not. Ignore numbers and punctuation.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class DetectPangram
    {
        public static bool IsPangram(string str)
        {
            return str.ToUpper().Where(char.IsLetter).Distinct().Count() == 26;
            // return !"abcdefghijklmnopqrstuvwxyz".Except(str.ToLower()).Any();
            // return str.ToLower().Where(char.IsLetter).Distinct().Count() == 26;
            // return str.ToLower().Where(char.IsLetter).GroupBy(x => x).Count() == 26;
            // return "abcdefghijklmnopqrstuvwxyz".All(c => str.ToLower().Contains(c));
            // return new HashSet<char>(str.ToLower().Where(char.IsLetter)).Count == 26;
            // return str.ToLower().Where(char.IsLetter).Distinct().Count(char.IsLetter) >= 26;
            // return new HashSet<char>("abcdefghijklmnopqrstuvwxyz").Intersect(str.ToLower()).Count() == 26;
            // return str.Where(ch => Char.IsLetter(ch)).Select(ch => Char.ToLower(ch)).Distinct().Count() == 26;
        }
    }
}