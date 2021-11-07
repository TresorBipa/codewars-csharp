/*
https://www.codewars.com/kata/57a1fd2ce298a731b20006a4/csharp

8 kyu
Is it a palindrome?

Write a function that checks if a given string (case insensitive) is a palindrome.
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CodeWars
{
    public static class KataIsItPalindrome
    {
        public static bool IsPalindrome(string s)
        {
            return string.Concat(s.Reverse()).ToLower() == s.ToLower();

            // char[] charArray = s.ToCharArray();
            // Array.Reverse(charArray);
            // return String.Join("", charArray).ToLower() == s.ToLower();
        }
    }
}