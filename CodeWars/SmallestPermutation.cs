/*
https://www.codewars.com/kata/5fefee21b64cc2000dbfa875/csharp

6 kyu
Smallest Permutation

Given a number, find the permutation with the smallest absolute value (no leading zeros).

-20 => -20
-32 => -23
0 => 0
10 => 10
29394 => 23499
The input will always be an integer.
*/


using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class SmallestPermutation
    {
        public int MinPermutation(int n)
        {
            return int.Parse(Regex.Replace(string.Concat(n.ToString().OrderBy(c => c)), "(0+)([1-9])", "$2$1"));

            // if (n == 0) return n;
            // var s = Math.Abs(n).ToString();
            // var num = string.Concat(s.Replace("0", "").OrderBy(c => c));
            // return int.Parse(num[0] + new string('0', s.Count(c => c == '0')) + num[1..]) * Math.Sign(n);

            // if (n == 0) return n;
            // var s = Math.Abs(n).ToString();
            // var count = s.Count(c => c == '0');
            // var num = string.Concat(s.Replace("0", "").OrderBy(c => c)).Insert(1, new string('0', count));
            // return int.Parse(num) * Math.Sign(n);
        }
    }
}