/*
https://www.codewars.com/kata/589422431a88082ea600002a/csharp

7 kyu
Simple Fun #75: Digit Degree

Task
Let's define digit degree of some positive integer as the number of times we need to replace this number with the sum of its digits until we get to a one digit number.

Given an integer n, find its digit degree.

Example
For n = 5, the output should be 0;

For n = 100, the output should be 1;

For n = 91, the output should be 2.

Input/Output
[input] integer n

Constraints: 5 ≤ n ≤ 109.

[output] an integer
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class SimpleFun75DigitDegree
    {
        public int DigitDegree(int n)
        {
            //return n < 10 ? 0 : 1 + DigitDegree((int) n.ToString().Sum(char.GetNumericValue));
            return n <= 9 ? 0 : 1 + DigitDegree(n.ToString().Sum(c => c - '0'));
        }
    }
}