/*
https://www.codewars.com/kata/5894318275f2c75695000146/csharp

6 kyu
Simple Fun #79: Delete a Digit

Task
Given an integer n, find the maximal number you can obtain by deleting exactly one digit of the given number.

Example
For n = 152, the output should be 52;

For n = 1001, the output should be 101.

Input/Output
[input] integer n

Constraints: 10 ≤ n ≤ 1000000.

[output] an integer
*/

using System.Linq;

namespace CodeWars
{
    public class SimpleFun79DeleteDigit
    {
        public int DeleteDigit(int n)
        {
            var s = n.ToString();
            return s.Select((_, i) => s.Remove(i, 1)).Max(int.Parse);


            // return $"{n}".Select((_, i) => $"{n}".Remove(i, 1)).Max(int.Parse);
            // return Enumerable.Range(0, $"{n}".Length).Max(i => int.Parse($"{n}".Remove(i, 1)));
            // return Enumerable.Range(0, n.ToString().Length).Max(x => int.Parse(n.ToString().Remove(x, 1)));
            // return Enumerable.Repeat(n.ToString(), n.ToString().Length).Select((x, i) => int.Parse(x.Remove(i, 1))).Max();

            // var max = 0;
            // for (int i = 0; i < n.ToString().Length; i++)
            // {
            //     var num = int.Parse(n.ToString().Remove(i, 1));
            //     if (num > max) max = num;
            // }
            // return max;
        }
    }
}

