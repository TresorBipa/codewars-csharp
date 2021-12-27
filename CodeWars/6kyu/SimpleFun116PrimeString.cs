/*
https://www.codewars.com/kata/589d36bbb6c071f7c20000f7/csharp

6 kyu
Simple Fun #116: Prime String

Task
The string is called prime if it cannot be constructed by concatenating some (more than one) equal strings together.

For example, "abac" is prime, but "xyxy" is not("xyxy"="xy"+"xy").

Given a string determine if it is prime or not.

Input/Output
[input] string s
string containing only lowercase English letters

[output] a boolean value
true if the string is prime, false otherwise
*/

using System;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class SimpleFun116PrimeString
    {
        public static bool PrimeString(string s)
        {
            return !Regex.IsMatch(s, "^(.+)\\1+$");
            // return (s + s).IndexOf(s, 1) == s.Length;
            // return $"{s}{s}".IndexOf(s, 1) == s.Length;
            // return (s + s)[1..].IndexOf(s) == s.Length - 1;
            // return (s + s).Substring(1).IndexOf(s) == s.Length - 1;
        }
    }
}
