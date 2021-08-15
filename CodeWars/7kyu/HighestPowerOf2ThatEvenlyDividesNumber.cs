/*
https://www.codewars.com/kata/58dabca7ce77a12dbd00000f/csharp

7 kyu
Highest power of 2 that evenly divides a number

Write a function that takes a number and returns highest power of 2 that evenly divides the number.

For example:

Kata.Solution(123)    => 1
Kata.Solution(192)    => 64
Kata.Solution(132232) => 8
Assume that: number is an integer within the range [1..10^18].
*/

namespace CodeWars
{
    public class HighestPowerOf2ThatEvenlyDividesNumber
    {
        public static long Solution(long n)
        {
            // long p = 1;
            // while ((n & 1) == 0)
            // {
            //     n >>= 1;
            //     p <<= 1;
            // }
            //
            // return p;


            return n & -n;
        }
    }
}