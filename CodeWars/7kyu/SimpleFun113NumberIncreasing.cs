/*
https://www.codewars.com/kata/589d1e88e8afb7a85e00004e/csharp

7 kyu
Simple Fun #113: Number Increasing

Task
Initially a number 1 is written on a board. It is possible to do the following operations with it:

multiply the number by 3; increase the number by 5. 
Your task is to determine that using this two operations step by step, is it possible to obtain number n?

Example
For n = 1, the result should be true.

1 = 1

For n = 2, the result should be false.

For n = 3, the result should be true.

1 x 3 = 3

For n = 4, the result should be false.

For n = 5, the result should be false.

For n = 6, the result should be true.

1 + 5 = 6

For n = 18, the result should be true.

1 + 5 = 6 --> 6 x 3 = 18

For n = 32, the result should be true.

1 x 3 x 3 x 3 = 27 --> 27 + 5 = 32

For n = 100, the result should be false.

For n = 101, the result should be true.

1 + 5 + 5 + 5 ... +5 = 101

Input / Output
[input] integer n

positive integer, n ≤ 100000

[output] a boolean value

true if N can be obtained using given operations, false otherwise.
*/

using System.Collections;
using System;
using System.Linq;

namespace CodeWars
{
    public class SimpleFun113NumberIncreasing
    {
        public bool NumberIncreasing(int n)
        {
            return n % 5 != 0 && (n > 22 || !(n % 5 == 2 || n == 4));
            // return n % 5 != 0 && !new[] {2, 4, 7, 12, 17, 22}.Contains(n);
            // return n % 5 != 0 && !((IList) new int[] {2, 4, 7, 12, 17, 22}).Contains(n);

            // int d = n % 5;
            // return d % 2 != 0 || d == 2 && n >= 27 || d == 4 && n >= 9;

            // var remainder = n % 5;
            // return remainder switch
            // {
            //     0 => false,
            //     1 => true,
            //     2 => n > 22,
            //     3 => true,
            //     4 => n > 4,
            //     _ => false
            // };
        }
    }
}