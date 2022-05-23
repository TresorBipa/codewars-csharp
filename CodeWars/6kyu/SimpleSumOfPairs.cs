/*
https://www.codewars.com/kata/5bc027fccd4ec86c840000b7/csharp

6 kyu
Simple sum of pairs

Given an integer n, find two integers a and b such that:

A) a >= 0 and b >= 0
B) a + b = n
C) DigitSum(a) + Digitsum(b) is maximum of all possibilities.  
You will return the digitSum(a) + digitsum(b).

For example:
solve(29) = 11. If we take 15 + 14 = 29 and digitSum = 1 + 5 + 1 + 4 = 11. There is no larger outcome.
n will not exceed 10e10.

More examples in test cases.
Good luck!
*/

using System.Linq;

namespace CodeWars
{
    public class SimpleSumOfPairs
    {
        public static int solve(long n)
        {
            var s = n.ToString();
            return s.Sum(c => c - '0') + (s.Length - 1) * 9 - (s[^1] == '9' ? 9 : 0);
        }
    }
}