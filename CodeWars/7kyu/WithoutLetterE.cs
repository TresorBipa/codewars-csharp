/*
https://www.codewars.com/kata/594b8e182fa0a0d7fc000875/

7 kyu
Without the letter 'E'

Is it possible to write a book without the letter 'e' ?

Task
Given String str, return:

How much "e" does it contains (case-insensitive) in string format.
If given String doesn't contain any "e", return: "There is no "e"."
If given String is empty, return empty String.
If given String is `null`/`None`/`nil`, return `null`/`None`/`nil`
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CodeWars
{
    public class WithoutLetterE
    {
        public static string FindE(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            var count = s.ToLower().Count(x => x == 'e');
            return count == 0 ? "There is no \"e\"." : count.ToString();
        }
    }
}