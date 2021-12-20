/*
https://www.codewars.com/kata/58bccdf56f25ff6b6d00002f/csharp

7 kyu
Simple Fun #181: Rounding

Task
Round the given number n to the nearest multiple of m.

If n is exactly in the middle of 2 multiples of m, return n instead.

Example
For n = 20, m = 3, the output should be 21.

For n = 19, m = 3, the output should be 18.

For n = 50, m = 100, the output should be 50.

Input/Output
[input] integer n

1 ≤ n < 10^9.

[input] integer m

3 ≤ m < 109.

[output] an integer
*/

using System;

namespace CodeWars
{
    public class SimpleFun181Rounding
    {
        public int Rounding(int n, int m)
        {
            return m % 2 == 0 && n % m == m / 2 ? n : n + m / 2 - (n + m / 2) % m;
        }
    }
}