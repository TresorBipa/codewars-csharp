/*
https://www.codewars.com/kata/5624e574ec6034c3a20000e6/csharp

7 kyu
Hamming Distance - Part 1: Binary codes

The hamming distance of two equal-length strings is the number of positions, in which the two string differ. 
In other words, the number of character substitutions required to transform one string into the other.

For this first Kata, you will write a function hamming_distance(a, b) with two equal-length strings containing only 0s and 1s as parameters. 
There is no need to test the parameters for validity (but you can, if you want).
The function's output should be the hamming distance of the two strings as an integer.

Example:
Kata.HammingDistance("100101', "101001") == 2
Kata.HammingDistance("1010', "0101") == 4
*/

using System.Linq;

namespace CodeWars
{
    public class HammingDistancePart1BinaryCodes
    {
        public static int HammingDistance(string a, string b)
        {
            // return a.Zip(b).Select(e => e.First != e.Second).Sum(e => e ? 1 : 0);
            // return Enumerable.Range(0, a.Length).Count(i => a[i] != b[i]);
            // return a.Length - a.Where((x, i) => x == b[i]).Count();
            // return a.Select((c, i) => c == b[i] ? 0 : 1).Sum();
            // return a.Zip(b, (x, y) => (x == y ? 0 : 1)).Sum();
            return a.Where((c, i) => c != b[i]).Count();
        }
    }
}