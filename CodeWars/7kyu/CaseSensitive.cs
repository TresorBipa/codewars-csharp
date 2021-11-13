/*
https://www.codewars.com/kata/5a805631ba1bb55b0c0000b8

7 kyu
Case-sensitive!

Your task is very simple. Given an input string s, case_sensitive(s), check whether all letters are lowercase or not. 
Return True/False and a list of all the entries that are not lowercase in order of their appearance in s.

For example, case_sensitive('codewars') returns [True, []], but case_sensitive('codeWaRs') returns [False, ['W', 'R']].

Goodluck :)

Have a look at my other katas!

Alphabetically ordered

Find Nearest square number

Not prime numbers
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CodeWars
{
    public class KataCaseSensitive
    {
        public static Tuple<bool, char[]> CaseSensitive(string s)
        {
            var upperChars = s.Where(char.IsUpper).ToArray();
            return new Tuple<bool, char[]>(!upperChars.Any(), upperChars);
            // return new Tuple<bool, char[]>(true, new char[] { });
        }
    }
}


