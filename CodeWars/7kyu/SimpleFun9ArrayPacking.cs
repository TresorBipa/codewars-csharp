/*
https://www.codewars.com/kata/588453ea56daa4af920000ca/csharp

7 kyu
Simple Fun #9: Array Packing

Task
You are given an array of up to four non-negative integers, each less than 256.

Your task is to pack these integers into one number M in the following way:

The first element of the array occupies the first 8 bits of M;
The second element occupies next 8 bits, and so on.
Return the obtained integer M as unsigned integer.

Note:

the phrase "first bits of M" refers to the least significant bits of M - the right-most bits of an integer. 
For further clarification see the following example.

Example
For a = [24, 85, 0], the output should be 21784

An array [24, 85, 0] looks like [00011000, 01010101, 00000000] in binary.

After packing these into one number we get 00000000 01010101 00011000 (spaces are placed for convenience), which equals to 21784.

Input/Output
[input] integer array a

Constraints: 1 ≤ a.length ≤ 4 and 0 ≤ a[i] < 256

[output] an unsigned integer

More Challenge
Are you a One-Liner? Please try to complete the kata in one line(no test for it) ;-)
*/

using System;
using System.Collections;
using System.Linq;

namespace CodeWars
{
    public class SimpleFun9ArrayPacking
    {
        public int ArrayPacking(int[] a)
        {
            return a.Select((x, i) => x << i * 8).Sum();

            // new BitArray(a.Select(Convert.ToByte).ToArray()).CopyTo(a, 0);
            // return a[0];

            // return Enumerable.Range(0, 4).Zip(a, (r, x) => x << (r << 3)).Sum();
            // return a.Reverse().Aggregate(0, (a, v) => (a << 8) + v);
            // return Convert.ToInt32(string.Concat(a.Select(i => Convert.ToString(i, 2).PadLeft(8, '0')).Reverse()), 2);
        }
    }
}