/*
https://www.codewars.com/kata/57814d79a56c88e3e0000786/csharp

6 kyu
Simple Encryption #1 - Alternating Split

Implement a pseudo-encryption algorithm which given a string S and an integer N concatenates all the odd-indexed characters of S with all the even-indexed characters of S, this process should be repeated N times.

Examples:

encrypt("012345", 1)  =>  "135024"
encrypt("012345", 2)  =>  "135024"  ->  "304152"
encrypt("012345", 3)  =>  "135024"  ->  "304152"  ->  "012345"

encrypt("01234", 1)  =>  "13024"
encrypt("01234", 2)  =>  "13024"  ->  "32104"
encrypt("01234", 3)  =>  "13024"  ->  "32104"  ->  "20314"
Together with the encryption function, you should also implement a decryption function which reverses the process.

If the string S is an empty value or the integer N is not positive, return the first argument without changes.

This kata is part of the Simple Encryption Series:

Simple Encryption #1 - Alternating Split
Simple Encryption #2 - Index-Difference
Simple Encryption #3 - Turn The Bits Around
Simple Encryption #4 - Qwerty
Have fun coding it and please don't forget to vote and rank this kata! :-)
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CodeWars
{
    public class SimpleEncryption1AlternatingSplit
    {
        public static string Encrypt(string text, int n)
        {
            if (string.IsNullOrEmpty(text) || n <= 0) return text;

            for (var j = 0; j < n; j++)
            {
                text = string.Concat(text.Where((c, i) => i % 2 == 1).Concat(text.Where((c, i) => i % 2 == 0)));
            }

            return text;
        }

        public static string Decrypt(string text, int n)
        {
            if (string.IsNullOrEmpty(text) || n <= 0) return text;
            var mid = text.Length / 2;

            for (var i = 0; i < n; i++)
            {
                text = string.Concat(text[mid..].Zip(text[..mid], (f, s) => $"{f}{s}")) +
                       (text.Length % 2 == 0 ? "" : $"{text[^1]}");
            }

            return text;
        }
    }
}