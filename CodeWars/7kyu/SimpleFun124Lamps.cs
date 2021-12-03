/*
https://www.codewars.com/kata/58a3c1f12f949e21b300005c/csharp

7 kyu
Simple Fun #124: Lamps

Task
N lamps are placed in a line, some are switched on and some are off. 
What is the smallest number of lamps that need to be switched so that on and off lamps will alternate with each other?

You are given an array a of zeros and ones - 1 mean switched-on lamp and 0 means switched-off.

Your task is to find the smallest number of lamps that need to be switched.

Example
For a = [1, 0, 0, 1, 1, 1, 0], the result should be 3.

a --> 1 0 0 1 1 1 0 swith --> 0 1 0 became--> 0 1 0 1 0 1 0

Input/Output
[input] integer array a

array of zeros and ones - initial lamp setup, 1 mean switched-on lamp and 0 means switched-off.

2 < a.length <= 1000

[output] an integer

minimum number of switches.

*/

using System;
using System.Linq;

namespace CodeWars
{
    public class SimpleFun124Lamps
    {
        public int Lamps(int[] a)
        {
            // return Enumerable.Range(0, 2).Select(i =>
            //     Enumerable.Range(i, a.Length).Select(j => j % 2).Zip(a, (f, l) => f.CompareTo(l))
            //         .Count(j => j != 0)).Min();


            // int n = a.Zip(Enumerable.Range(0, a.Count()), (x, i) => x != i % 2).Count(x => x);
            // return Math.Min(n, a.Count() - n);


            var count = a.Where((x, i) => x != (i & 1)).Count();
            return Math.Min(count, a.Length - count);
        }
    }
}