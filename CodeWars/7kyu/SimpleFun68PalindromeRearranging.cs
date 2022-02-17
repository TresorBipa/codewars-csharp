/*
https://www.codewars.com/kata/5893fa478a8a23ef82000031/csharp

7 kyu
Simple Fun #68: Palindrome Rearranging

Task
Given a string s, find out if its characters can be rearranged to form a palindrome.

Example
For s = "aabb", the output should be true.

We can rearrange "aabb" to make "abba", which is a palindrome.

Input/Output
[input] string s

A string consisting of lowercase English letters.

Constraints:

4 ≤ inputString.length ≤ 50.

[output] a boolean value

true if the characters of the inputString can be rearranged to form a palindrome, false otherwise.
*/

using System.Linq;

namespace CodeWars
{
    public class SimpleFun68PalindromeRearranging
    {
        public bool PalindromeRearranging(string s)
        {
            return s.GroupBy(c => c).Sum(g => g.Count() % 2) < 2;
            //return s.GroupBy(g => g).Count(g => g.Count() % 2 != 0) <= 1;
            //return s.Distinct().Sum(x => s.Count(y => y == x) % 2 == 1 ? 1 : 0) < 2;
            //return s.GroupBy(x => x, (k, v) => new {k = k, c = v.Count()}).Count(x => x.c % 2 == 1) < 2;
        }
    }
}