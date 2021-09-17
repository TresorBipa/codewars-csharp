/*
https://www.codewars.com/kata/599f403119afacf9f1000051/csharp

7 kyu
nextPerfectSquare

Write a function name nextPerfectSquare / next_perfect_square that returns the first perfect square that is greater than its integer argument. 
A perfect square is a integer that is equal to some integer squared. For example 16 is a perfect square because 16=4*4.

example

n   next perfect square

6    9
36   49 
0    1
-5   0 
Caution! The largest number test is close to Int64.MaxValue
*/

using System;

namespace CodeWars
{
    public class KataNextPerfectSquare
    {
        public static long NextPerfectSquare(long n)
        {
            //return n >= 0 ? (long) Math.Pow(Math.Floor(Math.Sqrt(n) + 1), 2) : 0;
            return n < 0 ? 0 : (long) Math.Pow((long) Math.Sqrt(n) + 1, 2);
        }
    }
}