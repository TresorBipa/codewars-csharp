﻿/*
https://www.codewars.com/kata/58899594b832f80348000122/csharp

7 kyu
Simple Fun #55: Cyclic String

Task
You're given a substring s of some cyclic string. 
What's the length of the smallest possible string that can be concatenated to itself many times to obtain this cyclic string?

Example
For s = "cabca", the output should be 3

"cabca" is a substring of a cycle string "abcabcabcabc..." that can be obtained by concatenating "abc" to itself. Thus, the answer is 3.

Input/Output
[input] string s

Constraints: 3 ≤ s.length ≤ 15.

[output] an integer
*/

using System.Linq;

namespace CodeWars
{
    public class SimpleFun55CyclicString
    {
        public int CyclicString(string s)
        {
            var count = 0;
            while (s[++count ..] != s[.. ^count]) ;
            return count;
        }
    }
}