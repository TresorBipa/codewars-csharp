/*
https://www.codewars.com/kata/596ddaccdd42c1cf0e00005c/csharp

7 kyu
Operations with sequence

Steps

Square the numbers that are greater than zero.
Multiply by 3 every third number.
Multiply by -1 every fifth number.
Return the sum of the sequence.
Example
{ -2, -1, 0, 1, 2 } returns -6

1. { -2, -1, 0, 1 * 1, 2 * 2 }
2. { -2, -1, 0 * 3, 1, 4 }
3. { -2, -1, 0, 1, -1 * 4 }
4. -6
P.S.: The sequence consists only of integers. And try not to use "for", "while" or "loop" statements.
*/

using System.Linq;

namespace CodeWars
{
    public class OperationsWithSequence
    {
        public static int Calc(int[] array)
        {
            return array.Select((e, i) => e * (e > 0 ? e : 1) * (i % 3 == 2 ? 3 : 1) * (i % 5 == 4 ? -1 : 1)).Sum();
        }
    }
}