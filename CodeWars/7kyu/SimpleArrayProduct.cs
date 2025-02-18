﻿/*
https://www.codewars.com/kata/5d0365accfd09600130a00c9/csharp

7 kyu
Simple array product

In this Kata, you will be given a multi-dimensional array containing 2 or more sub-arrays of integers. 
Your task is to find the maximum product that can be formed by taking any one element from each sub-array.

Examples:
solve( [[1, 2],[3, 4]] ) = 8. The max product is given by 2 * 4
solve( [[10,-15],[-1,-3]] ) = 45, given by (-15) * (-3)
solve( [[1,-1],[2,3],[10,-100]] ) = 300, given by (-1) * 3 * (-100)
More examples in test cases. Good luck!
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class SimpleArrayProduct
    {
        public static int solve(int[][] arr)
        {
            return arr.Aggregate(new[] { 1 }, (a, c) => a.SelectMany(x => c.Select(i => x * i)).ToArray()).Max();
        }
    }
}