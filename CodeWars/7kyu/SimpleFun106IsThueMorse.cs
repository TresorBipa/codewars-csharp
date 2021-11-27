/*
https://www.codewars.com/kata/589a9792ea93aae1bf00001c/csharp

7 kyu
Simple Fun #106: Is Thue Morse?

Task
Given a sequence of 0s and 1s, determine if it is a prefix of Thue-Morse sequence.
The infinite Thue-Morse sequence is obtained by first taking a sequence containing a single 0 and then repeatedly concatenating the current sequence with its binary complement.
A binary complement of a sequence X is a sequence Y of the same length such that the sum of elements X_i and Y_i on the same positions is equal to 1 for each i.
Thus the first few iterations to obtain Thue-Morse sequence are:

0
0 1
0 1 1 0
0 1 1 0 1 0 0 1
...
Examples
For seq=[0, 1, 1, 0, 1], the result should be true.

For seq=[0, 1, 0, 0], the result should be false.

Inputs & Output
[input] integer array seq

An non-empty array.

Constraints:

1 <= seq.length <= 1000

seq[i] ∈ [0,1]

[output] a boolean value

true if it is a prefix of Thue-Morse sequence. false otherwise.
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class SimpleFun106IsThueMorse
    {
        public bool IsThueMorse(int[] seq)
        {
            //return seq.Where((x, i) => x == Convert.ToString(i, 2).Count(c => c == '1') % 2).Count() == seq.Length;

            var arr = new List<int> {0};
            while (arr.Count < seq.Length)
            {
                arr.AddRange(arr.Select(i => i == 1 ? 0 : 1).ToArray());
            }

            return arr.Take(seq.Length).SequenceEqual(seq);
            //return seq.Zip(arr, (a, b) => a == b).All(x => x);
            //return string.Concat(arr).Contains(string.Concat(seq));
            //return string.Concat(arr).IndexOf(string.Concat(seq)) == 0;
            //return string.Concat(arr.Take(seq.Length)) == string.Concat(seq);
            //return Enumerable.Range(0, seq.Length).All(i => seq[i] == arr[i]);
        }
    }
}