/*
https://www.codewars.com/kata/515f51d438015969f7000013/csharp

6 kyu
Pyramid Array

Write a function that when given a number >= 0, returns an Array of ascending length subarrays.

pyramid(0) => [ ]
pyramid(1) => [ [1] ]
pyramid(2) => [ [1], [1, 1] ]
pyramid(3) => [ [1], [1, 1], [1, 1, 1] ]
Note: the subarrays should be filled with 1s
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class PyramidArray
    {
        public static int[][] Pyramid(int n)
        {
            return new int[n][].Select((_, i) => Enumerable.Repeat(1, i + 1).ToArray()).ToArray();
            // return Enumerable.Range(1, n).Select(i => Enumerable.Repeat(1, i).ToArray()).ToArray();
            // return new int[n][].Select((_, i) => new int[i + 1].Select(j => 1).ToArray()).ToArray();

            // var result = new List<int[]>();
            // for (var i = 1; i <= n; i++)
            // {
            //     result.Add(Enumerable.Repeat(1, i).ToArray());
            // }
            // return result.ToArray();
        }
    }
}