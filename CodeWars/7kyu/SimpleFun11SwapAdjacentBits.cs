/*
https://www.codewars.com/kata/58845a92bd573378f4000035/csharp

7 kyu
Simple Fun #11: Swap Adjacent Bits

Task
You're given an arbitrary 32-bit integer n. Swap each pair of adjacent bits in its binary representation and return the result as a decimal number.

Example
For n = 13, the output should be 14

1310 = 11012 ~> 11102 = 1410

For n = 74, the output should be 133

7410 = 010010102 ~> 100001012 = 13310

Note

the preceding zero written in front of the initial number: 
since both numbers are 32-bit integers, they have 32 bits in their binary representation. 
The preceding zeros in other cases don't matter, so they are omitted. Here, however, it does make a difference.

Input/Output
[input] integer n

0 ≤ n < 2^30.

[output] an integer
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class SimpleFun11SwapAdjacentBits
    {
        public int SwapAdjacentBits(int n)
        {
            //return unchecked((n & 0x55555555) << 1 | (n & (int) 0xaaaaaaaa) >> 1);
            //return (int)(((n & 0xAAAAAAAA) >> 1) | ((n & 0x55555555) << 1));

            var result = "";
            var bin = Convert.ToString(n, 2).PadLeft(32, '0');
            for (var i = 0; i < bin.Length; i += 2)
            {
                result += $"{bin[i + 1]}{bin[i]}";
            }

            return Convert.ToInt32(result, 2);

            // return Convert.ToInt32(
            //     string.Concat(
            //         Convert.ToString(n, 2)
            //             .PadLeft(32, '0')
            //             .Select((bit, index) => new {Bit = bit, Group = index / 2})
            //             .GroupBy(x => x.Group,
            //                 (_, group) => $"{group.Last().Bit}{group.First().Bit}")), 2);

            // var binary = Convert.ToString(n, 2);
            // binary = (binary.Length % 2 == 0 ? "" : "0") + binary;
            //
            // var pairBits = Regex.Split(binary, "(?<=\\G.{2})")
            //     .Select(pair => string.Concat(pair.Reverse()));
            //
            // return Convert.ToInt32(string.Concat(pairBits), 2);
        }
    }
}