/*
https://www.codewars.com/kata/5be0f1786279697939000157/csharp

7 kyu
Simple Fun #399: Make Ascending Sequences

Task
You are given a positive integer n. We intend to make some ascending sequences according to the following rules:

Make a sequence of length 1: [ n ]

Or, insert a number to the left side of the sequence. But this number can not exceed half of the first number of the sequence.

Follow rule 2, continue insert number to the left side of the sequence.

Your task is to count the number of all possible sequences, and return it.

If you do not understand the task, please read the rewritten version below:

You are given a positive integer n. Your task is to count the number of such sequences:

It should be an ascending sequence;

It should end with number n.

Each number in the sequence should smaller or equals to the half of its right, except for the last number n.

We define that a sequence containing only a number n is a valid ascending sequence.

Examples
For n = 6, the output should be 6.

All sequences we made are:

[6]

insert a number to the left:

[1,6]
[2,6]
[3,6]

continue insert number:

[1,2,6]
[1,3,6]
There are 6 sequences in total.

For n = 10, the output should be 14.

All sequences we made are:

[10]

insert a number to the left:

[1,10]
[2,10]
[3,10]
[4,10]
[5,10]

continue insert number:

[1,2,10]
[1,3,10]
[1,4,10]
[2,4,10]
[1,5,10]
[2,5,10]

continue insert number:

[1,2,4,10]
[1,2,5,10]
There are 14 sequences in total.

Note
1 <= n <= 1000

3 fixed testcases

100 random testcases, testing for correctness of solution

All inputs are valid.

If my reference solution gives the wrong result in the random tests, please let me know(post an issue).
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class SimpleFun399MakeAscendingSequences
    {
        //private static List<int> seq = new List<int> {1};

        public static int MakeSequences(int n)
        {
            Console.WriteLine(n);
            List<int> result = new List<int> {1};
            for (var i = 1; i <= n; i++)
            {
                result.Add(i % 2 == 0 ? result[i - 1] : result[i / 2] + result[i - 1]);
            }

            return result.Last();


            // List<int> seq = new List<int> {1};
            // for (int i = seq.Count, j = i - 1; j < n; ++i, ++j)
            // {
            //     seq.Add(seq[j] + (j & 1) * seq[i >> 1]);
            // }
            //
            // return seq[n];


            // if (seq.Count <= n / 2)
            //     seq.Add(MakeSequences(n - 2) + MakeSequences(n / 2));
            // return cache[n / 2];
        }
    }
}