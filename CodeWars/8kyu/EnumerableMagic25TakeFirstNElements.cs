/*
https://www.codewars.com/kata/545afd0761aa4c3055001386

8 kyu
Enumerable Magic #25 - Take the First N Elements

Create a method take that accepts a list/array and a number n, 
and returns a list/array array of the first n elements from the list/array.

If you need help, here's a reference:

https://docs.python.org/3/library/stdtypes.html#sequence-types-list-tuple-range
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CodeWarsTests
{
    public class EnumerableMagic25TakeFirstNElements
    {
        public static int[] Take(int[] arr, int n)
        {
            return arr.Take(n).ToArray();
            // return arr[..Math.Min(n, arr.Length)];
            // return new ArraySegment<int>(arr, 0, Math.Min(n, arr.Length)).ToArray();
            // return new Span<int>(arr, 0, Math.Min(n, arr.Length)).ToArray();
        }
    }
}